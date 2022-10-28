namespace mangalib
{
    partial class Mangalist
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
            this.dgv_mangalist = new System.Windows.Forms.DataGridView();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mangalist)).BeginInit();
            this.SuspendLayout();
            // 
            // combo_folder
            // 
            this.combo_folder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_folder.FormattingEnabled = true;
            this.combo_folder.Location = new System.Drawing.Point(13, 13);
            this.combo_folder.Name = "combo_folder";
            this.combo_folder.Size = new System.Drawing.Size(165, 24);
            this.combo_folder.TabIndex = 0;
            this.combo_folder.SelectedIndexChanged += new System.EventHandler(this.combo_folder_SelectedIndexChanged);
            // 
            // dgv_mangalist
            // 
            this.dgv_mangalist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_mangalist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mangalist.Location = new System.Drawing.Point(13, 57);
            this.dgv_mangalist.Name = "dgv_mangalist";
            this.dgv_mangalist.ReadOnly = true;
            this.dgv_mangalist.RowHeadersWidth = 51;
            this.dgv_mangalist.RowTemplate.Height = 24;
            this.dgv_mangalist.Size = new System.Drawing.Size(775, 289);
            this.dgv_mangalist.TabIndex = 3;
            this.dgv_mangalist.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_mangalist_CellContentDoubleClick);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(13, 366);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(88, 30);
            this.btn_back.TabIndex = 4;
            this.btn_back.Text = "Назад";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(692, 366);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(96, 30);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "Добавить";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(692, 12);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(96, 30);
            this.btn_refresh.TabIndex = 4;
            this.btn_refresh.Text = "Обновить";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // Mangalist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 409);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.dgv_mangalist);
            this.Controls.Add(this.combo_folder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Mangalist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Закладки";
            this.Load += new System.EventHandler(this.Mangalist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mangalist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_folder;
        private System.Windows.Forms.DataGridView dgv_mangalist;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_refresh;
    }
}