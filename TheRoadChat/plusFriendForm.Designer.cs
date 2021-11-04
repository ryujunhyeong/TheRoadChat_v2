
namespace TheRoadChat
{
    partial class plusFriendForm
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
            this.buttonPlusFriend = new System.Windows.Forms.Button();
            this.textBoxIDInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonPlusFriend
            // 
            this.buttonPlusFriend.Location = new System.Drawing.Point(59, 73);
            this.buttonPlusFriend.Name = "buttonPlusFriend";
            this.buttonPlusFriend.Size = new System.Drawing.Size(99, 20);
            this.buttonPlusFriend.TabIndex = 0;
            this.buttonPlusFriend.Text = "친구 추가";
            this.buttonPlusFriend.UseVisualStyleBackColor = true;
            this.buttonPlusFriend.Click += new System.EventHandler(this.buttonPlusFriend_Click);
            // 
            // textBoxIDInput
            // 
            this.textBoxIDInput.Location = new System.Drawing.Point(59, 35);
            this.textBoxIDInput.Name = "textBoxIDInput";
            this.textBoxIDInput.Size = new System.Drawing.Size(100, 21);
            this.textBoxIDInput.TabIndex = 1;
            // 
            // plusFriendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 117);
            this.Controls.Add(this.textBoxIDInput);
            this.Controls.Add(this.buttonPlusFriend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "plusFriendForm";
            this.Text = "plusFriendForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPlusFriend;
        private System.Windows.Forms.TextBox textBoxIDInput;
    }
}