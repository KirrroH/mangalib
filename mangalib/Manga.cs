using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace mangalib
{
    public partial class Manga : Form
    {
        public int mlID, mangaID;

        public Manga(int mangalist, int id_manga)
        {
            InitializeComponent();

            mlID = mangalist;
            mangaID = id_manga;
        }

        private void fill_combo()
        {
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
            string query = $"select f.id_folder, m.name_manga, m.author, ts.name_t_status, trs.name_tr_status, m.chapters, m.tags, f.name_folder from manga m join manga_list ml on m.id_manga = ml.id_manga join title_status ts on m.title_status = ts.id_t_status join translate_status trs on m.translate_status = trs.id_tr_status join folder f on ml.id_folder = f.id_folder where ml.manga_list = {mlID} and ml.id_manga = {mangaID};";
            MySqlConnection conn = DBUtils.GetConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn);

            try
            {
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    txt_name.Text = reader[1].ToString();
                    txt_author.Text = reader[2].ToString();
                    txt_t_status.Text = reader[3].ToString();
                    txt_tr_status.Text = reader[4].ToString();
                    txt_chapters.Text = reader[5].ToString();
                    txt_tags.Text = reader[6].ToString();
                    txt_folder.Text = reader[7].ToString();
                    combo_folder.SelectedIndex = Convert.ToInt32(reader[0].ToString()) - 1;
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
            }
        }

        private void Manga_Load(object sender, EventArgs e)
        {
            fill_combo();
            fill_form();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            switch (btn_edit.Text)
            {
                case "Изменить список":
                    txt_folder.Visible = false;
                    combo_folder.Visible = true;
                    btn_delete.Visible = true;
                    btn_edit.Text = "Сохранить";
                    break;
                case "Сохранить":
                    string query_upd = $"update manga_list set id_folder = {combo_folder.SelectedIndex + 1} where manga_list = {mlID} and id_manga = {mangaID};";
                    MySqlConnection conn = DBUtils.GetConnection();
                    MySqlCommand cmd_upd = new MySqlCommand(query_upd, conn);
                    
                    try
                    {
                        conn.Open();
                        cmd_upd.ExecuteNonQuery();
                        conn.Close();
                        fill_form();
                        txt_folder.Visible = true;
                        combo_folder.Visible = false;
                        btn_delete.Visible = false;
                        btn_edit.Text = "Изменить список";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Возникла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
                    }
                    break;
                default:
                    break;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить тайтл из списка?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string query_del = $"delete from manga_list where manga_list = {mlID} and id_manga = {mangaID};";
                MySqlConnection conn = DBUtils.GetConnection();
                MySqlCommand cmd_del = new MySqlCommand(query_del, conn);

                try
                {
                    conn.Open();
                    cmd_del.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Возникла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            switch (btn_edit.Text)
            {
                case "Изменить список":
                    Owner.Show();
                    this.Close();
                    break;

                case "Сохранить":
                    if (MessageBox.Show("Изменения не будут сохранены. Вы уверены, что хотите вернуться?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        Owner.Show();
                        this.Close();
                    }
                    break;

                default:
                    break;
            }
        }
    }
}