
namespace TheRoadChat
{
    partial class InChannelForm
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
            this.labelChannelName = new System.Windows.Forms.Label();
            this.PanelMsg = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxMsgInput = new System.Windows.Forms.TextBox();
            this.buttonMsgSend = new System.Windows.Forms.Button();
            this.textBoxSearchMsgInput = new System.Windows.Forms.TextBox();
            this.buttonSearchMsg = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.PictureBox();
            this.buttonInvite = new System.Windows.Forms.Button();
            this.buttonImgOrFileSend = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonEmoticon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonClose)).BeginInit();
            this.SuspendLayout();
            // 
            // labelChannelName
            // 
            this.labelChannelName.AutoSize = true;
            this.labelChannelName.Font = new System.Drawing.Font("굴림", 15F);
            this.labelChannelName.Location = new System.Drawing.Point(26, 29);
            this.labelChannelName.Name = "labelChannelName";
            this.labelChannelName.Size = new System.Drawing.Size(96, 20);
            this.labelChannelName.TabIndex = 0;
            this.labelChannelName.Text = "채널 이름";
            // 
            // PanelMsg
            // 
            this.PanelMsg.AutoScroll = true;
            this.PanelMsg.Location = new System.Drawing.Point(0, 65);
            this.PanelMsg.Margin = new System.Windows.Forms.Padding(0);
            this.PanelMsg.Name = "PanelMsg";
            this.PanelMsg.Size = new System.Drawing.Size(415, 440);
            this.PanelMsg.TabIndex = 1;
            // 
            // textBoxMsgInput
            // 
            this.textBoxMsgInput.Location = new System.Drawing.Point(40, 508);
            this.textBoxMsgInput.Multiline = true;
            this.textBoxMsgInput.Name = "textBoxMsgInput";
            this.textBoxMsgInput.Size = new System.Drawing.Size(312, 64);
            this.textBoxMsgInput.TabIndex = 2;
            // 
            // buttonMsgSend
            // 
            this.buttonMsgSend.Location = new System.Drawing.Point(359, 509);
            this.buttonMsgSend.Name = "buttonMsgSend";
            this.buttonMsgSend.Size = new System.Drawing.Size(46, 63);
            this.buttonMsgSend.TabIndex = 3;
            this.buttonMsgSend.Text = "전송";
            this.buttonMsgSend.UseVisualStyleBackColor = true;
            this.buttonMsgSend.Click += new System.EventHandler(this.buttonMsgSend_Click);
            // 
            // textBoxSearchMsgInput
            // 
            this.textBoxSearchMsgInput.Location = new System.Drawing.Point(224, 31);
            this.textBoxSearchMsgInput.Name = "textBoxSearchMsgInput";
            this.textBoxSearchMsgInput.Size = new System.Drawing.Size(100, 21);
            this.textBoxSearchMsgInput.TabIndex = 5;
            // 
            // buttonSearchMsg
            // 
            this.buttonSearchMsg.Location = new System.Drawing.Point(330, 31);
            this.buttonSearchMsg.Name = "buttonSearchMsg";
            this.buttonSearchMsg.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchMsg.TabIndex = 6;
            this.buttonSearchMsg.Text = "검색";
            this.buttonSearchMsg.UseVisualStyleBackColor = true;
            this.buttonSearchMsg.Click += new System.EventHandler(this.buttonSearchMsg_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.Image = global::TheRoadChat.Properties.Resources.x;
            this.ButtonClose.Location = new System.Drawing.Point(393, -1);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(25, 25);
            this.ButtonClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ButtonClose.TabIndex = 4;
            this.ButtonClose.TabStop = false;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // buttonInvite
            // 
            this.buttonInvite.Location = new System.Drawing.Point(143, 29);
            this.buttonInvite.Name = "buttonInvite";
            this.buttonInvite.Size = new System.Drawing.Size(75, 23);
            this.buttonInvite.TabIndex = 8;
            this.buttonInvite.Text = "친구 초대";
            this.buttonInvite.UseVisualStyleBackColor = true;
            this.buttonInvite.Click += new System.EventHandler(this.buttonInvite_Click);
            // 
            // buttonImgOrFileSend
            // 
            this.buttonImgOrFileSend.Location = new System.Drawing.Point(4, 509);
            this.buttonImgOrFileSend.Name = "buttonImgOrFileSend";
            this.buttonImgOrFileSend.Size = new System.Drawing.Size(34, 63);
            this.buttonImgOrFileSend.TabIndex = 9;
            this.buttonImgOrFileSend.Text = "+";
            this.buttonImgOrFileSend.UseVisualStyleBackColor = true;
            this.buttonImgOrFileSend.Click += new System.EventHandler(this.buttonImgOrFileSend_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonEmoticon
            // 
            this.buttonEmoticon.Location = new System.Drawing.Point(4, 574);
            this.buttonEmoticon.Name = "buttonEmoticon";
            this.buttonEmoticon.Size = new System.Drawing.Size(75, 23);
            this.buttonEmoticon.TabIndex = 10;
            this.buttonEmoticon.Text = "이모티콘";
            this.buttonEmoticon.UseVisualStyleBackColor = true;
            this.buttonEmoticon.Click += new System.EventHandler(this.buttonEmoticon_Click);
            // 
            // InChannelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 600);
            this.Controls.Add(this.buttonEmoticon);
            this.Controls.Add(this.buttonImgOrFileSend);
            this.Controls.Add(this.buttonInvite);
            this.Controls.Add(this.buttonSearchMsg);
            this.Controls.Add(this.textBoxSearchMsgInput);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.buttonMsgSend);
            this.Controls.Add(this.textBoxMsgInput);
            this.Controls.Add(this.PanelMsg);
            this.Controls.Add(this.labelChannelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InChannelForm";
            this.Text = "InChannelForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InChannelForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ButtonClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelChannelName;
        private System.Windows.Forms.FlowLayoutPanel PanelMsg;
        private System.Windows.Forms.TextBox textBoxMsgInput;
        private System.Windows.Forms.Button buttonMsgSend;
        private System.Windows.Forms.PictureBox ButtonClose;
        private System.Windows.Forms.TextBox textBoxSearchMsgInput;
        private System.Windows.Forms.Button buttonSearchMsg;
        private System.Windows.Forms.Button buttonInvite;
        private System.Windows.Forms.Button buttonImgOrFileSend;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonEmoticon;
    }
}