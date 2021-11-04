
namespace TheRoadChat
{
    partial class opponentBubble
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelFriendName = new System.Windows.Forms.Label();
            this.FriendImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.FriendImg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("굴림", 12F);
            this.label1.Location = new System.Drawing.Point(64, 22);
            this.label1.MinimumSize = new System.Drawing.Size(200, 30);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Size = new System.Drawing.Size(200, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "메시지 내용";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelFriendName
            // 
            this.labelFriendName.AutoSize = true;
            this.labelFriendName.Location = new System.Drawing.Point(67, 4);
            this.labelFriendName.Name = "labelFriendName";
            this.labelFriendName.Size = new System.Drawing.Size(57, 12);
            this.labelFriendName.TabIndex = 1;
            this.labelFriendName.Text = "친구 이름";
            // 
            // FriendImg
            // 
            this.FriendImg.Image = global::TheRoadChat.Properties.Resources.user;
            this.FriendImg.Location = new System.Drawing.Point(11, 12);
            this.FriendImg.Name = "FriendImg";
            this.FriendImg.Size = new System.Drawing.Size(40, 40);
            this.FriendImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FriendImg.TabIndex = 2;
            this.FriendImg.TabStop = false;
            // 
            // opponentBubble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.FriendImg);
            this.Controls.Add(this.labelFriendName);
            this.Controls.Add(this.label1);
            this.Name = "opponentBubble";
            this.Size = new System.Drawing.Size(395, 65);
            ((System.ComponentModel.ISupportInitialize)(this.FriendImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFriendName;
        private System.Windows.Forms.PictureBox FriendImg;
    }
}
