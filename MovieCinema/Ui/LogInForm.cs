using MovieCinema;
using MovieCinema.Repositories;
using MovieCinema.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ui
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string ConnectionString = "server=DESKTOP-V3MP8OJ\\SQL1919;database=MoviesDB;integrated security=True";
            IRepository<User> userRepo = new UserRepository(ConnectionString);
            UserService uService = new UserService(userRepo);
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            User user = uService.Login(email, password);
            if (user == null)
            {
                MessageBox.Show("Invalid Credentials");
            }
            else
            {

                MessageBox.Show($"Welcome {user.GetUserName()}");
                this.Hide();
                if (user.GetIsAdmin() == true)
                {
                    AdminForm adminForm = new AdminForm();
                    adminForm.ShowDialog();
                }
                else
                {
                    MainForm mainForm = new MainForm();
                    mainForm.ShowDialog();
                }
                this.Close();

            }
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
            this.Close();

        }
    }
}
