using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace mangalib
{
    public partial class Reg : Form
    {
        public Reg()
        {
            InitializeComponent();
        }

        private void Reg_Load(object sender, EventArgs e)
        {
            txt_pass.UseSystemPasswordChar = true;
        }

        private void link_show_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txt_pass.UseSystemPasswordChar = false;
            link_show.Visible = false;
            link_hide.Visible = true;
        }

        private void link_hide_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txt_pass.UseSystemPasswordChar = true;
            link_show.Visible = true;
            link_hide.Visible = false;
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            if ((txt_login.Text != "") && (txt_username.Text != "") && (txt_pass.Text != ""))
            {
                string query_check = $"select count(*) from login where login = '{txt_login.Text}';";
                MySqlConnection conn = DBUtils.GetConnection();
                MySqlCommand cmd_check = new MySqlCommand(query_check, conn);
                conn.Open();

                try
                {
                    int result = 0;
                    result = Convert.ToInt32(cmd_check.ExecuteScalar());
                    if (result == 0)
                    {
                        try
                        {
                            string query_login = $"insert into login (login, pass) values ('{txt_login.Text}', '{txt_pass.Text}');";
                            MySqlCommand cmd_login = new MySqlCommand(query_login, conn);
                            cmd_login.ExecuteNonQuery();

                            string query_user = $"insert into users (id_login, name_user, manga_list, reg_date) values ((select max(id_login) from login), '{txt_username.Text}', (select max(id_login) from login), current_date());";
                            MySqlCommand cmd_user = new MySqlCommand(query_user, conn);
                            cmd_user.ExecuteNonQuery();

                            if (MessageBox.Show("Аккаунт успешно создан!", "Успех!") == DialogResult.OK)
                            {
                                Owner.Show();
                                this.Close();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Возникла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
                        }
                    }
                    else MessageBox.Show("Пользователь с таким логином уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Возникла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
                }
                conn.Close();
            }
            else MessageBox.Show("Заполните все поля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Регистрация будет отменена. Вы уверены, что хотите вернуться?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Owner.Show();
                this.Close();
            }
        }
    }
}