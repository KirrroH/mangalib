namespace mangalib
{
    partial class Auth
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.link_show = new System.Windows.Forms.LinkLabel();
            this.link_signup = new System.Windows.Forms.LinkLabel();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.link_hide = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(140, 158);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(104, 30);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "Войти";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(125, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "MANGALIB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Пароль";
            // 
            // link_show
            // 
            this.link_show.ActiveLinkColor = System.Drawing.Color.MediumBlue;
            this.link_show.AutoSize = true;
            this.link_show.Location = new System.Drawing.Point(250, 107);
            this.link_show.Name = "link_show";
            this.link_show.Size = new System.Drawing.Size(120, 16);
            this.link_show.TabIndex = 4;
            this.link_show.TabStop = true;
            this.link_show.Text = "Показать пароль";
            this.link_show.VisitedLinkColor = System.Drawing.Color.Blue;
            this.link_show.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_show_LinkClicked);
            // 
            // link_signup
            // 
            this.link_signup.ActiveLinkColor = System.Drawing.Color.Blue;
            this.link_signup.AutoSize = true;
            this.link_signup.Location = new System.Drawing.Point(119, 202);
            this.link_signup.Name = "link_signup";
            this.link_signup.Size = new System.Drawing.Size(144, 16);
            this.link_signup.TabIndex = 6;
            this.link_signup.TabStop = true;
            this.link_signup.Text = "Зарегистрироваться";
            this.link_signup.VisitedLinkColor = System.Drawing.Color.Blue;
            this.link_signup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_signup_LinkClicked);
            // 
            // txt_login
            // 
            this.txt_login.Location = new System.Drawing.Point(71, 70);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(173, 22);
            this.txt_login.TabIndex = 7;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(71, 104);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(173, 22);
            this.txt_pass.TabIndex = 8;
            // 
            // link_hide
            // 
            this.link_hide.ActiveLinkColor = System.Drawing.Color.MediumBlue;
            this.link_hide.AutoSize = true;
            this.link_hide.Location = new System.Drawing.Point(250, 107);
            this.link_hide.Name = "link_hide";
            this.link_hide.Size = new System.Drawing.Size(104, 16);
            this.link_hide.TabIndex = 4;
            this.link_hide.TabStop = true;
            this.link_hide.Text = "Скрыть пароль";
            this.link_hide.Visible = false;
            this.link_hide.VisitedLinkColor = System.Drawing.Color.Blue;
            this.link_hide.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_hide_LinkClicked);
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 237);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_login);
            this.Controls.Add(this.link_signup);
            this.Controls.Add(this.link_hide);
            this.Controls.Add(this.link_show);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Auth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Auth_FormClosed);
            this.Load += new System.EventHandler(this.Auth_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel link_show;
        private System.Windows.Forms.LinkLabel link_signup;
        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.LinkLabel link_hide;
    }
}

