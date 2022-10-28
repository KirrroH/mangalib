namespace mangalib
{
    partial class AddManga
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
            this.combo_folder = new System.Windows.Forms.ComboBox();
            this.txt_tags = new System.Windows.Forms.TextBox();
            this.txt_chapters = new System.Windows.Forms.TextBox();
            this.txt_tr_status = new System.Windows.Forms.TextBox();
            this.txt_t_status = new System.Windows.Forms.TextBox();
            this.txt_author = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // combo_folder
            // 
            this.combo_folder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_folder.FormattingEnabled = true;
            this.combo_folder.Location = new System.Drawing.Point(155, 236);
            this.combo_folder.Name = "combo_folder";
            this.combo_folder.Size = new System.Drawing.Size(165, 24);
            this.combo_folder.TabIndex = 21;
            // 
            // txt_tags
            // 
            this.txt_tags.Location = new System.Drawing.Point(155, 154);
            this.txt_tags.Multiline = true;
            this.txt_tags.Name = "txt_tags";
            this.txt_tags.ReadOnly = true;
            this.txt_tags.Size = new System.Drawing.Size(320, 73);
            this.txt_tags.TabIndex = 18;
            // 
            // txt_chapters
            // 
            this.txt_chapters.Location = new System.Drawing.Point(155, 126);
            this.txt_chapters.Name = "txt_chapters";
            this.txt_chapters.ReadOnly = true;
            this.txt_chapters.Size = new System.Drawing.Size(165, 22);
            this.txt_chapters.TabIndex = 17;
            // 
            // txt_tr_status
            // 
            this.txt_tr_status.Location = new System.Drawing.Point(155, 98);
            this.txt_tr_status.Name = "txt_tr_status";
            this.txt_tr_status.ReadOnly = true;
            this.txt_tr_status.Size = new System.Drawing.Size(165, 22);
            this.txt_tr_status.TabIndex = 16;
            // 
            // txt_t_status
            // 
            this.txt_t_status.Location = new System.Drawing.Point(155, 70);
            this.txt_t_status.Name = "txt_t_status";
            this.txt_t_status.ReadOnly = true;
            this.txt_t_status.Size = new System.Drawing.Size(165, 22);
            this.txt_t_status.TabIndex = 15;
            // 
            // txt_author
            // 
            this.txt_author.Location = new System.Drawing.Point(155, 42);
            this.txt_author.Name = "txt_author";
            this.txt_author.ReadOnly = true;
            this.txt_author.Size = new System.Drawing.Size(320, 22);
            this.txt_author.TabIndex = 14;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(155, 14);
            this.txt_name.Name = "txt_name";
            this.txt_name.ReadOnly = true;
            this.txt_name.Size = new System.Drawing.Size(320, 22);
            this.txt_name.TabIndex = 20;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(14, 320);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(83, 30);
            this.btn_back.TabIndex = 13;
            this.btn_back.Text = "Назад";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(14, 275);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(135, 30);
            this.btn_add.TabIndex = 11;
            this.btn_add.Text = "Добавить";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(95, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Список";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(111, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Тэги";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Загруженные главы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Статус перевода";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Статус тайтла";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Автор";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Название";
            // 
            // AddManga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 362);
            this.Controls.Add(this.combo_folder);
            this.Controls.Add(this.txt_tags);
            this.Controls.Add(this.txt_chapters);
            this.Controls.Add(this.txt_tr_status);
            this.Controls.Add(this.txt_t_status);
            this.Controls.Add(this.txt_author);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddManga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить в список";
            this.Load += new System.EventHandler(this.AddManga_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_folder;
        private System.Windows.Forms.TextBox txt_tags;
        private System.Windows.Forms.TextBox txt_chapters;
        private System.Windows.Forms.TextBox txt_tr_status;
        private System.Windows.Forms.TextBox txt_t_status;
        private System.Windows.Forms.TextBox txt_author;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}