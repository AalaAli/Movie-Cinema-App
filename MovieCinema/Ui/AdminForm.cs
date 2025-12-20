using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ui
{
    public partial class AdminForm : Form
    {
        public AdminForm()
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
            this.Text = "Cinema Library - Admin Dashboard";

            // Apply styles to all controls
            ApplyControlThemes();

            // Custom styling for panels
            panelContainer.BackColor = Color.FromArgb(25, 25, 35);

            // Style title label
            lblTitle.ForeColor = Color.FromArgb(255, 193, 7); // Gold cinema color
            lblTitle.Font = new Font("Segoe UI", 22f, FontStyle.Bold);
            lblTitle.Text = "ADMIN DASHBOARD";

            lblSubtitle.ForeColor = Color.FromArgb(200, 200, 220);
            lblSubtitle.Font = new Font("Segoe UI", 11f, FontStyle.Regular);
            lblSubtitle.Text = "Manage Your Cinema Library";

            // Style buttons with different colors for different actions
            StyleButton(btnManageMovies, Color.FromArgb(128, 0, 0)); 
            StyleButton(btnManageShowTimes, Color.FromArgb(40, 167, 69));
            StyleButton(btnManageGenre, Color.FromArgb(128, 0, 0));

            // Style admin info labels if they exist
            if (lblAdminInfo != null)
            {
                lblAdminInfo.ForeColor = Color.FromArgb(180, 180, 200);
                lblAdminInfo.Font = new Font("Segoe UI", 10f, FontStyle.Regular);
            }
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
            if (control is Panel panel)
            {
                panel.BackColor = Color.FromArgb(25, 25, 35);
                foreach (Control child in panel.Controls)
                {
                    ApplyControlTheme(child);
                }
            }
            else if (control is Label label && !label.Name.StartsWith("lbl"))
            {
                label.ForeColor = Color.FromArgb(180, 180, 200);
                label.Font = new Font("Segoe UI", 9.5f, FontStyle.Regular);
            }
        }

        private void StyleButton(Button button, Color backgroundColor)
        {
            button.BackColor = backgroundColor;
            button.ForeColor = Color.White;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.Font = new Font("Segoe UI", 12f, FontStyle.Bold);
            button.Cursor = Cursors.Hand;
            button.Padding = new Padding(20, 15, 20, 15);
            button.Height = 60;

            // Store original color
            var originalColor = backgroundColor;
            var hoverColor = Color.FromArgb(
                Math.Max(backgroundColor.R - 30, 0),
                Math.Max(backgroundColor.G - 30, 0),
                Math.Max(backgroundColor.B - 30, 0)
            );

            button.MouseEnter += (s, e) => button.BackColor = hoverColor;
            button.MouseLeave += (s, e) => button.BackColor = originalColor;
        }


        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void btnManageMovies_Click(object sender, EventArgs e)
        {
            ManageMoviesForm manageMovies = new ManageMoviesForm();
            this.Hide();
            manageMovies.ShowDialog();
            this.Close();
        }

        private void btnManageShowTimes_Click(object sender, EventArgs e)
        {
            ManageShowTimes manageShowTimes = new ManageShowTimes();
            this.Hide();
            manageShowTimes.ShowDialog();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnManageGenre_Click(object sender, EventArgs e)
        {
            ManageGenres manageGenres = new ManageGenres();
            this.Hide();
            manageGenres.ShowDialog();
            this.Close();
        }
    }
}