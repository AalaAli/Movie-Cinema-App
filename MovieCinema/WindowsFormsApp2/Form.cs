using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Ui;

public partial class MovieDetailForm : Form
{
    
    private Movie _movie;
    private CinemaFacade _facade;
    private User _currentUser;
    private UserObserver _userObserver;
    public MovieDetailForm(Movie movie, CinemaFacade facade, User user)
    {
        _movie = movie;
        this.Size = new Size(600, 500);
        this.BackColor = Color.FromArgb(15, 15, 15); // نفس لون الواجهة
        this.StartPosition = FormStartPosition.CenterParent;
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.Text = "Movie Details - " + movie.Title;
        _movie = movie;
        _facade = facade;
        _currentUser = user;

        InitializeDetailLayout();
    }

    private void InitializeDetailLayout()
    {
        // 1. عنوان الفيلم (بالأعلى)
        Label lblTitle = new Label
        {
            Text = _movie.Title.ToUpper(),
            ForeColor = Color.Gold,
            Font = new Font("Segoe UI", 22, FontStyle.Bold),
            Location = new Point(20, 20),
            AutoSize = true
        };

        // 2. إضافة صورة البوستر على الجانب الأيمن
        PictureBox picPoster = new PictureBox
        {
            Size = new Size(200, 280), // حجم البوستر
            Location = new Point(360, 70), // موقعه في أقصى اليمين
            SizeMode = PictureBoxSizeMode.Zoom,
            BorderStyle = BorderStyle.None,
            BackColor = Color.Transparent
        };

        // محاولة تحميل الصورة من مسارها
        string imagePath = Path.Combine(Application.StartupPath, _movie.PosterPath);
        if (File.Exists(imagePath))
            picPoster.Image = Image.FromFile(imagePath);

        // 3. نبذة عن القصة (على الجانب الأيسر)
        Label lblDescTitle = new Label
        {
            Text = "STORYLINE",
            ForeColor = Color.Gray,
            Location = new Point(25, 80),
            Font = new Font("Segoe UI", 10, FontStyle.Bold)
        };

        Label lblDescription = new Label
        {
            Text = _movie.Description,
            ForeColor = Color.White,
            Font = new Font("Segoe UI", 11),
            Location = new Point(25, 105),
            Size = new Size(320, 150), // تقليل العرض لترك مساحة للصورة على اليمين
            TextAlign = ContentAlignment.TopLeft
        };

        // 4. التقييم بالنجوم (تحت النص التعريفي)
        Label lblRatingHeader = new Label
        {
            Text = "RATE THIS MOVIE",
            ForeColor = Color.Gray,
            Location = new Point(25, 260),
            Font = new Font("Segoe UI", 10, FontStyle.Bold)
        };

        Panel starPanel = new Panel { Location = new Point(25, 285), Size = new Size(300, 50) };

        for (int i = 1; i <= 5; i++)
        {
            Button star = new Button
            {
                Text = "☆",
                Tag = i,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(40, 40),
                Location = new Point((i - 1) * 45, 0),
                ForeColor = Color.Gold,
                Font = new Font("Segoe UI", 16)
            };
            star.FlatAppearance.BorderSize = 0;
            star.Click += Star_Click;
            starPanel.Controls.Add(star);
        }

        // 5. أزرار الأكشن (بالأسفل)
        Button btnBook = new Button
        {
            Text = "BOOK TICKET",
            Size = new Size(160, 45),
            Location = new Point(25, 380),
            BackColor = Color.Gold,
            ForeColor = Color.Black,
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
            _facade.BookTicket(_currentUser.GetUserId(), _movie.Title);
        };

        // عند الضغط على زر التنزيل
        btnDownload.Click += (s, e) => {
            _facade.DownloadMovie(_currentUser.GetUserId(), _movie.Title);
        };

        // إضافة العناصر للفورم (ترتيب الإضافة مهم للطبقات)
        this.Controls.Add(lblTitle);
        this.Controls.Add(picPoster); // إضافة الصورة
        this.Controls.Add(lblDescTitle);
        this.Controls.Add(lblDescription);
        this.Controls.Add(lblRatingHeader);
        this.Controls.Add(starPanel);
        this.Controls.Add(btnBook);
        this.Controls.Add(btnDownload);
    }
    private void Star_Click(object sender, EventArgs e)
    {
        Button clickedStar = (Button)sender;
        int rating = (int)clickedStar.Tag;

        // تغيير شكل النجوم لتصبح ممتلئة عند الاختيار
        foreach (Button star in clickedStar.Parent.Controls)
        {
            star.Text = (int)star.Tag <= rating ? "★" : "☆";
        }
        MessageBox.Show($"Thank you! You gave {_movie.Title} a {rating * 2}/10 rating.");
    }

    
    private void MovieDetailForm_Load(object sender, EventArgs e)
    {

    }

    
    

    private void MovieDetailForm_Load_1(object sender, EventArgs e)
    {

    }

    

    private void MovieDetailForm_Load_2(object sender, EventArgs e)
    {

    }

    

    private void MovieDetailForm_Load_3(object sender, EventArgs e)
    {

    }

    
    private void MovieDetailForm_Load_4(object sender, EventArgs e)
    {

    }

    

    private void MovieDetailForm_Load_5(object sender, EventArgs e)
    {

    }

    

    private void MovieDetailForm_Load_6(object sender, EventArgs e)
    {

    }

   

    private void MovieDetailForm_Load_7(object sender, EventArgs e)
    {

    }

    

    private void MovieDetailForm_Load_8(object sender, EventArgs e)
    {

    }

    

    private void MovieDetailForm_Load_9(object sender, EventArgs e)
    {

    }
}