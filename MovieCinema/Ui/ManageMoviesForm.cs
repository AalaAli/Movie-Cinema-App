using MovieCinema.Movies;
using MovieCinema.Repositories;
using MovieCinema;
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
    public partial class ManageMoviesForm : Form
    {
        private readonly string _connectionString;
        private readonly IRepository<Movie> _movieRepository;
        private readonly MovieService _movieService;

        public ManageMoviesForm()
        {
            InitializeComponent();

            // Initialize connection and service once in constructor
            _connectionString = "server=DESKTOP-V3MP8OJ\\SQL1919;database=MoviesDB;integrated security=True";
            _movieRepository = new MovieRepository(_connectionString);
            _movieService = new MovieService(_movieRepository);

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
            this.Text = "Cinema Library - Manage Movies";


            // Style title label
            label1.ForeColor = Color.FromArgb(255, 193, 7);
            label1.Font = new Font("Segoe UI", 18f, FontStyle.Bold);
            label1.Text = "MANAGE MOVIES";

            // Apply styles to all controls
            ApplyControlThemes();

            // Custom styling for panels
            panel1.BackColor = Color.FromArgb(25, 25, 35);
            panel2.BackColor = Color.FromArgb(25, 25, 35);

            // Style buttons
            StyleButton(btnAdd, Color.FromArgb(40, 167, 69));
            StyleButton(btnUpdate, Color.FromArgb(255, 193, 7));
            StyleButton(btnDelete, Color.FromArgb(220, 53, 69));
            StyleButton(btnClone, Color.FromArgb(128, 128, 128));
            StyleButton(btnBack, Color.FromArgb(15, 15, 20));


            // Style labels
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
            }

            // Style DataGridView
            if (tableMovie != null)
            {
                tableMovie.BackgroundColor = Color.FromArgb(25, 25, 35);
                tableMovie.GridColor = Color.FromArgb(60, 60, 70);
                tableMovie.BorderStyle = BorderStyle.FixedSingle;
                tableMovie.EnableHeadersVisualStyles = false;
                tableMovie.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 50);
                tableMovie.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                tableMovie.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
                tableMovie.DefaultCellStyle.BackColor = Color.FromArgb(35, 35, 45);
                tableMovie.DefaultCellStyle.ForeColor = Color.White;
                tableMovie.DefaultCellStyle.Font = new Font("Segoe UI", 9.5f);
                tableMovie.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 50);
                tableMovie.RowHeadersDefaultCellStyle.ForeColor = Color.White;
                tableMovie.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(30, 30, 40);
            }
        }

        private void ApplyControlThemes()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Panel panel)
                {
                    panel.BackColor = Color.FromArgb(25, 25, 35);
                }
            }
        }

        private void StyleButton(Button button, Color backgroundColor)
        {
            button.BackColor = backgroundColor;
            button.ForeColor = Color.White;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
            button.Cursor = Cursors.Hand;
            button.Padding = new Padding(5, 5, 5, 5);
            button.Size = new Size(80,30);

            // Store original color
            var originalColor = backgroundColor;
            var hoverColor = Color.FromArgb(
                Math.Max(backgroundColor.R - 20, 0),
                Math.Max(backgroundColor.G - 20, 0),
                Math.Max(backgroundColor.B - 20, 0)
            );

            button.MouseEnter += (s, e) => button.BackColor = hoverColor;
            button.MouseLeave += (s, e) => button.BackColor = originalColor;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string description = txtDescription.Text;

            // Convert releaseYear and duration to integers as required by the Movie constructor
            if (!int.TryParse(txtReleaseYear.Text, out int releaseYear))
            {
                MessageBox.Show("Invalid release year. Please enter a valid number.", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtDuration.Text, out int duration))
            {
                MessageBox.Show("Invalid duration. Please enter a valid number.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string posterPath = txtPosterPath.Text;
            // Remove the substring operation if it's causing issues, or fix it
            if (!string.IsNullOrEmpty(posterPath) && posterPath.Contains('\\'))
            {
                posterPath = posterPath.Substring(posterPath.LastIndexOf('\\') + 1);
            }


            Movie movie = new Movie(0, title, description, releaseYear, duration, posterPath, 0);
            _movieService.Add(movie);

            ClearForm();

            // Refresh
            RefreshMovieTable();

            MessageBox.Show("Movie added successfully!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ManageMoviesForm_Load(object sender, EventArgs e)
        {
            RefreshMovieTable();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tableMovie.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Are you sure you want to delete this movie?", "Confirm Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    int selectedMovieId = Convert.ToInt32(tableMovie.SelectedRows[0].Cells["MovieId"].Value);
                    _movieService.Delete(selectedMovieId);

                    // Refresh
                    RefreshMovieTable();

                    ClearForm();

                    MessageBox.Show("Movie deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a movie to delete.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tableMovie.SelectedRows.Count > 0 && tableMovie.SelectedRows[0].Cells["MovieId"].Value != null)
            {
                int selectedMovieId = Convert.ToInt32(tableMovie.SelectedRows[0].Cells["MovieId"].Value);

                // Validate inputs
                if (!int.TryParse(txtReleaseYear.Text, out int releaseYear))
                {
                    MessageBox.Show("Invalid release year. Please enter a valid number.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(txtDuration.Text, out int duration))
                {
                    MessageBox.Show("Invalid duration. Please enter a valid number.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Movie existingMovie = _movieService.GetMovieById(selectedMovieId);
                if (existingMovie == null)
                {
                    MessageBox.Show("Movie not found!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Movie updatedMovie = new Movie(selectedMovieId, txtTitle.Text,txtDescription.Text,releaseYear,duration,txtPosterPath.Text, existingMovie.GetRating());

                _movieService.Update(updatedMovie);

                // Refresh 
                RefreshMovieTable();

                MessageBox.Show("Movie updated successfully!", "Success",MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            else
            {
                MessageBox.Show("Please select a valid movie to update.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void tableMovie_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the click is not on the header row or an invalid row
            if (e.RowIndex >= 0 && e.RowIndex < tableMovie.Rows.Count)
            {
                DataGridViewRow row = tableMovie.Rows[e.RowIndex];

                if (row.Cells["MovieId"].Value != null)
                {
                    txtTitle.Text = row.Cells["Title"].Value?.ToString() ?? "";
                    txtDescription.Text = row.Cells["Description"].Value?.ToString() ?? "";
                    txtReleaseYear.Text = row.Cells["ReleaseYear"].Value?.ToString() ?? "";
                    txtDuration.Text = row.Cells["Duration"].Value?.ToString() ?? "";
                    txtPosterPath.Text = row.Cells["PosterPath"].Value?.ToString() ?? "";
                }
            }
        }
        private void btnClone_Click(object sender, EventArgs e)
        {
            if (tableMovie.SelectedRows.Count > 0)
            {
                int selectedMovieId = Convert.ToInt32(tableMovie.SelectedRows[0].Cells["MovieId"].Value);
                if (selectedMovieId.ToString()!= null)
                {
                    Movie movie = _movieService.CloneMovie(selectedMovieId);
                    _movieService.Add(movie);
                }
                // Refresh
                RefreshMovieTable();

                ClearForm();
                MessageBox.Show("Movie cloned successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Please select a movie to clone.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void RefreshMovieTable()
        {
           
            this.moviesTableAdapter.Fill(this.moviesDBDataSet.Movies);
           tableMovie.DataSource = this.moviesDBDataSet.Movies;

        }

        private void ClearForm()
        {
            txtTitle.Text = "";
            txtDescription.Text = "";
            txtReleaseYear.Text = "";
            txtDuration.Text = "";
            txtPosterPath.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

  
        private void btnBack_Click_1(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            this.Hide();
            adminForm.ShowDialog();
            this.Close();
        }


    }
}