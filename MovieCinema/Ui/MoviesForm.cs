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
            LoadMockData();
            DisplayMovies(movies);
            

        }

        private void LoadMockData()
        {
            
            

     /*       var m1 = new Movie(1, "Inception", "A skilled thief is offered a chance to have his criminal record erased as payment for the implantation of another person's idea into their subconscious. He must lead a team into a dangerous multi-level dream world to succeed.", 2010, "A2.jpg", 9.2m);
            m1.Actors.AddRange(new[] { "Leonardo DiCaprio", "Tom Hardy" });
            m1.Genres.Add("Sci-Fi");

            var m2 = new Movie(2, "Joker", "\"In Gotham City, mentally troubled comedian Arthur Fleck is disregarded and mistreated by society. He then embarks on a downward spiral of revolution and bloody crime. This path brings him face-to-face with his alter-ego.\",", 2019, "A3.jpg", 8.8m);
            m2.Actors.Add("Joaquin Phoenix");
            m2.Genres.Add("Drama");
            var m3 = new Movie(3, "Interstellar", "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice and save the city from ruin.\"", 2014, "A4.jpg", 8.7m);
            m3.Actors.Add("Matthew McConaughey");
            var m4 = new Movie(5, "The Shawshank Redemption", "\"A prominent banker is sentenced to life in prison for a crime he didn't commit. Over two decades, he forms an unlikely friendship with a fellow inmate and uses his financial skills to gain protection, all while secretly planning an ingenious escape to find his freedom and redemption.\"", 1994, "A5.jpg", 9.3m);
            m4.Actors.AddRange(new[] { "Morgan Freeman", "Tim Robbins" });
            m4.Genres.Add("Drama");
            m3.Genres.AddRange(new[] { "Sci-Fi", "Drama" });
            var m5 = new Movie(6, "Signs", "A former priest living on a remote farm discovers mysterious and massive crop circles carved into his fields. As strange events escalate across the globe, he must protect his family from a terrifying alien invasion while struggling to regain his lost faith in a world under siege.\"", 2002, "A6.jpg", 6.8m);
            m5.Actors.AddRange(new[] { "Mel Gibson", "Joaquin Phoenix" }); 
            m5.Genres.Add("Horror"); 
            m5.Genres.Add("Mystery");
            var m6 = new Movie(9, "The Revenant", "While exploring the uncharted wilderness in the 1820s, a legendary frontiersman is brutally attacked by a bear and left for dead by his own hunting team. Driven by sheer willpower and the love of his family, he must survive freezing temperatures and hostile tribes to find the man who betrayed him.", 2015, "a7.jpg", 8.0m);
            m6.Actors.AddRange(new[] { "Leonardo DiCaprio", "Tom Hardy" }); 
            m6.Genres.Add("Adventure");
            m6.Genres.Add("Drama");

            _allMovies.Add(m6);
            _allMovies.Clear();
            _allMovies.AddRange(new[] { m1, m2,m4,m3,m5,m6 });*/
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
                m.Actors.Any(a => a.ActorName.ToLower().Contains(query)) ||
                m.Genres.Any(g => g.GetGenreName().ToLower().Contains(query))
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