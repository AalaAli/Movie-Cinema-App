using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Ui;
using MovieCinema.CinemaFacad;
using MovieCinema.Users;
using MovieCinema;
using MovieCinema.Movies;

public partial class MovieDetailForm : Form
{
    private Movie _movie;
    private CinemaFacade _facade;
    private User _currentUser;
    private bool isBooked = false; 

    
    public MovieDetailForm(Movie movie, CinemaFacade facade, User user)
    {
        _movie = movie;
        _facade = facade;
        _currentUser = user;

        this.Size = new Size(600, 500);
        this.BackColor = Color.FromArgb(15, 15, 15);
        this.StartPosition = FormStartPosition.CenterParent;
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.Text = "Movie Details - " + movie.Title;

        InitializeDetailLayout();
    }

    private void InitializeDetailLayout()
    {
       
        Label lblTitle = new Label
        {
            Text = _movie.Title.ToUpper(),
            ForeColor = Color.Gold,
            Font = new Font("Segoe UI", 22, FontStyle.Bold),
            Location = new Point(20, 20),
            AutoSize = true
        };

        PictureBox picPoster = new PictureBox
        {
            Size = new Size(200, 280),
            Location = new Point(360, 70),
            SizeMode = PictureBoxSizeMode.Zoom,
            BackColor = Color.Transparent
        };

        string imagePath = Path.Combine(Application.StartupPath, _movie.PosterPath);
        if (File.Exists(imagePath)) picPoster.Image = Image.FromFile(imagePath);

        Label lblDescription = new Label
        {
            Text = _movie.Description,
            ForeColor = Color.White,
            Font = new Font("Segoe UI", 11),
            Location = new Point(25, 105),
            Size = new Size(320, 150)
        };

       
        Button btnBook = new Button
        {
            Text = "BOOK TICKET",
            Size = new Size(160, 45),
            Location = new Point(25, 380),
            BackColor = Color.Gold,
            FlatStyle = FlatStyle.Flat,
            Font = new Font("Segoe UI", 10, FontStyle.Bold)
        };

        Button btnDownload = new Button
        {
            Text = "DOWNLOAD",
            Size = new Size(160, 45),
            Location = new Point(200, 380),
            BackColor = Color.FromArgb(40, 40, 40),
            ForeColor = Color.White,
            FlatStyle = FlatStyle.Flat,
            Font = new Font("Segoe UI", 10, FontStyle.Bold)
        };

        
        btnBook.Click += (s, e) => {
            if (!isBooked)
            {
                try
                {
                    _facade.BookTicket(1, _currentUser.GetUserId()); // استدعاء دالتك الأصلية
                    isBooked = true;
                    btnBook.Text = "CANCEL BOOKING";
                    btnBook.BackColor = Color.Crimson;
                    btnBook.ForeColor = Color.White;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                _facade.CancelBookingByTitle(_currentUser.GetUserId(), _movie.Title);
                isBooked = false;
                btnBook.Text = "BOOK TICKET";
                btnBook.BackColor = Color.Gold;
                btnBook.ForeColor = Color.Black;
            }
        };

       
        btnDownload.Click += (s, e) => {
            _facade.DownloadMovie(_currentUser.GetUserId(), _movie.Title);
        };

        // إضافة العناصر للفورم
        this.Controls.Add(lblTitle);
        this.Controls.Add(picPoster);
        this.Controls.Add(lblDescription);
        this.Controls.Add(btnBook);
        this.Controls.Add(btnDownload);

        // إضافة النجوم وبقية العناصر التي كانت موجودة...
        AddStarsToLayout();
    }

    private void AddStarsToLayout()
    {
        // ضعي كود توليد النجوم (starPanel) هنا كما كان في كودك السابق
    }

    private void Star_Click(object sender, EventArgs e)
    {
        Button clickedStar = (Button)sender;
        int rating = (int)clickedStar.Tag;
        foreach (Button star in clickedStar.Parent.Controls)
        {
            star.Text = (int)star.Tag <= rating ? "★" : "☆";
        }
        MessageBox.Show($"Thank you for rating {_movie.Title}!");
    }

    private void InitializeComponent()
    {
            this.SuspendLayout();
            // 
            // MovieDetailForm
            // 
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Name = "MovieDetailForm";
            this.Load += new System.EventHandler(this.MovieDetailForm_Load);
            this.ResumeLayout(false);

    }

    private void MovieDetailForm_Load(object sender, EventArgs e)
    {

    }
}