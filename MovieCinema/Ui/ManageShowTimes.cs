using MovieCinema.Movies;
using MovieCinema.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MovieCinema.ShowTimes;
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
            RefreshShowTimeTable();
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

            _showTimeService.AddShowTime(_showTime,showType);
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

                ShowTime updateShowTime = new ShowTime(selectedShowTimeId,movieId,hallID, startTime,endTime, 0, language);
                _showTimeService.UpdateShowTime(updateShowTime,showType);
                RefreshShowTimeTable();
                ClearForm();

                MessageBox.Show("Show Time Updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Please select a valid Show Time to update.", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
