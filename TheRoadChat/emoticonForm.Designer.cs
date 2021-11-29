
namespace TheRoadChat
{
    partial class emoticonForm
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
            this.pictureBoxEmo2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxEmo1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmo1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxEmo2
            // 
            this.pictureBoxEmo2.Location = new System.Drawing.Point(153, 25);
            this.pictureBoxEmo2.Name = "pictureBoxEmo2";
            this.pictureBoxEmo2.Size = new System.Drawing.Size(90, 90);
            this.pictureBoxEmo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEmo2.TabIndex = 0;
            this.pictureBoxEmo2.TabStop = false;
            this.pictureBoxEmo2.Click += new System.EventHandler(this.pictureBoxEmo2_Click);
            // 
            // pictureBoxEmo1
            // 
            this.pictureBoxEmo1.Location = new System.Drawing.Point(27, 25);
            this.pictureBoxEmo1.Name = "pictureBoxEmo1";
            this.pictureBoxEmo1.Size = new System.Drawing.Size(90, 90);
            this.pictureBoxEmo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEmo1.TabIndex = 0;
            this.pictureBoxEmo1.TabStop = false;
            this.pictureBoxEmo1.Click += new System.EventHandler(this.pictureBoxEmo1_Click);
            // 
            // emoticonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 243);
            this.Controls.Add(this.pictureBoxEmo2);
            this.Controls.Add(this.pictureBoxEmo1);
            this.Name = "emoticonForm";
            this.Text = "emoticonForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmo1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxEmo1;
        private System.Windows.Forms.PictureBox pictureBoxEmo2;
    }
}