using MovieCinema;
using MovieCinema.Repositories;
using MovieCinema.Users;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ui
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
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
            this.Text = "Cinema Library - Register";

            // Apply styles to all controls
            foreach (Control control in this.Controls)
            {
                ApplyControlTheme(control);
            }

            // Custom styling
            panelContainer.BackColor = Color.FromArgb(25, 25, 35);

            lblTitle.ForeColor = Color.FromArgb(255, 193, 7);
            lblTitle.Font = new Font("Segoe UI", 18f, FontStyle.Bold);

            btnRegister.BackColor = Color.FromArgb(40, 167, 69);
            btnRegister.ForeColor = Color.White;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.Font = new Font("Segoe UI", 11f, FontStyle.Bold);
            btnRegister.Cursor = Cursors.Hand;

            // Add hover effects
            btnRegister.MouseEnter += (s, e) => btnRegister.BackColor = Color.FromArgb(30, 147, 59);
            btnRegister.MouseLeave += (s, e) => btnRegister.BackColor = Color.FromArgb(40, 167, 69);
        }

        private void ApplyControlTheme(Control control)
        {
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
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Keep existing logic
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string ConnectionString = "server=DESKTOP-V3MP8OJ\\SQL1919;database=MoviesDB;integrated security=True";
            IRepository<User> userRepo = new UserRepository(ConnectionString);
            UserService uService = new UserService(userRepo);
            string name = txtName.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            string password = txtPassword.Text;

            if (name.Equals("") || email.Equals("") || phone.Equals("") || password.Equals(""))
            {
                MessageBox.Show("Fill in the fields properly");
            }
            else
            {
                User user = new User(0, name, email, password, phone, false);
                MessageBox.Show($"Welcome {user.GetUserName()}!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

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
    }
}