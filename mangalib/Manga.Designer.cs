namespace mangalib
{
    partial class Manga
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_author = new System.Windows.Forms.TextBox();
            this.txt_t_status = new System.Windows.Forms.TextBox();
            this.txt_tr_status = new System.Windows.Forms.TextBox();
            this.txt_chapters = new System.Windows.Forms.TextBox();
            this.txt_tags = new System.Windows.Forms.TextBox();
            this.txt_folder = new System.Windows.Forms.TextBox();
            this.combo_folder = new System.Windows.Forms.ComboBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Автор";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Статус тайтла";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Статус перевода";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Загруженные главы";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Тэги";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(93, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Список";
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(12, 271);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(165, 30);
            this.btn_edit.TabIndex = 1;
            this.btn_edit.Text = "Изменить список";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(12, 316);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(83, 30);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "Назад";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(153, 13);
            this.txt_name.Name = "txt_name";
            this.txt_name.ReadOnly = true;
            this.txt_name.Size = new System.Drawing.Size(320, 22);
            this.txt_name.TabIndex = 2;
            // 
            // txt_author
            // 
            this.txt_author.Location = new System.Drawing.Point(153, 41);
            this.txt_author.Name = "txt_author";
            this.txt_author.ReadOnly = true;
            this.txt_author.Size = new System.Drawing.Size(320, 22);
            this.txt_author.TabIndex = 2;
            // 
            // txt_t_status
            // 
            this.txt_t_status.Location = new System.Drawing.Point(153, 69);
            this.txt_t_status.Name = "txt_t_status";
            this.txt_t_status.ReadOnly = true;
            this.txt_t_status.Size = new System.Drawing.Size(165, 22);
            this.txt_t_status.TabIndex = 2;
            // 
            // txt_tr_status
            // 
            this.txt_tr_status.Location = new System.Drawing.Point(153, 97);
            this.txt_tr_status.Name = "txt_tr_status";
            this.txt_tr_status.ReadOnly = true;
            this.txt_tr_status.Size = new System.Drawing.Size(165, 22);
            this.txt_tr_status.TabIndex = 2;
            // 
            // txt_chapters
            // 
            this.txt_chapters.Location = new System.Drawing.Point(153, 125);
            this.txt_chapters.Name = "txt_chapters";
            this.txt_chapters.ReadOnly = true;
            this.txt_chapters.Size = new System.Drawing.Size(165, 22);
            this.txt_chapters.TabIndex = 2;
            // 
            // txt_tags
            // 
            this.txt_tags.Location = new System.Drawing.Point(153, 153);
            this.txt_tags.Multiline = true;
            this.txt_tags.Name = "txt_tags";
            this.txt_tags.ReadOnly = true;
            this.txt_tags.Size = new System.Drawing.Size(320, 73);
            this.txt_tags.TabIndex = 2;
            // 
            // txt_folder
            // 
            this.txt_folder.Location = new System.Drawing.Point(153, 232);
            this.txt_folder.Name = "txt_folder";
            this.txt_folder.ReadOnly = true;
            this.txt_folder.Size = new System.Drawing.Size(165, 22);
            this.txt_folder.TabIndex = 2;
            // 
            // combo_folder
            // 
            this.combo_folder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_folder.FormattingEnabled = true;
            this.combo_folder.Location = new System.Drawing.Point(153, 231);
            this.combo_folder.Name = "combo_folder";
            this.combo_folder.Size = new System.Drawing.Size(165, 24);
            this.combo_folder.TabIndex = 3;
            this.combo_folder.Visible = false;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(183, 271);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(165, 30);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "Удалить из списка";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Visible = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // Manga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 358);
            this.Controls.Add(this.combo_folder);
            this.Controls.Add(this.txt_folder);
            this.Controls.Add(this.txt_tags);
            this.Controls.Add(this.txt_chapters);
            this.Controls.Add(this.txt_tr_status);
            this.Controls.Add(this.txt_t_status);
            this.Controls.Add(this.txt_author);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "Manga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Манга";
            this.Load += new System.EventHandler(this.Manga_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_author;
        private System.Windows.Forms.TextBox txt_t_status;
        private System.Windows.Forms.TextBox txt_tr_status;
        private System.Windows.Forms.TextBox txt_chapters;
        private System.Windows.Forms.TextBox txt_tags;
        private System.Windows.Forms.TextBox txt_folder;
        private System.Windows.Forms.ComboBox combo_folder;
        private System.Windows.Forms.Button btn_delete;
    }
}