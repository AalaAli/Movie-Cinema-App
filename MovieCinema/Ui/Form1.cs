using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MovieCinema;
using MovieCinema.Repositories;
using MovieCinema.Users;
namespace Ui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Initialize your existing service
            string connectionString = "";
            IRepository<User> userRepo = new UserRepository(connectionString);
            UserService userService = new UserService(userRepo);

            // Optional: Make it look nicer
            StyleForm();

        }

        private void StyleForm()
        {
            // Simple styling without external frameworks
            this.BackColor = Color.FromArgb(240, 240, 240);
            btnLogin.BackColor = Color.FromArgb(0, 120, 215); // Windows blue
            btnLogin.ForeColor = Color.White;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0;

            // Make textboxes look nicer
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;

            // Add padding inside textboxes
            txtEmail.Margin = new Padding(5);
            txtPassword.Margin = new Padding(5);
        }
        private void LogInBtn_Click(object sender, EventArgs e)
        {
            string connectionString ="";
            IRepository<User> userRepo = new UserRepository(connectionString);
            UserService userService = new UserService(userRepo);

            userService.Login(txtEmail.Text, txtPassword.Text);
        }

        private void ExailTxt_TextContentChangedEnhanced(object sender, SiticoneNetFrameworkUI.EmailChangedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
