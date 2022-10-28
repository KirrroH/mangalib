namespace mangalib
{
    partial class Menu
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
            this.btn_profile = new System.Windows.Forms.Button();
            this.btn_mangalist = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_profile
            // 
            this.btn_profile.Location = new System.Drawing.Point(71, 13);
            this.btn_profile.Name = "btn_profile";
            this.btn_profile.Size = new System.Drawing.Size(186, 34);
            this.btn_profile.TabIndex = 0;
            this.btn_profile.Text = "Профиль";
            this.btn_profile.UseVisualStyleBackColor = true;
            this.btn_profile.Click += new System.EventHandler(this.btn_profile_Click);
            // 
            // btn_mangalist
            // 
            this.btn_mangalist.Location = new System.Drawing.Point(70, 53);
            this.btn_mangalist.Name = "btn_mangalist";
            this.btn_mangalist.Size = new System.Drawing.Size(187, 34);
            this.btn_mangalist.TabIndex = 0;
            this.btn_mangalist.Text = "Закладки";
            this.btn_mangalist.UseVisualStyleBackColor = true;
            this.btn_mangalist.Click += new System.EventHandler(this.btn_mangalist_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(70, 93);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(187, 34);
            this.btn_logout.TabIndex = 0;
            this.btn_logout.Text = "Выйти из аккаунта";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(71, 133);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(186, 34);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "Выйти из приложения";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 179);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_mangalist);
            this.Controls.Add(this.btn_profile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_profile;
        private System.Windows.Forms.Button btn_mangalist;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_exit;
    }
}