using MovieCinema.Genres;
using MovieCinema.Movies;
using MovieCinema.Repositories;
using System;
using System.Drawing;
using System.Windows.Forms;
using Ui.MovieGenres;
using Ui.Repositories;

namespace Ui
{
    public partial class ManageGenres : Form
    {
        private readonly string _connectionString;
        private readonly IRepository<GenreComponent> _genreRepository;
        private readonly GenreService _genreService;
        private readonly IRepository<MovieGenre> _movieGenreRepository;
        private readonly MovieGenreService _movieGenreService;

        public ManageGenres()
        {
            InitializeComponent();
            _connectionString = "server=DESKTOP-V3MP8OJ\\SQL1919;database=MoviesDB;integrated security=True";
            _genreRepository = new GenreRepository(_connectionString);
            _genreService = new GenreService(_genreRepository);
            _movieGenreRepository = new MovieGenreRepository(_connectionString);
            _movieGenreService = new MovieGenreService(_movieGenreRepository);
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
            this.Text = "Cinema Library - Manage Genres";

            // Apply styles to panels
            panel1.BackColor = Color.FromArgb(25, 25, 35);
            panel3.BackColor = Color.FromArgb(25, 25, 35);
            flowLayoutPanel1.BackColor = Color.FromArgb(25, 25, 35);
            flowLayoutPanel2.BackColor = Color.FromArgb(25, 25, 35);

            // Style title label
            label1.ForeColor = Color.FromArgb(255, 193, 7);
            label1.Font = new Font("Segoe UI", 18f, FontStyle.Bold);
            label1.Text = "MANAGE GENRES";

            // Style buttons
            StyleButton(button2, Color.FromArgb(40, 167, 69)); // Add - Green
            StyleButton(button1, Color.FromArgb(220, 53, 69)); // Delete - Red
            StyleButton(button3, Color.FromArgb(255, 193, 7)); // Update - Gold

            StyleButton(button4, Color.FromArgb(40, 167, 69)); // Add MovieGenre - Green
            StyleButton(button5, Color.FromArgb(220, 53, 69)); // Delete MovieGenre - Red
            StyleButton(button6, Color.FromArgb(255, 193, 7)); // Update MovieGenre - Gold

            // Style Back button
            btnBack.ForeColor = Color.White;
            btnBack.BackColor = Color.FromArgb(15, 15, 20);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
            btnBack.Cursor = Cursors.Hand;

            // Style labels in panel1 and panel3
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

            foreach (Control control in panel3.Controls)
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

            // Style DataGridViews
            StyleDataGridView(genreTable);
            StyleDataGridView(movieGenresTable);
        }

        private void StyleButton(Button button, Color backgroundColor)
        {
            button.BackColor = backgroundColor;
            button.ForeColor = Color.White;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
            button.Cursor = Cursors.Hand;
            button.Padding = new Padding(5, 5, 5, 5);

            // Hover effect
            button.MouseEnter += (s, e) => button.BackColor = Color.FromArgb(
                Math.Max(backgroundColor.R - 20, 0),
                Math.Max(backgroundColor.G - 20, 0),
                Math.Max(backgroundColor.B - 20, 0));
            button.MouseLeave += (s, e) => button.BackColor = backgroundColor;
        }

