namespace mangalib
{
    partial class Reg
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
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.link_hide = new System.Windows.Forms.LinkLabel();
            this.link_show = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_signup = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(80, 125);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(173, 22);
            this.txt_pass.TabIndex = 17;
            // 
            // txt_login
            // 
            this.txt_login.Location = new System.Drawing.Point(80, 70);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(173, 22);
            this.txt_login.TabIndex = 16;
            // 
            // link_hide
            // 
            this.link_hide.ActiveLinkColor = System.Drawing.Color.MediumBlue;
            this.link_hide.AutoSize = true;
            this.link_hide.Location = new System.Drawing.Point(259, 128);
            this.link_hide.Name = "link_hide";
            this.link_hide.Size = new System.Drawing.Size(104, 16);
            this.link_hide.TabIndex = 13;
            this.link_hide.TabStop = true;
            this.link_hide.Text = "Скрыть пароль";
            this.link_hide.Visible = false;
            this.link_hide.VisitedLinkColor = System.Drawing.Color.Blue;
            this.link_hide.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_hide_LinkClicked);
            // 
            // link_show
            // 
            this.link_show.ActiveLinkColor = System.Drawing.Color.MediumBlue;
            this.link_show.AutoSize = true;
            this.link_show.Location = new System.Drawing.Point(259, 128);
            this.link_show.Name = "link_show";
            this.link_show.Size = new System.Drawing.Size(120, 16);
            this.link_show.TabIndex = 14;
            this.link_show.TabStop = true;
            this.link_show.Text = "Показать пароль";
            this.link_show.VisitedLinkColor = System.Drawing.Color.Blue;
            this.link_show.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_show_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Логин";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(134, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "MANGALIB";
            // 
            // btn_signup
            // 
            this.btn_signup.Location = new System.Drawing.Point(110, 177);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(173, 30);
            this.btn_signup.TabIndex = 9;
            this.btn_signup.Text = "Зарегистрироваться";
            this.btn_signup.UseVisualStyleBackColor = true;
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Никнейм";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(80, 97);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(173, 22);
            this.txt_username.TabIndex = 16;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(12, 177);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(70, 30);
            this.btn_back.TabIndex = 9;
            this.btn_back.Text = "Назад";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 223);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.txt_login);
            this.Controls.Add(this.link_hide);
            this.Controls.Add(this.link_show);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_signup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Reg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.Reg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.LinkLabel link_hide;
        private System.Windows.Forms.LinkLabel link_show;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_signup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Button btn_back;
    }
}