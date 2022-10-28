using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace mangalib
{
    public partial class Mangalist : Form
    {
        public int mangalistID;

        public Mangalist(int id_login)
        {
            InitializeComponent();

            mangalistID = id_login;
        }

        private void fill_grid(string condition)
        {
            string query = $"select m.id_manga, m.name_manga as 'Название', m.author as 'Автор', f.name_folder as 'Список' from manga_list ml join manga m on ml.id_manga = m.id_manga join folder f on ml.id_folder = f.id_folder where manga_list = {mangalistID}{condition};";
            MySqlConnection conn = DBUtils.GetConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();

            try
            {
                conn.Open();
                adapter.Fill(dt);
                dgv_mangalist.DataSource = dt;
                dgv_mangalist.ClearSelection();
                dgv_mangalist.Columns[0].Visible = false;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
            }
        }

        private void fill_combo()
        {
            combo_folder.Items.Add("Все списки");
            string query = "select name_folder from folder;";
            MySqlConnection conn = DBUtils.GetConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn);

            try
            {
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    combo_folder.Items.Add(reader[0].ToString());
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
            }
        }

        private void Mangalist_Load(object sender, EventArgs e)
        {
            fill_grid("");
            fill_combo();
            combo_folder.SelectedIndex = 0;
        }

        private void combo_folder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_folder.SelectedIndex == 0) fill_grid("");
            else fill_grid($" and ml.id_folder = {combo_folder.SelectedIndex}");
        }

        private void dgv_mangalist_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = e.RowIndex;
            if (selectedRow > 0)
            {
                DataGridViewRow row = dgv_mangalist.Rows[selectedRow];
                int id_manga = Convert.ToInt32(row.Cells[0].Value);
                Manga win = new Manga(mangalistID, id_manga);
                win.Owner = this;
                win.Show();
                this.Hide();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string query = $"select id_manga from manga_list where manga_list = {mangalistID};";
            MySqlConnection conn = DBUtils.GetConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn);

            try
            {
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Var.IDlist += reader[0].ToString() + ",";
                }
                reader.Close();
                conn.Close();
                Var.IDlist = Var.IDlist.Remove(Var.IDlist.Length - 1);

                Catalog win = new Catalog(mangalistID);
                win.Owner = this;
                win.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
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
            fill_combo();
            combo_folder.SelectedIndex = 0;
        }
    }
}