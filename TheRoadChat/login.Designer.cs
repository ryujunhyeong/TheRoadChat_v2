
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
            this.autoLoginCheck = new System.Windows.Forms.CheckBox();
            this.Login_button_Join = new System.Windows.Forms.Button();
            this.Login_label_PW = new System.Windows.Forms.Label();
            this.Login_label_ID = new System.Windows.Forms.Label();
            this.Login_button_Login = new System.Windows.Forms.Button();
            this.Login_textBox_Pw = new System.Windows.Forms.TextBox();
            this.Login_textBox_ID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // autoLoginCheck
            // 
            this.autoLoginCheck.AutoSize = true;
            this.autoLoginCheck.Location = new System.Drawing.Point(144, 251);
            this.autoLoginCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.autoLoginCheck.Name = "autoLoginCheck";
            this.autoLoginCheck.Size = new System.Drawing.Size(88, 16);
            this.autoLoginCheck.TabIndex = 13;
            this.autoLoginCheck.Text = "자동 로그인";
            this.autoLoginCheck.UseVisualStyleBackColor = true;
            this.autoLoginCheck.CheckedChanged += new System.EventHandler(this.autoLoginCheck_CheckedChanged);
            // 
            // Login_button_Join
            // 
            this.Login_button_Join.Location = new System.Drawing.Point(110, 203);
            this.Login_button_Join.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Login_button_Join.Name = "Login_button_Join";
            this.Login_button_Join.Size = new System.Drawing.Size(181, 33);
            this.Login_button_Join.TabIndex = 12;
            this.Login_button_Join.Text = "회원가입";
            this.Login_button_Join.UseVisualStyleBackColor = true;
            this.Login_button_Join.Click += new System.EventHandler(this.Login_button_Join_Click);
            // 
            // Login_label_PW
            // 
            this.Login_label_PW.AutoSize = true;
            this.Login_label_PW.Location = new System.Drawing.Point(42, 119);
            this.Login_label_PW.Name = "Login_label_PW";
            this.Login_label_PW.Size = new System.Drawing.Size(62, 12);
            this.Login_label_PW.TabIndex = 11;
            this.Login_label_PW.Text = "Password";
            // 
            // Login_label_ID
            // 
            this.Login_label_ID.AutoSize = true;
            this.Login_label_ID.Location = new System.Drawing.Point(88, 75);
            this.Login_label_ID.Name = "Login_label_ID";
            this.Login_label_ID.Size = new System.Drawing.Size(16, 12);
            this.Login_label_ID.TabIndex = 10;
            this.Login_label_ID.Text = "ID";
            // 
            // Login_button_Login
            // 
            this.Login_button_Login.Location = new System.Drawing.Point(110, 160);
            this.Login_button_Login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Login_button_Login.Name = "Login_button_Login";
            this.Login_button_Login.Size = new System.Drawing.Size(181, 33);
            this.Login_button_Login.TabIndex = 9;
            this.Login_button_Login.Text = "로그인";
            this.Login_button_Login.UseVisualStyleBackColor = true;
            this.Login_button_Login.Click += new System.EventHandler(this.Login_button_Login_Click);
            // 
            // Login_textBox_Pw
            // 
            this.Login_textBox_Pw.Location = new System.Drawing.Point(110, 116);
            this.Login_textBox_Pw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Login_textBox_Pw.Name = "Login_textBox_Pw";
            this.Login_textBox_Pw.Size = new System.Drawing.Size(182, 21);
            this.Login_textBox_Pw.TabIndex = 8;
            this.Login_textBox_Pw.TextChanged += new System.EventHandler(this.Login_textBox_Pw_TextChanged);
            // 
            // Login_textBox_ID
            // 
            this.Login_textBox_ID.Location = new System.Drawing.Point(110, 72);
            this.Login_textBox_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Login_textBox_ID.Name = "Login_textBox_ID";
            this.Login_textBox_ID.Size = new System.Drawing.Size(182, 21);
            this.Login_textBox_ID.TabIndex = 7;
            this.Login_textBox_ID.TextChanged += new System.EventHandler(this.loginID_TextChanged);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 349);
            this.Controls.Add(this.autoLoginCheck);
            this.Controls.Add(this.Login_button_Join);
            this.Controls.Add(this.Login_label_PW);
            this.Controls.Add(this.Login_label_ID);
            this.Controls.Add(this.Login_button_Login);
            this.Controls.Add(this.Login_textBox_Pw);
            this.Controls.Add(this.Login_textBox_ID);
            this.Name = "login";
            this.Text = "login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox autoLoginCheck;
        private System.Windows.Forms.Button Login_button_Join;
        private System.Windows.Forms.Label Login_label_PW;
        private System.Windows.Forms.Label Login_label_ID;
        private System.Windows.Forms.Button Login_button_Login;
        private System.Windows.Forms.TextBox Login_textBox_Pw;
        private System.Windows.Forms.TextBox Login_textBox_ID;
    }
}

