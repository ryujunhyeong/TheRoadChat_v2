
namespace TheRoadChat
{
    partial class InviteChannelForm
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
            this.listBoxFriend = new System.Windows.Forms.ListBox();
            this.listBoxInvite = new System.Windows.Forms.ListBox();
            this.buttonInvite = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ButtonClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonClose)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxFriend
            // 
            this.listBoxFriend.FormattingEnabled = true;
            this.listBoxFriend.ItemHeight = 12;
            this.listBoxFriend.Location = new System.Drawing.Point(28, 67);
            this.listBoxFriend.Name = "listBoxFriend";
            this.listBoxFriend.Size = new System.Drawing.Size(228, 112);
            this.listBoxFriend.TabIndex = 0;
            this.listBoxFriend.DoubleClick += new System.EventHandler(this.listBoxFriend_DoubleClick);
            // 
            // listBoxInvite
            // 
            this.listBoxInvite.FormattingEnabled = true;
            this.listBoxInvite.ItemHeight = 12;
            this.listBoxInvite.Location = new System.Drawing.Point(28, 214);
            this.listBoxInvite.Name = "listBoxInvite";
            this.listBoxInvite.Size = new System.Drawing.Size(228, 112);
            this.listBoxInvite.TabIndex = 0;
            // 
            // buttonInvite
            // 
            this.buttonInvite.Location = new System.Drawing.Point(28, 344);
            this.buttonInvite.Name = "buttonInvite";
            this.buttonInvite.Size = new System.Drawing.Size(228, 23);
            this.buttonInvite.TabIndex = 2;
            this.buttonInvite.Text = "초대";
            this.buttonInvite.UseVisualStyleBackColor = true;
            this.buttonInvite.Click += new System.EventHandler(this.buttonInvite_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TheRoadChat.Properties.Resources.arrow;
            this.pictureBox1.Location = new System.Drawing.Point(129, 183);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // ButtonClose
            // 
            this.ButtonClose.Image = global::TheRoadChat.Properties.Resources.x;
            this.ButtonClose.Location = new System.Drawing.Point(259, -1);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(25, 25);
            this.ButtonClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ButtonClose.TabIndex = 5;
            this.ButtonClose.TabStop = false;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // InviteChannelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 399);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.buttonInvite);
            this.Controls.Add(this.listBoxInvite);
            this.Controls.Add(this.listBoxFriend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InviteChannelForm";
            this.Text = "InviteChannelForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFriend;
        private System.Windows.Forms.ListBox listBoxInvite;
        private System.Windows.Forms.Button buttonInvite;
        private System.Windows.Forms.PictureBox ButtonClose;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}