using MovieCinema;
using MovieCinema.CinemaFacad;
using MovieCinema.Movies;
using MovieCinema.Repositories;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Ui
{
    public partial class MoviesForm : Form
    {
        
        private CinemaFacade _facade;
        private User _currentUser;
        private string connectionString;
        private IRepository<Movie> _movieRepository;
        private MovieService movieService;
        private System.Windows.Forms.TextBox txtSearch; 
        private System.Windows.Forms.PictureBox picLogo;
        private IEnumerable<Movie> movies;

        
        public MoviesForm(User user)
        {
            _currentUser = user;

            
            connectionString = "server=DESKTOP-V3MP8OJ\\SQL1919;database=MoviesDB;integrated security=True";

            
            var seatRepo = new SeatRepository(connectionString);
            var ticketRepo = new TicketRepository(connectionString);
            var showTimeRepo = new ShowTimeRepository(connectionString);
            _facade = new CinemaFacade(seatRepo, ticketRepo, showTimeRepo);

           
            _movieRepository = new MovieRepository(connectionString);
            movieService = new MovieService(_movieRepository);
            movies = movieService.GettAllMovies();

            InitializeComponent();
            CreateSearchBox();
            CreateProfilePic();
            DisplayMovies(movies);
        }

        
        private void CreateSearchBox()
        {
            txtSearch = new System.Windows.Forms.TextBox();
            txtSearch.Size = new Size(300, 30);
            txtSearch.Location = new Point(240, 20);
            txtSearch.BackColor = Color.FromArgb(40, 40, 50);
            txtSearch.ForeColor = Color.Gold;
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 11);

            txtSearch.TextChanged += txtSearch_TextChanged;
            this.Controls.Add(txtSearch);
            txtSearch.BringToFront();
        }

        private void DisplayMovies(IEnumerable<Movie> moviesList)
        {
            flowLayoutMovies.Controls.Clear();
            foreach (var movie in moviesList)
            {
                AddMovieCard(movie);
            }
        }

        private void AddMovieCard(Movie movie)
        {
            Panel card = new Panel { Size = new Size(220, 430), BackColor = Color.FromArgb(28, 28, 38), Margin = new Padding(15) };

            PictureBox pic = new PictureBox { Size = new Size(200, 280), Location = new Point(10, 10), SizeMode = PictureBoxSizeMode.StretchImage };
            try
            {
                string path = Path.Combine(Application.StartupPath, movie.PosterPath);
                if (File.Exists(path)) pic.Image = Image.FromFile(path);
            }
            catch { }

            Label lblTitle = new Label { Text = movie.Title, ForeColor = Color.White, Font = new Font("Segoe UI", 11, FontStyle.Bold), Location = new Point(10, 300), AutoSize = true };

            System.Windows.Forms.Button btn = new System.Windows.Forms.Button
            {
                Text = "Watch Now",
                Size = new Size(200, 35),
                Location = new Point(10, 380),
                BackColor = Color.FromArgb(142, 68, 173),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };

            
            btn.Click += (s, e) => {
                MovieDetailForm details = new MovieDetailForm(movie, this._facade, this._currentUser);
                details.ShowDialog();
            };

            card.Controls.Add(pic);
            card.Controls.Add(lblTitle);
            card.Controls.Add(btn);
            flowLayoutMovies.Controls.Add(card);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch == null) return;
            string query = txtSearch.Text.ToLower().Trim();

            var results = movies.Where(m => m.Title.ToLower().Contains(query)).ToList();
            DisplayMovies(results);
        }

        private void CreateProfilePic()
        {
            picLogo = new System.Windows.Forms.PictureBox();
            picLogo.Size = new Size(140, 70);
            picLogo.Location = new Point(740, 0);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;

            string path = Path.Combine(Application.StartupPath, "a.png");
            if (File.Exists(path)) picLogo.Image = Image.FromFile(path);

            this.Controls.Add(picLogo);
            picLogo.BringToFront();
        }
        private void flowLayoutMovies_Paint(object sender, PaintEventArgs e)
        {
           
        }
    }
}
