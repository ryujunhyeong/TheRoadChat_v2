var app = require("express")();
var server = require("http").createServer(app);
// http server를 socket.io server로 upgrade한다
var io = require("socket.io")(server);
const mysql = require("mysql2");

const connection = mysql.createConnection({
  host: "210.125.31.247",
  user: "test",
  password: "s1234",
  database: "theroad",
});

connection.connect();

// localhost:3000으로 서버에 접속하면 클라이언트로 index.html을 전송한다
app.get("/", function (req, res) {
  res.sendFile(__dirname + "/index-room.html");
});

// namespace /chat에 접속한다.
var chat = io.on("connection", function (socket) {
  console.log("user connected" + socket.id);
  socket.on("chat message", function (data) {
    console.log(data);
    // console.log('message from client: ', data);
    var room = (socket.room = data.i_channel);

    // room에 join한다
    socket.join(room);
    // room에 join되어 있는 클라이언트에게 메시지를 전송한다
    //chat.to(room).broadcast.emit('chat message', data.msg);

    var msg = {
      i_user: data.i_user,
      i_channel: data.i_channel,
      user_name: data.user_name,
      msg: data.msg,
      m_dt: data.m_dt,
      i_file: data.i_file,
    };

    socket.in(room).emit("chat message", msg); //broadcast 동일하게 가능 자신 제외 룸안의 유저

    connection.query(
      "INSERT INTO messageTable VALUES(NULL," +
        data.i_user +
        ", " +
        data.i_channel +
        ', "' +
        data.msg +
        '", ' +
        "now(), now(), " +
        data.i_file +
        ")",
      (error, rows, fields) => {
        if (error) throw error;
        console.log("User info is: ", rows);
      }
    );
  });

  socket.on("login", function (data) {
    console.log(data);

    let rooms = data.split(" ");

    console.log(rooms[0]);

    let i_user = rooms[0];
    let roomArr = rooms.slice(1);

    for (var room in roomArr) {
      console.log(i_user + " entrance " + room);
      socket.join(room);
    }
  });

  socket.on("checkFriend", function (data) {
    console.log("checkFriend : " + data);

    socket.broadcast.emit("checkFriend", data);
  });

  socket.on("disconnect", function () {
    console.log("user disconnected: " + socket.id);
  });
});

server.listen(3000, function () {
  console.log("Socket IO server listening on port 3000");
});
