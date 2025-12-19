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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string ConnectionString = "server=DESKTOP-V3MP8OJ\\SQL1919;database=MoviesDB;integrated security=True";
            IRepository<User> userRepo = new UserRepository(ConnectionString);
            UserService uService = new UserService(userRepo);
            string userName = txtName.Text;
            string email = txtEmail.Text;
            string phone= txtPhone.Text;
            string password = txtPassword.Text;

            User user = new User(0, userName, email, password, phone, false);
            uService.Register(user);
            MessageBox.Show($"User {userName} registered successfully");
            this.Hide();

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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
