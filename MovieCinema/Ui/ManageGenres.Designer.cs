namespace Ui
{
    partial class ManageGenres
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtParentIdlabel = new System.Windows.Forms.Label();
            this.txtParentId = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGenreName = new System.Windows.Forms.RichTextBox();
            this.genresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moviesDBDataSet3 = new Ui.MoviesDBDataSet3();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtGenreId = new System.Windows.Forms.RichTextBox();
            this.txtMovieId = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.movieGenresTable = new System.Windows.Forms.DataGridView();
            this.MovieGenreId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieIdFk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenreIDFk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieGenresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moviesDBDataSet4 = new Ui.MoviesDBDataSet4();
            this.genresTableAdapter = new Ui.MoviesDBDataSet3TableAdapters.GenresTableAdapter();
            this.movieGenresTableAdapter = new Ui.MoviesDBDataSet4TableAdapters.MovieGenresTableAdapter();
            this.genreTable = new System.Windows.Forms.DataGridView();
            this.GenreId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenreName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesDBDataSet3)).BeginInit();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieGenresTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieGenresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesDBDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreTable)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.txtParentIdlabel);
            this.panel1.Controls.Add(this.txtParentId);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtGenreName);
            this.panel1.Location = new System.Drawing.Point(23, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 239);
            this.panel1.TabIndex = 0;
            // 
            // txtParentIdlabel
            // 
            this.txtParentIdlabel.AutoSize = true;
            this.txtParentIdlabel.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtParentIdlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.txtParentIdlabel.Location = new System.Drawing.Point(17, 87);
            this.txtParentIdlabel.Name = "txtParentIdlabel";
            this.txtParentIdlabel.Size = new System.Drawing.Size(71, 21);
            this.txtParentIdlabel.TabIndex = 9;
            this.txtParentIdlabel.Text = "Parent Id";
            // 
            // txtParentId
            // 
            this.txtParentId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtParentId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtParentId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtParentId.ForeColor = System.Drawing.Color.White;
            this.txtParentId.Location = new System.Drawing.Point(16, 107);
            this.txtParentId.Name = "txtParentId";
            this.txtParentId.Size = new System.Drawing.Size(288, 32);
            this.txtParentId.TabIndex = 8;
            this.txtParentId.Text = "";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(220, 158);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 45);
            this.button3.TabIndex = 7;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(120, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 45);
            this.button1.TabIndex = 6;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(16, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 45);
            this.button2.TabIndex = 0;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.label3.Location = new System.Drawing.Point(13, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Genre Name";
            // 
            // txtGenreName
            // 
            this.txtGenreName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtGenreName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGenreName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtGenreName.ForeColor = System.Drawing.Color.White;
            this.txtGenreName.Location = new System.Drawing.Point(16, 39);
            this.txtGenreName.Name = "txtGenreName";
            this.txtGenreName.Size = new System.Drawing.Size(288, 32);
            this.txtGenreName.TabIndex = 1;
            this.txtGenreName.Text = "";
            // 
            // genresBindingSource
            // 
            this.genresBindingSource.DataMember = "Genres";
            this.genresBindingSource.DataSource = this.moviesDBDataSet3;
            // 
            // moviesDBDataSet3
            // 
            this.moviesDBDataSet3.DataSetName = "MoviesDBDataSet3";
            this.moviesDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.label1.Location = new System.Drawing.Point(20, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "MANAGE GENRES";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.txtGenreId);
            this.panel3.Controls.Add(this.txtMovieId);
            this.panel3.Location = new System.Drawing.Point(23, 350);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(325, 239);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.label4.Location = new System.Drawing.Point(17, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "GenreId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.label2.Location = new System.Drawing.Point(17, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "MovieId";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button6.ForeColor = System.Drawing.Color.Transparent;
            this.button6.Location = new System.Drawing.Point(220, 181);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(90, 45);
            this.button6.TabIndex = 10;
            this.button6.Text = "Update";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(120, 181);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 45);
            this.button5.TabIndex = 10;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(16, 181);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 45);
            this.button4.TabIndex = 10;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtGenreId
            // 
            this.txtGenreId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtGenreId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGenreId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtGenreId.ForeColor = System.Drawing.Color.White;
            this.txtGenreId.Location = new System.Drawing.Point(16, 121);
            this.txtGenreId.Name = "txtGenreId";
            this.txtGenreId.Size = new System.Drawing.Size(288, 32);
            this.txtGenreId.TabIndex = 11;
            this.txtGenreId.Text = "";
            // 
            // txtMovieId
            // 
            this.txtMovieId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtMovieId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMovieId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMovieId.ForeColor = System.Drawing.Color.White;
            this.txtMovieId.Location = new System.Drawing.Point(16, 47);
            this.txtMovieId.Name = "txtMovieId";
            this.txtMovieId.Size = new System.Drawing.Size(288, 32);
            this.txtMovieId.TabIndex = 10;
            this.txtMovieId.Text = "";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.flowLayoutPanel2.Controls.Add(this.movieGenresTable);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(374, 350);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(473, 239);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // movieGenresTable
            // 
            this.movieGenresTable.AllowUserToAddRows = false;
            this.movieGenresTable.AllowUserToDeleteRows = false;
            this.movieGenresTable.AutoGenerateColumns = false;
            this.movieGenresTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.movieGenresTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.movieGenresTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.movieGenresTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MovieGenreId,
            this.MovieIdFk,
            this.GenreIDFk});
            this.movieGenresTable.DataSource = this.movieGenresBindingSource;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.movieGenresTable.DefaultCellStyle = dataGridViewCellStyle20;
            this.movieGenresTable.EnableHeadersVisualStyles = false;
            this.movieGenresTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.movieGenresTable.Location = new System.Drawing.Point(3, 3);
            this.movieGenresTable.Name = "movieGenresTable";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.movieGenresTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.movieGenresTable.RowHeadersWidth = 51;
            this.movieGenresTable.RowTemplate.Height = 26;
            this.movieGenresTable.Size = new System.Drawing.Size(427, 209);
            this.movieGenresTable.TabIndex = 0;
            this.movieGenresTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.getMovieGenreTable_CellClick);
            // 
            // MovieGenreId
            // 
            this.MovieGenreId.DataPropertyName = "MovieGenreId";
            this.MovieGenreId.HeaderText = "MovieGenreId";
            this.MovieGenreId.MinimumWidth = 6;
            this.MovieGenreId.Name = "MovieGenreId";
            this.MovieGenreId.ReadOnly = true;
            this.MovieGenreId.Width = 125;
            // 
            // MovieIdFk
            // 
            this.MovieIdFk.DataPropertyName = "MovieId";
            this.MovieIdFk.HeaderText = "MovieId";
            this.MovieIdFk.MinimumWidth = 6;
            this.MovieIdFk.Name = "MovieIdFk";
            this.MovieIdFk.Width = 125;
            // 
            // GenreIDFk
            // 
            this.GenreIDFk.DataPropertyName = "GenreId";
            this.GenreIDFk.HeaderText = "GenreId";
            this.GenreIDFk.MinimumWidth = 6;
            this.GenreIDFk.Name = "GenreIDFk";
            this.GenreIDFk.Width = 125;
            // 
            // movieGenresBindingSource
            // 
            this.movieGenresBindingSource.DataMember = "MovieGenres";
            this.movieGenresBindingSource.DataSource = this.moviesDBDataSet4;
            // 
            // moviesDBDataSet4
            // 
            this.moviesDBDataSet4.DataSetName = "MoviesDBDataSet4";
            this.moviesDBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // genresTableAdapter
            // 
            this.genresTableAdapter.ClearBeforeFill = true;
            // 
            // movieGenresTableAdapter
            // 
            this.movieGenresTableAdapter.ClearBeforeFill = true;
            // 
            // genreTable
            // 
            this.genreTable.AllowUserToAddRows = false;
            this.genreTable.AllowUserToDeleteRows = false;
            this.genreTable.AutoGenerateColumns = false;
            this.genreTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.genreTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.genreTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.genreTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GenreId,
            this.GenreName,
            this.ParentId});
            this.genreTable.DataSource = this.genresBindingSource;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.genreTable.DefaultCellStyle = dataGridViewCellStyle23;
            this.genreTable.EnableHeadersVisualStyles = false;
            this.genreTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.genreTable.Location = new System.Drawing.Point(3, 3);
            this.genreTable.Name = "genreTable";
            this.genreTable.ReadOnly = true;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.genreTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.genreTable.RowHeadersWidth = 51;
            this.genreTable.RowTemplate.Height = 26;
            this.genreTable.Size = new System.Drawing.Size(427, 197);
            this.genreTable.TabIndex = 0;
            this.genreTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.genreTable_CellClick);
            this.genreTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.genreTable_CellContentClick);
            // 
            // GenreId
            // 
            this.GenreId.DataPropertyName = "GenreId";
            this.GenreId.HeaderText = "GenreId";
            this.GenreId.MinimumWidth = 6;
            this.GenreId.Name = "GenreId";
            this.GenreId.ReadOnly = true;
            this.GenreId.Width = 125;
            // 
            // GenreName
            // 
            this.GenreName.DataPropertyName = "GenreName";
            this.GenreName.HeaderText = "GenreName";
            this.GenreName.MinimumWidth = 6;
            this.GenreName.Name = "GenreName";
            this.GenreName.ReadOnly = true;
            this.GenreName.Width = 125;
            // 
            // ParentId
            // 
            this.ParentId.DataPropertyName = "ParentId";
            this.ParentId.HeaderText = "ParentId";
            this.ParentId.MinimumWidth = 6;
            this.ParentId.Name = "ParentId";
            this.ParentId.ReadOnly = true;
            this.ParentId.Width = 125;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.flowLayoutPanel1.Controls.Add(this.genreTable);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(374, 89);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(473, 239);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Image = global::Ui.Properties.Resources.user;
            this.btnBack.Location = new System.Drawing.Point(774, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(73, 55);
            this.btnBack.TabIndex = 13;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ManageGenres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(879, 627);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 8F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ManageGenres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cinema Library - Manage Genres";
            this.Load += new System.EventHandler(this.ManageGenres_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesDBDataSet3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.movieGenresTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieGenresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesDBDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreTable)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtGenreName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private MoviesDBDataSet3 moviesDBDataSet3;
        private System.Windows.Forms.BindingSource genresBindingSource;
        private MoviesDBDataSet3TableAdapters.GenresTableAdapter genresTableAdapter;
        private System.Windows.Forms.Label txtParentIdlabel;
        private System.Windows.Forms.RichTextBox txtParentId;
        private System.Windows.Forms.DataGridView movieGenresTable;
        private MoviesDBDataSet4 moviesDBDataSet4;
        private System.Windows.Forms.BindingSource movieGenresBindingSource;
        private MoviesDBDataSet4TableAdapters.MovieGenresTableAdapter movieGenresTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RichTextBox txtGenreId;
        private System.Windows.Forms.RichTextBox txtMovieId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieGenreId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieIdFk;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenreIDFk;
        private System.Windows.Forms.DataGridView genreTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenreId;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenreName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParentId;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnBack;
    }
}