using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace mangalib
{
    public partial class AddManga : Form
    {
        public int mangaID, mlID;

        public AddManga(int mangalist, int id_manga)
        {
            InitializeComponent();

            mangaID = id_manga;
            mlID = mangalist;
        }

        private void fill_combo()
        {
            combo_folder.Items.Add("Не в списке");
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

        private void fill_form()
        {
            string query = $"select m.name_manga, m.author, ts.name_t_status, trs.name_tr_status, m.chapters, m.tags from manga m join title_status ts on m.title_status = ts.id_t_status join translate_status trs on m.translate_status = trs.id_tr_status where m.id_manga = {mangaID};";
            MySqlConnection conn = DBUtils.GetConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn);

            try
            {
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    txt_name.Text = reader[0].ToString();
                    txt_author.Text = reader[1].ToString();
                    txt_t_status.Text = reader[2].ToString();
                    txt_tr_status.Text = reader[3].ToString();
                    txt_chapters.Text = reader[4].ToString();
                    txt_tags.Text = reader[5].ToString();
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
            }
        }

        private void AddManga_Load(object sender, EventArgs e)
        {
            fill_combo();
            fill_form();
            combo_folder.SelectedIndex = 0;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (combo_folder.SelectedIndex > 0)
            {
                string query = $"insert into manga_list values ({mlID}, {mangaID}, {combo_folder.SelectedIndex});";
                MySqlConnection conn = DBUtils.GetConnection();
                MySqlCommand cmd = new MySqlCommand(query, conn);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    Var.IDlist += $",{mangaID}";
                    Owner.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Возникла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
                }
            }
            else MessageBox.Show("Список не выбран!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Тайтл не будет добавлен в список. Вы уверены, что хотите вернуться?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Owner.Show();
                this.Hide();
            }
        }
    }
}