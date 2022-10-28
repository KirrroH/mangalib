using System;
using System.Windows.Forms;

namespace mangalib
{
    public partial class Menu : Form
    {
        public int loginID;

        public Menu(int id_login)
        {
            InitializeComponent();

            loginID = id_login;
        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            Profile win = new Profile(loginID);
            win.Owner = this;
            win.Show();
            this.Hide();
        }

        private void btn_mangalist_Click(object sender, EventArgs e)
        {
            Mangalist win = new Mangalist(loginID);
            win.Owner = this;
            win.Show();
            this.Hide();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}