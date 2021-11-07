const users=[]

const addRooms = (i_user, rooms) => {

    const user = { i_user:i_user, room:rooms }
    users.push(user)
    console.log(users)
    return { user }
}

const getRooms = i_user => {
    let rooms = users[i_user]
    return rooms
}

const deleteUser = (id) => {
    const index = users.findIndex((user) => user.id === id);
    if (index !== -1) return users.splice(index, 1)[0];
}

const getUsers = (room) => users.filter(user => user.room === room)

module.exports = { addRooms, getRooms, deleteUser, getUsers }