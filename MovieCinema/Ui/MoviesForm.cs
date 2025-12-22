using MovieCinema;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MovieCinema.Movies;
using MovieCinema.Repositories;
using MovieCinema.Genres;
namespace Ui
{
    public partial class MoviesForm : Form
    {
        private Movie _movie;


         string connectionString;
         IRepository<Movie> _movieRepository;
        MovieService movieService;
        System.Windows.Forms.TextBox txtSearch;
        System.Windows.Forms.PictureBox picLogo;
        IEnumerable<Movie> movies;

        public MoviesForm()
        {
            connectionString = "server=DESKTOP-V3MP8OJ\\SQL1919;database=MoviesDB;integrated security=True";
            _movieRepository = new MovieRepository(connectionString);
            movieService = new MovieService(_movieRepository);

            movies = movieService.GettAllMovies();

            InitializeComponent();

            CreateSearchBox(); 

            CreateProfilePic();

            LoadGenreMovies(movies);

            DisplayMovies(movies);

            

        }
        private void LoadGenreMovies(IEnumerable<Movie>movies)
        {
            IEnumerable<GenreComponent> genres=new List<GenreComponent>();
            foreach (Movie movie in movies)
            {
                genres= movieService.GetGenresByMovieId(movie.GetMovieId());
                movie.AddGenres(genres);
            }
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

            PictureBox pic = new PictureBox { Size = new Size(200, 280), Location = new Point(10, 10), SizeMode = PictureBoxSizeMode.StretchImage, BackColor = Color.FromArgb(45, 45, 55) };
            try
            {
                string path = Path.Combine(Application.StartupPath, movie.PosterPath);
                if (File.Exists(path)) pic.Image = Image.FromFile(path);
            }
            catch { }

            Label lblTitle = new Label { Text = movie.Title, ForeColor = Color.White, Font = new Font("Segoe UI", 11, FontStyle.Bold), Location = new Point(10, 300), AutoSize = true };
           string genreString="";
            foreach (Movie m in movies)
            {
                genreString = "";
                if (m.GetGenres() != null)
                {
                    foreach (var genre in m.GetGenres())
                    { 
                        genreString += genre.GetGenreName() + ", ";
                    }
                    Label lblGenres = new Label { Text = genreString, ForeColor = Color.White, Font = new Font("Segoe UI", 11, FontStyle.Bold), Location = new Point(10, 310), AutoSize = true };
                }
            }

            int fullStars = (int)Math.Round(movie.Rating / 2);

            
            int emptyStars = 5 - fullStars;

            
            string starsText = new string('★', fullStars) + new string('☆', emptyStars);

            
            Label lblStars = new Label
            {
                Text = $"({movie.Rating}) " + starsText,
                ForeColor = Color.Gold,
                Location = new Point(10, 335),
                AutoSize = true
            };

           
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
                MovieDetailForm detailForm = new MovieDetailForm(movie);
                detailForm.ShowDialog();
            }; 
               
            btn.FlatAppearance.BorderSize = 0;

            card.Controls.Add(pic);
            card.Controls.Add(lblTitle);
            card.Controls.Add(lblStars);
            card.Controls.Add(btn);
            flowLayoutMovies.Controls.Add(card);
        }

       
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
          
            System.Windows.Forms.TextBox searchBox = sender as System.Windows.Forms.TextBox;

            if (searchBox == null) return;

            string query = searchBox.Text.ToLower().Trim();

            
            var results = movies.Where(m =>m.Title.ToLower().StartsWith(query) ||
                m.Actors.Any(a => a.ActorName.ToLower().StartsWith(query)) ||
                m.Genres.Any(g => g.GetGenreName().ToLower().StartsWith(query))
            ).ToList();

            DisplayMovies(results);
        }
        
        

           
        private void LoadProfileImage()
        {
            try
            {
                string path = System.IO.Path.Combine(Application.StartupPath, "a.png");
                if (System.IO.File.Exists(path))
                {
                   
                    var profilePic = this.Controls.OfType<System.Windows.Forms.PictureBox>().FirstOrDefault();

                    if (profilePic != null)
                    {
                        profilePic.Image = Image.FromFile(path);
                        profilePic.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
            }
            catch { }
        }
        private void CreateProfilePic()
        {
            picLogo = new System.Windows.Forms.PictureBox();
            picLogo.Size = new Size(140, 70);
            picLogo.Location = new Point(760, -5);

            
            picLogo.BackColor = Color.FromArgb(28, 28, 38);
            picLogo.Location = new Point(740, 0);
            

            picLogo.SizeMode = PictureBoxSizeMode.Zoom;

            string path = Path.Combine(Application.StartupPath, "a.png");
            if (File.Exists(path))
            {
                picLogo.Image = Image.FromFile(path);
            }

            this.Controls.Add(picLogo);
            picLogo.BringToFront();
        }
   
        


 

        



       

    }
}