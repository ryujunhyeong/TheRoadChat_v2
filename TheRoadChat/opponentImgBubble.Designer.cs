
namespace TheRoadChat
{
    partial class opponentImgBubble
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
            this.labelTime = new System.Windows.Forms.Label();
            this.FriendImg = new System.Windows.Forms.PictureBox();
            this.labelFriendName = new System.Windows.Forms.Label();
            this.pictureBoxImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.FriendImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImg)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTime
            // 
            this.labelTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(232, 126);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(29, 12);
            this.labelTime.TabIndex = 6;
            this.labelTime.Text = "시간";
            // 
            // FriendImg
            // 
            this.FriendImg.Image = global::TheRoadChat.Properties.Resources.user;
            this.FriendImg.Location = new System.Drawing.Point(12, 98);
            this.FriendImg.Name = "FriendImg";
            this.FriendImg.Size = new System.Drawing.Size(40, 40);
            this.FriendImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FriendImg.TabIndex = 5;
            this.FriendImg.TabStop = false;
            // 
            // labelFriendName
            // 
            this.labelFriendName.AutoSize = true;
            this.labelFriendName.Location = new System.Drawing.Point(204, 92);
            this.labelFriendName.Name = "labelFriendName";
            this.labelFriendName.Size = new System.Drawing.Size(57, 12);
            this.labelFriendName.TabIndex = 4;
            this.labelFriendName.Text = "친구 이름";
            // 
            // pictureBoxImg
            // 
            this.pictureBoxImg.Location = new System.Drawing.Point(63, 10);
            this.pictureBoxImg.Name = "pictureBoxImg";
            this.pictureBoxImg.Size = new System.Drawing.Size(130, 130);
            this.pictureBoxImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImg.TabIndex = 7;
            this.pictureBoxImg.TabStop = false;
            // 
            // opponentImgBubble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBoxImg);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.FriendImg);
            this.Controls.Add(this.labelFriendName);
            this.Name = "opponentImgBubble";
            this.Size = new System.Drawing.Size(395, 150);
            ((System.ComponentModel.ISupportInitialize)(this.FriendImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.PictureBox FriendImg;
        private System.Windows.Forms.Label labelFriendName;
        private System.Windows.Forms.PictureBox pictureBoxImg;
    }
}
