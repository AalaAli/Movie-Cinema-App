using MovieCinema.Movies;
using MovieCinema.Repositories;
using System;
using System.Drawing;
using System.Windows.Forms;
using MovieCinema.ShowTimes;
using System.Windows.Documents;

namespace Ui
{
    public partial class ManageShowTimes : Form
    {
        private readonly string _connectionString;
        private readonly IRepository<ShowTime> _showTimeRepository;
        private readonly ShowTimeService _showTimeService;

        public ManageShowTimes()
        {
            InitializeComponent();
            _connectionString = "server=DESKTOP-V3MP8OJ\\SQL1919;database=MoviesDB;integrated security=True";
            _showTimeRepository = new ShowTimeRepository(_connectionString);
            _showTimeService = new ShowTimeService(_showTimeRepository);
            ApplyCinemaTheme();
            RefreshShowTimeTable();
        }

        private void ApplyCinemaTheme()
        {
            // Form styling
            this.BackColor = Color.FromArgb(15, 15, 20);
            this.ForeColor = Color.White;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Cinema Library - Manage Show Times";

            // Apply styles to panels
            panel1.BackColor = Color.FromArgb(25, 25, 35);
            panel2.BackColor = Color.FromArgb(25, 25, 35);

            // Style title label
            label1.ForeColor = Color.FromArgb(255, 193, 7);
            label1.Font = new Font("Segoe UI", 18f, FontStyle.Bold);
            label1.Text = "MANAGE SHOW TIMES";

            // Style buttons
            StyleButton(btnAdd, Color.FromArgb(40, 167, 69));
            StyleButton(btnUpdate, Color.FromArgb(255, 193, 7));
            StyleButton(btnDelete, Color.FromArgb(220, 53, 69));
            StyleButton(btnBack, Color.FromArgb(15,15,20));


            // Style labels in panel1
            foreach (Control control in panel1.Controls)
            {
                if (control is Label label)
                {
                    label.ForeColor = Color.FromArgb(180, 180, 200);
                    label.Font = new Font("Segoe UI", 9.5f, FontStyle.Regular);
                }
                else if (control is RichTextBox rtb)
                {
                    rtb.BackColor = Color.FromArgb(40, 40, 50);
                    rtb.ForeColor = Color.White;
                    rtb.BorderStyle = BorderStyle.FixedSingle;
                    rtb.Font = new Font("Segoe UI", 10f);
                }
                else if (control is ListBox listBox)
                {
                    listBox.BackColor = Color.FromArgb(40, 40, 50);
                    listBox.ForeColor = Color.White;
                    listBox.Font = new Font("Segoe UI", 10f);
                    listBox.BorderStyle = BorderStyle.FixedSingle;
                }
                else if (control is RadioButton radio)
                {
                    radio.ForeColor = Color.FromArgb(180, 180, 200);
                    radio.Font = new Font("Segoe UI", 9f, FontStyle.Regular);
                }
            }

            // Style DataGridView
            if (tableShowTime != null)
            {
                tableShowTime.BackgroundColor = Color.FromArgb(25, 25, 35);
                tableShowTime.GridColor = Color.FromArgb(60, 60, 70);
                tableShowTime.BorderStyle = BorderStyle.FixedSingle;
                tableShowTime.EnableHeadersVisualStyles = false;
                tableShowTime.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 50);
                tableShowTime.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                tableShowTime.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
                tableShowTime.DefaultCellStyle.BackColor = Color.FromArgb(35, 35, 45);
                tableShowTime.DefaultCellStyle.ForeColor = Color.White;
                tableShowTime.DefaultCellStyle.Font = new Font("Segoe UI", 9.5f);
                tableShowTime.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 50);
                tableShowTime.RowHeadersDefaultCellStyle.ForeColor = Color.White;
                tableShowTime.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(30, 30, 40);
            }
        }

        private void StyleButton(Button button, Color backgroundColor)
        {
            button.BackColor = backgroundColor;
            button.ForeColor = Color.White;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
            button.Cursor = Cursors.Hand;
            button.Padding = new Padding(10, 5, 10, 5);

            // Hover effect
            button.MouseEnter += (s, e) => button.BackColor = Color.FromArgb(
                Math.Max(backgroundColor.R - 20, 0),
                Math.Max(backgroundColor.G - 20, 0),
                Math.Max(backgroundColor.B - 20, 0));
            button.MouseLeave += (s, e) => button.BackColor = backgroundColor;
        }

        private void ManageShowTimes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'moviesDBDataSet2.ShowTimes' table. You can move, or remove it, as needed.
            this.showTimesTableAdapter1.Fill(this.moviesDBDataSet2.ShowTimes);
            // TODO: This line of code loads data into the 'moviesDBDataSet1.ShowTimes' table. You can move, or remove it, as needed.
            this.showTimesTableAdapter.Fill(this.moviesDBDataSet1.ShowTimes);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMovieId.Text, out int movieId))
            {
                MessageBox.Show("Invalid Movie Id. Please enter a valid number.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(txtHallId.Text, out int hallID))
            {
                MessageBox.Show("Invalid Hall Id. Please enter a valid number.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!DateTime.TryParse(txtStartTime.Text, out DateTime startTime))
            {
                MessageBox.Show("Invalid Start Time. Please enter a valid date and time.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!DateTime.TryParse(txtEndTime.Text, out DateTime endTime))
            {
                MessageBox.Show("Invalid End Time. Please enter a valid date and time.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string showType;
            if (btn2D.Checked) showType = "2D";
            else if (btn3D.Checked) showType = "3D";
            else showType = "IMAX";

            string language = listLanguage.Text.ToString();

            ShowTime _showTime = new ShowTime(0, movieId, hallID, startTime, endTime, 0, language);
            if (_showTimeService.HasConflict(_showTime))
            {
                MessageBox.Show("Show Time conflict detected. Please choose a different time.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _showTimeService.AddShowTime(_showTime, showType);
            ClearForm();

            // Refresh
            RefreshShowTimeTable();

            MessageBox.Show("Show Time added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tableShowTime.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Are you sure you want to delete this movie?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    int selectedShowTimeId = Convert.ToInt32(tableShowTime.SelectedRows[0].Cells["ShowTimeId"].Value);

                    _showTimeService.DeleteShowTime(selectedShowTimeId);

                    // Refresh
                    RefreshShowTimeTable();
                    ClearForm();
                    MessageBox.Show("Show time deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a show time to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }


        private void tableShowTime_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the click is not on the header row or an invalid row
            if (e.RowIndex >= 0 && e.RowIndex < tableShowTime.Rows.Count)
            {
                DataGridViewRow row = tableShowTime.Rows[e.RowIndex];

                if (row.Cells["MovieId"].Value != null)
                {
                    txtMovieId.Text = row.Cells["MovieId"].Value?.ToString() ?? "";
                    txtHallId.Text = row.Cells["HallId"].Value?.ToString() ?? "";
                    txtStartTime.Text = row.Cells["StartTime"].Value?.ToString() ?? "";
                    txtEndTime.Text = row.Cells["EndTime"].Value?.ToString() ?? "";
                    listLanguage.Text = row.Cells["Language"].Value?.ToString() ?? "";
                    decimal price = row.Cells["Price"].Value.ToString() == "" ? 0m : Convert.ToDecimal(row.Cells["Price"].Value.ToString());
                    if (price == 10m)
                    {
                        btn2D.Checked = true;
                        btn3D.Checked = false;
                        btnMax.Checked = false;
                    }
                    else if (price == 15m)
                    {
                        btn2D.Checked = true;
                        btn3D.Checked = true;
                        btnMax.Checked = false;
                    }
                    else
                    {
                        btn2D.Checked = true;
                        btn3D.Checked = false;
                        btnMax.Checked = true;
                    }

                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tableShowTime.SelectedRows.Count > 0 && tableShowTime.SelectedRows[0].Cells["ShowTimeId"].Value != null)
            {
                int selectedShowTimeId = Convert.ToInt32(tableShowTime.SelectedRows[0].Cells["ShowTimeId"].Value);

                if (!int.TryParse(txtMovieId.Text, out int movieId))
                {
                    MessageBox.Show("Invalid Movie Id. Please enter a valid number.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!int.TryParse(txtHallId.Text, out int hallID))
                {
                    MessageBox.Show("Invalid Hall Id. Please enter a valid number.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!DateTime.TryParse(txtStartTime.Text, out DateTime startTime))
                {
                    MessageBox.Show("Invalid Start Time. Please enter a valid date and time.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!DateTime.TryParse(txtEndTime.Text, out DateTime endTime))
                {
                    MessageBox.Show("Invalid End Time. Please enter a valid date and time.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string showType;
                if (btn2D.Checked) showType = "2D";
                else if (btn3D.Checked) showType = "3D";
                else showType = "IMAX";

                string language = listLanguage.Text;

                ShowTime existingShowTime = _showTimeService.GetShowTimeById(selectedShowTimeId);
                if (existingShowTime == null)
                {
                    MessageBox.Show("Movie not found!", "Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ShowTime updateShowTime = new ShowTime(selectedShowTimeId, movieId, hallID, startTime, endTime, 0, language);
                _showTimeService.UpdateShowTime(updateShowTime, showType);
                RefreshShowTimeTable();
                ClearForm();

                MessageBox.Show("Show Time Updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Please select a valid Show Time to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RefreshShowTimeTable()
        {

            this.showTimesTableAdapter.Fill(this.moviesDBDataSet1.ShowTimes);
            tableShowTime.DataSource = this.moviesDBDataSet1.ShowTimes;
        }

        private void ClearForm()
        {
            txtMovieId.Text = "";
            txtHallId.Text = "";
            txtStartTime.Text = "";
            txtEndTime.Text = "";
            btn2D.Checked = false;
            btn3D.Checked = false;
            btnMax.Checked = false;
            listLanguage.Text = "";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            this.Hide();
            adminForm.ShowDialog();
            this.Close();
        }
    }
}