        private void StyleDataGridView(DataGridView dgv)
        {
            if (dgv != null)
            {
                dgv.BackgroundColor = Color.FromArgb(25, 25, 35);
                dgv.GridColor = Color.FromArgb(60, 60, 70);
                dgv.BorderStyle = BorderStyle.FixedSingle;
                dgv.EnableHeadersVisualStyles = false;
                dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 50);
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
                dgv.DefaultCellStyle.BackColor = Color.FromArgb(35, 35, 45);
                dgv.DefaultCellStyle.ForeColor = Color.White;
                dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9.5f);
                dgv.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 50);
                dgv.RowHeadersDefaultCellStyle.ForeColor = Color.White;
                dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(30, 30, 40);
                dgv.ColumnHeadersHeight = 35;
            }
        }

        private void ManageGenres_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'moviesDBDataSet4.MovieGenres' table. You can move, or remove it, as needed.
            this.movieGenresTableAdapter.Fill(this.moviesDBDataSet4.MovieGenres);
            // TODO: This line of code loads data into the 'moviesDBDataSet3.Genres' table. You can move, or remove it, as needed.
            this.genresTableAdapter.Fill(this.moviesDBDataSet3.Genres);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int? parentId = 0;

            string genreName = txtGenreName.Text;
            //validate parent id
            if (txtParentId.Text.Length == 0)
            {
                MessageBox.Show("Are you sure you want to add a genre without a Parent Id?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                parentId = null;
            }
            else
            {
                if (!int.TryParse(txtParentId.Text, out int parsedParentId))
                {
                    MessageBox.Show("Parent ID must be a valid integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                parentId = parsedParentId;
            }

            GenreComponent newGenre = new Genre(0, genreName, parentId);
            _genreService.Add(newGenre);
            MessageBox.Show("Genre added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            RefreshGenreTable();
            ClearGenreForm();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (genreTable.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Are you sure you want to delete this genre?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    int selectedGenreID = Convert.ToInt32(genreTable.SelectedRows[0].Cells["GenreId"].Value);
                    _genreRepository.Delete(selectedGenreID);

                    // Refresh
                    RefreshGenreTable();

                    ClearGenreForm();

                    MessageBox.Show("Genre deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a Genre to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (genreTable.SelectedRows.Count > 0 && genreTable.SelectedRows[0].Cells["GenreId"].Value != null)
            {
                int sekectedGenreId = Convert.ToInt32(genreTable.SelectedRows[0].Cells["GenreId"].Value);

                int? parentId;
                //validate parent id
                if (txtParentId.Text.Length == 0)
                {
                    MessageBox.Show("Are you sure you want to add a genre without a Parent Id?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    parentId = null;
                }
                else
                {
                    if (!int.TryParse(txtParentId.Text, out int parsedParentId))
                    {
                        MessageBox.Show("Parent ID must be a valid integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    parentId = parsedParentId;
                }

                GenreComponent newGenre = new Genre(sekectedGenreId, txtGenreName.Text, parentId);
                _genreService.UpdateGenre(newGenre);


                // Refresh 
                RefreshGenreTable();

                MessageBox.Show("Movie updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearGenreForm();
            }
        }
        private void RefreshGenreTable()
        {
            this.genresTableAdapter.Fill(this.moviesDBDataSet3.Genres);
            genreTable.DataSource = this.moviesDBDataSet3.Genres;
        }
        private void ClearGenreForm()
        {
            txtGenreName.Text = "";
            txtParentId.Text = "";
        }

        private void genreTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // Ensure the click is not on the header row or an invalid row
            if (e.RowIndex >= 0 && e.RowIndex < genreTable.Rows.Count)
            {
                DataGridViewRow row = genreTable.Rows[e.RowIndex];

                if (row.Cells["GenreId"].Value != null)
                {
                    txtGenreName.Text = row.Cells["GenreName"].Value?.ToString() ?? "";
                    txtParentId.Text = row.Cells["ParentId"].Value?.ToString() ?? "";

                }

            }
        }
        ///////////////Movie Genre////////////////
        /// Add MovieGenre

        private void button4_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMovieId.Text, out int movieId))
            {
                MessageBox.Show("Please enter a valid Movie ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(txtGenreId.Text, out int genreId))
            {
                MessageBox.Show("Please Enter a valid Genre ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MovieGenre movieGenre = new MovieGenre(0, movieId, genreId);
            _movieGenreService.Add(movieGenre);
            MessageBox.Show("MovieGenre added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshMovieGenreTable();
            ClearMovieGenreForm();

        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (movieGenresTable.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Are you sure you want to delete this MovieGenre?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    int selectedMovieGenreId = Convert.ToInt32(movieGenresTable.SelectedRows[0].Cells["MovieGenreId"].Value);
                    _movieGenreRepository.Delete(selectedMovieGenreId);

                    // Refresh
                    RefreshMovieGenreTable();

                    ClearMovieGenreForm();

                    MessageBox.Show("MovieGenre deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a MovieGenre to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (movieGenresTable.SelectedRows.Count > 0 && movieGenresTable.SelectedRows[0].Cells["MovieGenreId"].Value != null)
            {
                int selectMovieGenreId = Convert.ToInt32(movieGenresTable.SelectedRows[0].Cells["MovieGenreId"].Value);

                if (!int.TryParse(txtMovieId.Text, out int movieId))
                {
                    MessageBox.Show("Movie ID must be a valid integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(txtGenreId.Text, out int genreId))
                {
                    MessageBox.Show("Genre ID must be a valid integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MovieGenre newMovieGenre = new MovieGenre(selectMovieGenreId, movieId, genreId);
                _movieGenreRepository.Update(newMovieGenre);

                // Refresh 
                RefreshMovieGenreTable();
                MessageBox.Show("MovieGenre updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearMovieGenreForm();
            }
        }
        private void RefreshMovieGenreTable()
        {
            this.movieGenresTableAdapter.Fill(this.moviesDBDataSet4.MovieGenres);
            movieGenresTable.DataSource = this.moviesDBDataSet4.MovieGenres;


        }

        private void getMovieGenreTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // Ensure the click is not on the header row or an invalid row
            if (e.RowIndex >= 0 && e.RowIndex < movieGenresTable.Rows.Count)
            {
                DataGridViewRow row = movieGenresTable.Rows[e.RowIndex];

                if (row.Cells["MovieGenreId"].Value != null)
                {
                    txtMovieId.Text = row.Cells["MovieIdFk"].Value?.ToString() ?? "";
                    txtGenreId.Text = row.Cells["GenreIDFk"].Value?.ToString() ?? "";

                }

            }
        }
        private void ClearMovieGenreForm()
        {
            txtMovieId.Text = "";
            txtGenreId.Text = "";
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void genreTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            this.Hide();
            adminForm.ShowDialog();
            this.Close();
        }
    }
}