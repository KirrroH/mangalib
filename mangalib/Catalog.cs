using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace mangalib
{
    public partial class Catalog : Form
    {
        public int mlID;

        public Catalog(int id)
        {
            InitializeComponent();

            mlID = id;
        }

        private void fill_grid(string condition)
        {
            string query = $"select id_manga, name_manga as 'Название', author as 'Автор' from manga where id_manga not in({Var.IDlist}){condition};";
            MySqlConnection conn = DBUtils.GetConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();

            try
            {
                conn.Open();
                adapter.Fill(dt);
                dgv_catalog.DataSource = dt;
                dgv_catalog.ClearSelection();
                dgv_catalog.Columns[0].Visible = false;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
            }
        }

        private void Catalog_Load(object sender, EventArgs e)
        {
            fill_grid("");
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            fill_grid($" and concat(name_manga, author) like '%{txt_search.Text}%'");
        }

        private void dgv_catalog_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = e.RowIndex;
            if (selectedRow > 0)
            {
                DataGridViewRow row = dgv_catalog.Rows[selectedRow];
                int id_manga = Convert.ToInt32(row.Cells[0].Value);
                AddManga win = new AddManga(mlID, id_manga);
                win.Owner = this;
                win.Show();
                this.Hide();
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            fill_grid("");
        }
    }
}