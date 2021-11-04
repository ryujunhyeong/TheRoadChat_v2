
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
            this.PanelMsg.Location = new System.Drawing.Point(0, 65);
            this.PanelMsg.Margin = new System.Windows.Forms.Padding(0);
            this.PanelMsg.Name = "PanelMsg";
            this.PanelMsg.Size = new System.Drawing.Size(415, 440);
            this.PanelMsg.TabIndex = 1;
            // 
            // textBoxMsgInput
            // 
            this.textBoxMsgInput.Location = new System.Drawing.Point(12, 508);
            this.textBoxMsgInput.Multiline = true;
            this.textBoxMsgInput.Name = "textBoxMsgInput";
            this.textBoxMsgInput.Size = new System.Drawing.Size(340, 64);
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
            // 
            // InChannelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 600);
            this.Controls.Add(this.buttonMsgSend);
            this.Controls.Add(this.textBoxMsgInput);
            this.Controls.Add(this.PanelMsg);
            this.Controls.Add(this.labelChannelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InChannelForm";
            this.Text = "InChannelForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelChannelName;
        private System.Windows.Forms.FlowLayoutPanel PanelMsg;
        private System.Windows.Forms.TextBox textBoxMsgInput;
        private System.Windows.Forms.Button buttonMsgSend;
    }
}