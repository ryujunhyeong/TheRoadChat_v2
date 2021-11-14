
namespace TheRoadChat
{
    partial class friendForm
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelFriend = new System.Windows.Forms.Label();
            this.ImgFriend = new System.Windows.Forms.PictureBox();
            this.buttonDelFriend = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImgFriend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDelFriend)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFriend
            // 
            this.labelFriend.AutoSize = true;
            this.labelFriend.Font = new System.Drawing.Font("굴림", 12F);
            this.labelFriend.Location = new System.Drawing.Point(69, 17);
            this.labelFriend.Name = "labelFriend";
            this.labelFriend.Size = new System.Drawing.Size(77, 16);
            this.labelFriend.TabIndex = 2;
            this.labelFriend.Text = "친구 이름";
            // 
            // ImgFriend
            // 
            this.ImgFriend.Image = global::TheRoadChat.Properties.Resources.user;
            this.ImgFriend.Location = new System.Drawing.Point(16, 7);
            this.ImgFriend.Name = "ImgFriend";
            this.ImgFriend.Size = new System.Drawing.Size(35, 35);
            this.ImgFriend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgFriend.TabIndex = 1;
            this.ImgFriend.TabStop = false;
            // 
            // buttonDelFriend
            // 
            this.buttonDelFriend.Image = global::TheRoadChat.Properties.Resources.delFriend;
            this.buttonDelFriend.Location = new System.Drawing.Point(354, 9);
            this.buttonDelFriend.Name = "buttonDelFriend";
            this.buttonDelFriend.Size = new System.Drawing.Size(30, 30);
            this.buttonDelFriend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonDelFriend.TabIndex = 3;
            this.buttonDelFriend.TabStop = false;
            this.buttonDelFriend.Click += new System.EventHandler(this.buttonDelFriend_Click);
            // 
            // friendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.buttonDelFriend);
            this.Controls.Add(this.labelFriend);
            this.Controls.Add(this.ImgFriend);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.Name = "friendForm";
            this.Size = new System.Drawing.Size(395, 50);
            ((System.ComponentModel.ISupportInitialize)(this.ImgFriend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDelFriend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImgFriend;
        private System.Windows.Forms.Label labelFriend;
        private System.Windows.Forms.PictureBox buttonDelFriend;
    }
}
