using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace mangalib
{
    public partial class Profile : Form
    {
        public int loginID;

        public Profile(int id_login)
        {
            InitializeComponent();

            loginID = id_login;
        }

        private void fill_form()
        {
            string query = $"select l.login, u.name_user, u.reg_date, u.bio from login l join users u on l.id_login = u.id_login where u.id_login = {loginID};";
            MySqlConnection conn = DBUtils.GetConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            
            try
            {
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    txt_login.Text = reader[0].ToString();
                    txt_username.Text = reader[1].ToString();
                    txt_regdate.Text = Convert.ToDateTime(reader[2].ToString()).ToShortDateString();
                    txt_bio.Text = reader[3].ToString();
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
            }
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            fill_form();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            switch (btn_edit.Text)
            {
                case "Редактировать":
                    txt_login.ReadOnly = false;
                    txt_username.ReadOnly = false;
                    txt_bio.ReadOnly = false;
                    btn_delete.Visible = true;
                    btn_edit.Text = "Сохранить";
                    break;

                case "Сохранить":
                    if ((txt_login.Text != "") && (txt_username.Text != ""))
                    {
                        MySqlConnection conn = DBUtils.GetConnection();

                        string query_log = $"select login from login where id_login = {loginID};";
                        MySqlCommand cmd_log = new MySqlCommand(query_log, conn);

                        string query_count = $"select count(*) from login where login = '{txt_login.Text}';";
                        MySqlCommand cmd_count = new MySqlCommand(query_count, conn);

                        conn.Open();
                        try
                        {
                            string log = "";
                            log = cmd_log.ExecuteScalar().ToString();

                            int count = 0;
                            count = Convert.ToInt32(cmd_count.ExecuteScalar());

                            if ((count == 0) || (log == txt_login.Text))
                            {
                                string query_upd_log = $"update login set login = '{txt_login.Text}' where id_login = {loginID};";
                                MySqlCommand cmd_upd_log = new MySqlCommand(query_upd_log, conn);

                                string query_upd_user = $"update users set name_user = '{txt_username.Text}', bio = '{txt_bio.Text}' where id_login = {loginID};";
                                MySqlCommand cmd_upd_user = new MySqlCommand(query_upd_user, conn);

                                try
                                {
                                    cmd_upd_log.ExecuteNonQuery();
                                    cmd_upd_user.ExecuteNonQuery();
                                    fill_form();
                                    txt_login.ReadOnly = true;
                                    txt_username.ReadOnly = true;
                                    txt_bio.ReadOnly = true;
                                    btn_delete.Visible = false;
                                    btn_edit.Text = "Редактировать";
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Возникла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
                                }
                            }
                            else MessageBox.Show("Логин занят!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Возникла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
                        }
                        conn.Close();
                    }
                    else MessageBox.Show("Поля логин и никнейм обязательны для заполнения!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                default:
                    break;
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            switch (btn_edit.Text)
            {
                case "Редактировать":
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

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить аккаунт?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MySqlConnection conn = DBUtils.GetConnection();

                string query_mangalist = $"delete from manga_list where manga_list = {loginID};";
                MySqlCommand cmd_mangalist = new MySqlCommand(query_mangalist, conn);

                string query_user = $"delete from users where id_login = {loginID};";
                MySqlCommand cmd_user = new MySqlCommand(query_user, conn);

                string query_login = $"delete from login where id_login = {loginID};";
                MySqlCommand cmd_login = new MySqlCommand(query_login, conn);

                try
                {
                    conn.Open();
                    cmd_mangalist.ExecuteNonQuery();
                    cmd_user.ExecuteNonQuery();
                    cmd_login.ExecuteNonQuery();
                    conn.Close();
                    Auth win = new Auth();
                    win.Show();
                    Owner.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Возникла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
                }
            }
        }
    }
}