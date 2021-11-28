
namespace TheRoadChat
{
    partial class chat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelMyName = new System.Windows.Forms.Label();
            this.labelFriendOrChannel = new System.Windows.Forms.Label();
            this.buttonFriendOfFriend = new System.Windows.Forms.Button();
            this.buttonFriendList = new System.Windows.Forms.Button();
            this.buttonChannelList = new System.Windows.Forms.Button();
            this.layout = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonPlusChannel = new System.Windows.Forms.PictureBox();
            this.buttonPlusFriend = new System.Windows.Forms.PictureBox();
            this.ButtonClose = new System.Windows.Forms.PictureBox();
            this.buttonSetting = new System.Windows.Forms.PictureBox();
            this.userImg = new System.Windows.Forms.PictureBox();
            this.pictureBoxAlarm = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPlusChannel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPlusFriend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlarm)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMyName
            // 
            this.labelMyName.AutoSize = true;
            this.labelMyName.Location = new System.Drawing.Point(102, 46);
            this.labelMyName.Name = "labelMyName";
            this.labelMyName.Size = new System.Drawing.Size(69, 12);
            this.labelMyName.TabIndex = 1;
            this.labelMyName.Text = "사용자 이름";
            // 
            // labelFriendOrChannel
            // 
            this.labelFriendOrChannel.AutoSize = true;
            this.labelFriendOrChannel.Location = new System.Drawing.Point(32, 99);
            this.labelFriendOrChannel.Name = "labelFriendOrChannel";
            this.labelFriendOrChannel.Size = new System.Drawing.Size(29, 12);
            this.labelFriendOrChannel.TabIndex = 2;
            this.labelFriendOrChannel.Text = "친구";
            // 
            // buttonFriendOfFriend
            // 
            this.buttonFriendOfFriend.Location = new System.Drawing.Point(287, 87);
            this.buttonFriendOfFriend.Name = "buttonFriendOfFriend";
            this.buttonFriendOfFriend.Size = new System.Drawing.Size(104, 23);
            this.buttonFriendOfFriend.TabIndex = 3;
            this.buttonFriendOfFriend.Text = "친구의 친구";
            this.buttonFriendOfFriend.UseVisualStyleBackColor = true;
            this.buttonFriendOfFriend.Click += new System.EventHandler(this.buttonFriendOfFriend_Click);
            // 
            // buttonFriendList
            // 
            this.buttonFriendList.Location = new System.Drawing.Point(12, 544);
            this.buttonFriendList.Name = "buttonFriendList";
            this.buttonFriendList.Size = new System.Drawing.Size(181, 44);
            this.buttonFriendList.TabIndex = 5;
            this.buttonFriendList.Text = "친구";
            this.buttonFriendList.UseVisualStyleBackColor = true;
            this.buttonFriendList.Click += new System.EventHandler(this.buttonFriendList_Click);
            // 
            // buttonChannelList
            // 
            this.buttonChannelList.Location = new System.Drawing.Point(216, 544);
            this.buttonChannelList.Name = "buttonChannelList";
            this.buttonChannelList.Size = new System.Drawing.Size(189, 44);
            this.buttonChannelList.TabIndex = 5;
            this.buttonChannelList.Text = "채팅";
            this.buttonChannelList.UseVisualStyleBackColor = true;
            this.buttonChannelList.Click += new System.EventHandler(this.buttonChannelList_Click);
            // 
            // layout
            // 
            this.layout.AutoScroll = true;
            this.layout.Location = new System.Drawing.Point(1, 122);
            this.layout.Margin = new System.Windows.Forms.Padding(0);
            this.layout.Name = "layout";
            this.layout.Size = new System.Drawing.Size(415, 415);
            this.layout.TabIndex = 6;
            // 
            // buttonPlusChannel
            // 
            this.buttonPlusChannel.Image = global::TheRoadChat.Properties.Resources.plusChat;
            this.buttonPlusChannel.Location = new System.Drawing.Point(287, 29);
            this.buttonPlusChannel.Name = "buttonPlusChannel";
            this.buttonPlusChannel.Size = new System.Drawing.Size(25, 25);
            this.buttonPlusChannel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonPlusChannel.TabIndex = 7;
            this.buttonPlusChannel.TabStop = false;
            this.buttonPlusChannel.Click += new System.EventHandler(this.buttonPlusChannel_Click);
            // 
            // buttonPlusFriend
            // 
            this.buttonPlusFriend.Image = global::TheRoadChat.Properties.Resources.plusFriend;
            this.buttonPlusFriend.Location = new System.Drawing.Point(326, 29);
            this.buttonPlusFriend.Name = "buttonPlusFriend";
            this.buttonPlusFriend.Size = new System.Drawing.Size(25, 25);
            this.buttonPlusFriend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonPlusFriend.TabIndex = 7;
            this.buttonPlusFriend.TabStop = false;
            this.buttonPlusFriend.Click += new System.EventHandler(this.buttonPlusFriend_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.Image = global::TheRoadChat.Properties.Resources.x;
            this.ButtonClose.Location = new System.Drawing.Point(393, -2);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(25, 25);
            this.ButtonClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ButtonClose.TabIndex = 0;
            this.ButtonClose.TabStop = false;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // buttonSetting
            // 
            this.buttonSetting.Image = global::TheRoadChat.Properties.Resources.setting;
            this.buttonSetting.Location = new System.Drawing.Point(367, 29);
            this.buttonSetting.Name = "buttonSetting";
            this.buttonSetting.Size = new System.Drawing.Size(25, 25);
            this.buttonSetting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonSetting.TabIndex = 0;
            this.buttonSetting.TabStop = false;
            // 
            // userImg
            // 
            this.userImg.Image = global::TheRoadChat.Properties.Resources.user;
            this.userImg.Location = new System.Drawing.Point(32, 29);
            this.userImg.Name = "userImg";
            this.userImg.Size = new System.Drawing.Size(50, 50);
            this.userImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userImg.TabIndex = 0;
            this.userImg.TabStop = false;
            // 
            // pictureBoxAlarm
            // 
            this.pictureBoxAlarm.Image = global::TheRoadChat.Properties.Resources.alarmOn;
            this.pictureBoxAlarm.Location = new System.Drawing.Point(245, 29);
            this.pictureBoxAlarm.Name = "pictureBoxAlarm";
            this.pictureBoxAlarm.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxAlarm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAlarm.TabIndex = 7;
            this.pictureBoxAlarm.TabStop = false;
            this.pictureBoxAlarm.Click += new System.EventHandler(this.pictureBoxAlarm_Click);
            // 
            // chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 600);
            this.Controls.Add(this.pictureBoxAlarm);
            this.Controls.Add(this.buttonPlusChannel);
            this.Controls.Add(this.buttonPlusFriend);
            this.Controls.Add(this.layout);
            this.Controls.Add(this.buttonChannelList);
            this.Controls.Add(this.buttonFriendList);
            this.Controls.Add(this.buttonFriendOfFriend);
            this.Controls.Add(this.labelFriendOrChannel);
            this.Controls.Add(this.labelMyName);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.buttonSetting);
            this.Controls.Add(this.userImg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "chat";
            this.Text = "chat";
            ((System.ComponentModel.ISupportInitialize)(this.buttonPlusChannel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPlusFriend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlarm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox userImg;
        private System.Windows.Forms.Label labelMyName;
        private System.Windows.Forms.PictureBox buttonSetting;
        private System.Windows.Forms.Label labelFriendOrChannel;
        private System.Windows.Forms.Button buttonFriendOfFriend;
        private System.Windows.Forms.Button buttonFriendList;
        private System.Windows.Forms.Button buttonChannelList;
        private System.Windows.Forms.FlowLayoutPanel layout;
        private System.Windows.Forms.PictureBox buttonPlusFriend;
        private System.Windows.Forms.PictureBox ButtonClose;
        private System.Windows.Forms.PictureBox buttonPlusChannel;
        private System.Windows.Forms.PictureBox pictureBoxAlarm;
    }
}