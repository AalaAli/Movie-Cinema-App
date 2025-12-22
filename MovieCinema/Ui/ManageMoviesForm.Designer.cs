namespace Ui
{
    partial class ManageMoviesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtTitle = new System.Windows.Forms.RichTextBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.txtReleaseYear = new System.Windows.Forms.RichTextBox();
            this.txtPosterPath = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClone = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RatingLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.DurationLabel = new System.Windows.Forms.Label();
            this.ReleaseYearLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TitleTxt = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MoviePoster = new System.Windows.Forms.PictureBox();
            this.tableMovie = new System.Windows.Forms.DataGridView();
            this.MovieId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReleaseYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PosterPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moviesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moviesDBDataSet = new Ui.MoviesDBDataSet();
            this.moviesTableAdapter = new Ui.MoviesDBDataSetTableAdapters.MoviesTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePoster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableMovie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(39, 46);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(323, 42);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.Text = "";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(39, 324);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(323, 80);
            this.txtDescription.TabIndex = 2;
            this.txtDescription.Text = "";
            // 
            // txtReleaseYear
            // 
            this.txtReleaseYear.Location = new System.Drawing.Point(39, 109);
            this.txtReleaseYear.Name = "txtReleaseYear";
            this.txtReleaseYear.Size = new System.Drawing.Size(323, 42);
            this.txtReleaseYear.TabIndex = 3;
            this.txtReleaseYear.Text = "";
            // 
            // txtPosterPath
            // 
            this.txtPosterPath.Location = new System.Drawing.Point(39, 178);
            this.txtPosterPath.Name = "txtPosterPath";
            this.txtPosterPath.Size = new System.Drawing.Size(323, 42);
            this.txtPosterPath.TabIndex = 4;
            this.txtPosterPath.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClone);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtDuration);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtPosterPath);
            this.panel1.Controls.Add(this.txtReleaseYear);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.txtTitle);
            this.panel1.Location = new System.Drawing.Point(21, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 538);
            this.panel1.TabIndex = 1;
            // 
            // btnClone
            // 
            this.btnClone.Location = new System.Drawing.Point(39, 480);
            this.btnClone.Name = "btnClone";
            this.btnClone.Size = new System.Drawing.Size(110, 40);
            this.btnClone.TabIndex = 13;
            this.btnClone.Text = "Clone";
            this.btnClone.UseVisualStyleBackColor = true;
            this.btnClone.Click += new System.EventHandler(this.btnClone_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Duration (mins)";
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(39, 257);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(323, 42);
            this.txtDuration.TabIndex = 11;
            this.txtDuration.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Poster Path";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Release Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "title";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(252, 420);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(110, 40);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(252, 480);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 40);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(39, 420);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 40);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.RatingLabel);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.DescriptionLabel);
            this.panel2.Controls.Add(this.DurationLabel);
            this.panel2.Controls.Add(this.ReleaseYearLabel);
            this.panel2.Controls.Add(this.TitleLabel);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.TitleTxt);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.MoviePoster);
            this.panel2.Controls.Add(this.tableMovie);
            this.panel2.Location = new System.Drawing.Point(453, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(715, 538);
            this.panel2.TabIndex = 5;
            // 
            // RatingLabel
            // 
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Location = new System.Drawing.Point(217, 454);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(32, 17);
            this.RatingLabel.TabIndex = 16;
            this.RatingLabel.Text = "      ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(168, 454);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 17);
            this.label12.TabIndex = 15;
            this.label12.Text = "Rating:";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(255, 492);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(24, 17);
            this.DescriptionLabel.TabIndex = 14;
            this.DescriptionLabel.Text = "    ";
            // 
            // DurationLabel
            // 
            this.DurationLabel.AutoSize = true;
            this.DurationLabel.Location = new System.Drawing.Point(230, 420);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(32, 17);
            this.DurationLabel.TabIndex = 13;
            this.DurationLabel.Text = "      ";
            // 
            // ReleaseYearLabel
            // 
            this.ReleaseYearLabel.AutoSize = true;
            this.ReleaseYearLabel.Location = new System.Drawing.Point(255, 387);
            this.ReleaseYearLabel.Name = "ReleaseYearLabel";
            this.ReleaseYearLabel.Size = new System.Drawing.Size(28, 17);
            this.ReleaseYearLabel.TabIndex = 12;
            this.ReleaseYearLabel.Text = "     ";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(200, 354);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(24, 17);
            this.TitleLabel.TabIndex = 11;
            this.TitleLabel.Text = "    ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(273, 387);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 17);
            this.label11.TabIndex = 10;
            // 
            // TitleTxt
            // 
            this.TitleTxt.AutoSize = true;
            this.TitleTxt.Location = new System.Drawing.Point(230, 354);
            this.TitleTxt.Name = "TitleTxt";
            this.TitleTxt.Size = new System.Drawing.Size(0, 17);
            this.TitleTxt.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(168, 492);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Description:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(168, 420);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Duration:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(168, 387);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Release Year:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Title:";
            // 
            // MoviePoster
            // 
            this.MoviePoster.Location = new System.Drawing.Point(25, 354);
            this.MoviePoster.Name = "MoviePoster";
            this.MoviePoster.Size = new System.Drawing.Size(128, 166);
            this.MoviePoster.TabIndex = 4;
            this.MoviePoster.TabStop = false;
            // 
            // tableMovie
            // 
            this.tableMovie.AutoGenerateColumns = false;
            this.tableMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableMovie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MovieId,
            this.Title,
            this.Description,
            this.ReleaseYear,
            this.Duration,
            this.PosterPath,
            this.Rating});
            this.tableMovie.DataSource = this.moviesBindingSource;
            this.tableMovie.Location = new System.Drawing.Point(16, 16);
            this.tableMovie.Name = "tableMovie";
            this.tableMovie.RowHeadersWidth = 51;
            this.tableMovie.RowTemplate.Height = 26;
            this.tableMovie.Size = new System.Drawing.Size(696, 316);
            this.tableMovie.TabIndex = 3;
            this.tableMovie.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableMovie_CellClick);
            this.tableMovie.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableMovie_CellContentClick);
            // 
            // MovieId
            // 
            this.MovieId.DataPropertyName = "MovieId";
            this.MovieId.HeaderText = "MovieId";
            this.MovieId.MinimumWidth = 6;
            this.MovieId.Name = "MovieId";
            this.MovieId.ReadOnly = true;
            this.MovieId.Width = 125;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.Width = 125;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.Width = 125;
            // 
            // ReleaseYear
            // 
            this.ReleaseYear.DataPropertyName = "ReleaseYear";
            this.ReleaseYear.HeaderText = "ReleaseYear";
            this.ReleaseYear.MinimumWidth = 6;
            this.ReleaseYear.Name = "ReleaseYear";
            this.ReleaseYear.Width = 125;
            // 
            // Duration
            // 
            this.Duration.DataPropertyName = "DurationMinutes";
            this.Duration.HeaderText = "DurationMinutes";
            this.Duration.MinimumWidth = 6;
            this.Duration.Name = "Duration";
            this.Duration.Width = 125;
            // 
            // PosterPath
            // 
            this.PosterPath.DataPropertyName = "PosterPath";
            this.PosterPath.HeaderText = "PosterPath";
            this.PosterPath.MinimumWidth = 6;
            this.PosterPath.Name = "PosterPath";
            this.PosterPath.Width = 125;
            // 
            // Rating
            // 
            this.Rating.DataPropertyName = "Rating";
            this.Rating.HeaderText = "Rating";
            this.Rating.MinimumWidth = 6;
            this.Rating.Name = "Rating";
            this.Rating.Width = 125;
            // 
            // moviesBindingSource
            // 
            this.moviesBindingSource.DataMember = "Movies";
            this.moviesBindingSource.DataSource = this.moviesDBDataSet;
            // 
            // moviesDBDataSet
            // 
            this.moviesDBDataSet.DataSetName = "MoviesDBDataSet";
            this.moviesDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // moviesTableAdapter
            // 
            this.moviesTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Manage Movies";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnBack
            // 
            this.btnBack.ForeColor = System.Drawing.Color.SandyBrown;
            this.btnBack.Image = global::Ui.Properties.Resources.user;
            this.btnBack.Location = new System.Drawing.Point(1095, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(73, 55);
            this.btnBack.TabIndex = 12;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // ManageMoviesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 629);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ManageMoviesForm";
            this.Text = "ManageMoviesForm";
            this.Load += new System.EventHandler(this.ManageMoviesForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePoster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableMovie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox txtTitle;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.RichTextBox txtReleaseYear;
        private System.Windows.Forms.RichTextBox txtPosterPath;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView tableMovie;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox txtDuration;
        private MoviesDBDataSet moviesDBDataSet;
        private System.Windows.Forms.BindingSource moviesBindingSource;
        private MoviesDBDataSetTableAdapters.MoviesTableAdapter moviesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReleaseYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn PosterPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rating;
        private System.Windows.Forms.Button btnClone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox MoviePoster;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label DurationLabel;
        private System.Windows.Forms.Label ReleaseYearLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label TitleTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label RatingLabel;
        private System.Windows.Forms.Label label12;
    }
}