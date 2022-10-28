using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace mangalib
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void Auth_Load(object sender, EventArgs e)
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

        private void btn_login_Click(object sender, EventArgs e)
        {
            if ((txt_login.Text != "") && (txt_pass.Text != ""))
            {
                string query_log = $"select id_login from login where login = '{txt_login.Text}' and pass = '{txt_pass.Text}';";
                MySqlConnection conn = DBUtils.GetConnection();
                MySqlCommand cmd_log = new MySqlCommand(query_log, conn);

                try
                {
                    int id_login = 0;
                    conn.Open();
                    id_login = Convert.ToInt32(cmd_log.ExecuteScalar());
                    conn.Close();

                    if (id_login > 0)
                    {
                        txt_login.Clear();
                        txt_pass.Clear();
                        link_show.Visible = true;
                        link_hide.Visible = false;
                        txt_pass.UseSystemPasswordChar = true;
                        Menu win = new Menu(id_login);
                        win.Owner = this;
                        win.Show();
                        this.Hide();
                    }
                    else MessageBox.Show("Логин или пароль введены неверно!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Возникла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
                }
            }
            else MessageBox.Show("Заполните все поля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void link_signup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Reg win = new Reg();
            win.Owner = this;
            win.Show();
            this.Hide();
        }

        private void Auth_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}