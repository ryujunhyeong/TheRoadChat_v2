namespace TheRoadChat
{
    partial class plusChannelForm
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
            this.ButtonClose = new System.Windows.Forms.PictureBox();
            this.textBoxChannelNameInput = new System.Windows.Forms.TextBox();
            this.buttonPlusChannel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonClose)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonClose
            // 
            this.ButtonClose.Image = global::TheRoadChat.Properties.Resources.x;
            this.ButtonClose.Location = new System.Drawing.Point(196, 0);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(25, 25);
            this.ButtonClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ButtonClose.TabIndex = 5;
            this.ButtonClose.TabStop = false;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // textBoxChannelNameInput
            // 
            this.textBoxChannelNameInput.Location = new System.Drawing.Point(58, 35);
            this.textBoxChannelNameInput.Name = "textBoxChannelNameInput";
            this.textBoxChannelNameInput.Size = new System.Drawing.Size(100, 21);
            this.textBoxChannelNameInput.TabIndex = 4;
            // 
            // buttonPlusChannel
            // 
            this.buttonPlusChannel.Location = new System.Drawing.Point(58, 73);
            this.buttonPlusChannel.Name = "buttonPlusChannel";
            this.buttonPlusChannel.Size = new System.Drawing.Size(99, 20);
            this.buttonPlusChannel.TabIndex = 3;
            this.buttonPlusChannel.Text = "채팅방 추가";
            this.buttonPlusChannel.UseVisualStyleBackColor = true;
            this.buttonPlusChannel.Click += new System.EventHandler(this.buttonPlusChannel_Click);
            // 
            // plusChannelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 117);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.textBoxChannelNameInput);
            this.Controls.Add(this.buttonPlusChannel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "plusChannelForm";
            this.Text = "plusChannelForm";
            ((System.ComponentModel.ISupportInitialize)(this.ButtonClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ButtonClose;
        private System.Windows.Forms.TextBox textBoxChannelNameInput;
        private System.Windows.Forms.Button buttonPlusChannel;
    }
}