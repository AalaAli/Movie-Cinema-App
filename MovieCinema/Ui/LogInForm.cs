using MovieCinema;
using MovieCinema.Repositories;
using MovieCinema.Users;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ui
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
            ApplyCinemaTheme();
        }

        private void ApplyCinemaTheme()
        {
            // Form styling
            this.BackColor = Color.FromArgb(15, 15, 20);
            this.ForeColor = Color.White;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Cinema Library - Login";

            // Apply styles to all controls
            ApplyControlThemes();

            // Custom styling for specific controls
            panelContainer.BackColor = Color.FromArgb(25, 25, 35);

            lblTitle.ForeColor = Color.FromArgb(255, 193, 7); // Gold cinema color
            lblTitle.Font = new Font("Segoe UI", 18f, FontStyle.Bold);

            btnLogin.BackColor = Color.FromArgb(40, 123, 222);
            btnLogin.ForeColor = Color.White;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.Font = new Font("Segoe UI", 11f, FontStyle.Bold);
            btnLogin.Cursor = Cursors.Hand;

            linkRegister.LinkColor = Color.FromArgb(100, 181, 246);
            linkRegister.VisitedLinkColor = Color.FromArgb(129, 212, 250);
            linkRegister.ActiveLinkColor = Color.FromArgb(66, 165, 245);

            // Add hover effects
            btnLogin.MouseEnter += (s, e) => btnLogin.BackColor = Color.FromArgb(30, 113, 202);
            btnLogin.MouseLeave += (s, e) => btnLogin.BackColor = Color.FromArgb(40, 123, 222);
        }

        private void ApplyControlThemes()
        {
            foreach (Control control in this.Controls)
            {
                ApplyControlTheme(control);
            }
        }

        private void ApplyControlTheme(Control control)
        {
            // Apply to the control itself
            if (control is Panel panel)
            {
                panel.BackColor = Color.FromArgb(25, 25, 35);
                foreach (Control child in panel.Controls)
                {
                    ApplyControlTheme(child);
                }
            }
            else if (control is RichTextBox richTextBox)
            {
                richTextBox.BackColor = Color.FromArgb(40, 40, 50);
                richTextBox.ForeColor = Color.White;
                richTextBox.BorderStyle = BorderStyle.FixedSingle;
                richTextBox.Font = new Font("Segoe UI", 10.5f);
            }
            else if (control is Label label && !label.Name.StartsWith("lbl"))
            {
                label.ForeColor = Color.FromArgb(180, 180, 200);
                label.Font = new Font("Segoe UI", 9.5f, FontStyle.Regular);
            }
            else if (control is Button button && button != btnLogin)
            {
                button.BackColor = Color.FromArgb(40, 123, 222);
                button.ForeColor = Color.White;
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
                button.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
                button.Cursor = Cursors.Hand;
                button.MouseEnter += (s, e) => button.BackColor = Color.FromArgb(30, 113, 202);
                button.MouseLeave += (s, e) => button.BackColor = Color.FromArgb(40, 123, 222);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Keep existing logic
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
                MessageBox.Show("Invalid Credentials", "Login Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show($"Welcome {user.GetUserName()}!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                if (user.GetIsAdmin() == true)
                {
                    AdminForm adminForm = new AdminForm();
                    adminForm.ShowDialog();
                }
                else
                {
                    MainLibraryFrom mainForm = new MainLibraryFrom();
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