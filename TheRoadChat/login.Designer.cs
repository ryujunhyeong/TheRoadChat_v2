
namespace TheRoadChat
{
    partial class login
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.id_login = new System.Windows.Forms.TextBox();
            this.pw_login = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // id_login
            // 
            this.id_login.Location = new System.Drawing.Point(231, 145);
            this.id_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.id_login.Name = "id_login";
            this.id_login.Size = new System.Drawing.Size(182, 21);
            this.id_login.TabIndex = 0;
            // 
            // pw_login
            // 
            this.pw_login.Location = new System.Drawing.Point(231, 189);
            this.pw_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pw_login.Name = "pw_login";
            this.pw_login.Size = new System.Drawing.Size(182, 21);
            this.pw_login.TabIndex = 1;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(231, 233);
            this.btn_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(181, 33);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "button1";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(231, 96);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 21);
            this.textBox1.TabIndex = 3;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.pw_login);
            this.Controls.Add(this.id_login);
            this.Name = "login";
            this.Text = "login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox id_login;
        private System.Windows.Forms.TextBox pw_login;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox textBox1;
    }
}

