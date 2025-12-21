namespace Ui
{
    partial class ManageShowTimes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEndTime = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listLanguage = new System.Windows.Forms.ListBox();
            this.btnMax = new System.Windows.Forms.RadioButton();
            this.btn3D = new System.Windows.Forms.RadioButton();
            this.btn2D = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStartTime = new System.Windows.Forms.RichTextBox();
            this.txtHallId = new System.Windows.Forms.RichTextBox();
            this.txtMovieId = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableShowTime = new System.Windows.Forms.DataGridView();
            this.ShowTimeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HallId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Language = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.showTimeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hallIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.languageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.showTimesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.moviesDBDataSet2 = new Ui.MoviesDBDataSet2();
            this.label1 = new System.Windows.Forms.Label();
            this.moviesTableAdapter = new Ui.MoviesDBDataSetTableAdapters.MoviesTableAdapter();
            this.moviesDBDataSet1 = new Ui.MoviesDBDataSet1();
            this.moviesDBDataSet = new Ui.MoviesDBDataSet();
            this.moviesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.showTimesTableAdapter = new Ui.MoviesDBDataSet1TableAdapters.ShowTimesTableAdapter();
            this.showTimesTableAdapter1 = new Ui.MoviesDBDataSet2TableAdapters.ShowTimesTableAdapter();
            this.showTimesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableShowTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showTimesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showTimesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.label7.Location = new System.Drawing.Point(41, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "End Time";
            // 
            // txtEndTime
            // 
            this.txtEndTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtEndTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEndTime.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEndTime.ForeColor = System.Drawing.Color.White;
            this.txtEndTime.Location = new System.Drawing.Point(39, 257);
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.Size = new System.Drawing.Size(323, 42);
            this.txtEndTime.TabIndex = 11;
            this.txtEndTime.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.label6.Location = new System.Drawing.Point(41, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Start Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.label5.Location = new System.Drawing.Point(41, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(295, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Show Type (price depends on show Type)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.label4.Location = new System.Drawing.Point(36, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Hall Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.label3.Location = new System.Drawing.Point(36, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "MovieId";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.Ivory;
            this.btnUpdate.Location = new System.Drawing.Point(148, 466);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(102, 50);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(271, 466);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 50);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(36, 466);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 50);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.listLanguage);
            this.panel1.Controls.Add(this.btnMax);
            this.panel1.Controls.Add(this.btn3D);
            this.panel1.Controls.Add(this.btn2D);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtEndTime);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtStartTime);
            this.panel1.Controls.Add(this.txtHallId);
            this.panel1.Controls.Add(this.txtMovieId);
            this.panel1.Location = new System.Drawing.Point(12, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 537);
            this.panel1.TabIndex = 6;
            // 
            // listLanguage
            // 
            this.listLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.listLanguage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listLanguage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.listLanguage.ForeColor = System.Drawing.Color.White;
            this.listLanguage.FormattingEnabled = true;
            this.listLanguage.ItemHeight = 23;
            this.listLanguage.Items.AddRange(new object[] {
            "English",
            "Arabic"});
            this.listLanguage.Location = new System.Drawing.Point(39, 389);
            this.listLanguage.Name = "listLanguage";
            this.listLanguage.Size = new System.Drawing.Size(321, 48);
            this.listLanguage.TabIndex = 18;
            // 
            // btnMax
            // 
            this.btnMax.AutoSize = true;
            this.btnMax.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.btnMax.Location = new System.Drawing.Point(294, 322);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(66, 24);
            this.btnMax.TabIndex = 17;
            this.btnMax.TabStop = true;
            this.btnMax.Text = "IMAX";
            this.btnMax.UseVisualStyleBackColor = true;
            // 
            // btn3D
            // 
            this.btn3D.AutoSize = true;
            this.btn3D.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn3D.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.btn3D.Location = new System.Drawing.Point(173, 322);
            this.btn3D.Name = "btn3D";
            this.btn3D.Size = new System.Drawing.Size(49, 24);
            this.btn3D.TabIndex = 16;
            this.btn3D.TabStop = true;
            this.btn3D.Text = "3D";
            this.btn3D.UseVisualStyleBackColor = true;
            // 
            // btn2D
            // 
            this.btn2D.AutoSize = true;
            this.btn2D.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn2D.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.btn2D.Location = new System.Drawing.Point(44, 322);
            this.btn2D.Name = "btn2D";
            this.btn2D.Size = new System.Drawing.Size(49, 24);
            this.btn2D.TabIndex = 15;
            this.btn2D.TabStop = true;
            this.btn2D.Text = "2D";
            this.btn2D.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.label2.Location = new System.Drawing.Point(41, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Language";
            // 
            // txtStartTime
            // 
            this.txtStartTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtStartTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStartTime.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtStartTime.ForeColor = System.Drawing.Color.White;
            this.txtStartTime.Location = new System.Drawing.Point(39, 178);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(323, 42);
            this.txtStartTime.TabIndex = 4;
            this.txtStartTime.Text = "";
            // 
            // txtHallId
            // 
            this.txtHallId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtHallId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHallId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtHallId.ForeColor = System.Drawing.Color.White;
            this.txtHallId.Location = new System.Drawing.Point(39, 109);
            this.txtHallId.Name = "txtHallId";
            this.txtHallId.Size = new System.Drawing.Size(323, 42);
            this.txtHallId.TabIndex = 3;
            this.txtHallId.Text = "";
            // 
            // txtMovieId
            // 
            this.txtMovieId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtMovieId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMovieId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMovieId.ForeColor = System.Drawing.Color.White;
            this.txtMovieId.Location = new System.Drawing.Point(39, 46);
            this.txtMovieId.Name = "txtMovieId";
            this.txtMovieId.Size = new System.Drawing.Size(323, 42);
            this.txtMovieId.TabIndex = 0;
            this.txtMovieId.Text = "";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.panel2.Controls.Add(this.tableShowTime);
            this.panel2.Location = new System.Drawing.Point(450, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(715, 537);
            this.panel2.TabIndex = 7;
            // 
            // tableShowTime
            // 
            this.tableShowTime.AllowUserToDeleteRows = false;
            this.tableShowTime.AutoGenerateColumns = false;
            this.tableShowTime.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableShowTime.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tableShowTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableShowTime.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ShowTimeId,
            this.MovieId,
            this.HallId,
            this.StartTime,
            this.EndTime,
            this.Price,
            this.Language,
            this.showTimeIdDataGridViewTextBoxColumn,
            this.movieIdDataGridViewTextBoxColumn,
            this.hallIdDataGridViewTextBoxColumn,
            this.startTimeDataGridViewTextBoxColumn,
            this.endTimeDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.languageDataGridViewTextBoxColumn});
            this.tableShowTime.DataSource = this.showTimesBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableShowTime.DefaultCellStyle = dataGridViewCellStyle2;
            this.tableShowTime.EnableHeadersVisualStyles = false;
            this.tableShowTime.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.tableShowTime.Location = new System.Drawing.Point(19, 36);
            this.tableShowTime.Name = "tableShowTime";
            this.tableShowTime.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableShowTime.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tableShowTime.RowHeadersWidth = 51;
            this.tableShowTime.RowTemplate.Height = 26;
            this.tableShowTime.Size = new System.Drawing.Size(679, 379);
            this.tableShowTime.TabIndex = 3;
            this.tableShowTime.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableShowTime_CellClick);
            // 
            // ShowTimeId
            // 
            this.ShowTimeId.DataPropertyName = "ShowTimeId";
            this.ShowTimeId.HeaderText = "ShowTimeId";
            this.ShowTimeId.MinimumWidth = 6;
            this.ShowTimeId.Name = "ShowTimeId";
            this.ShowTimeId.ReadOnly = true;
            this.ShowTimeId.Width = 125;
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
            // HallId
            // 
            this.HallId.DataPropertyName = "HallId";
            this.HallId.HeaderText = "HallId";
            this.HallId.MinimumWidth = 6;
            this.HallId.Name = "HallId";
            this.HallId.ReadOnly = true;
            this.HallId.Width = 125;
            // 
            // StartTime
            // 
            this.StartTime.DataPropertyName = "StartTime";
            this.StartTime.HeaderText = "StartTime";
            this.StartTime.MinimumWidth = 6;
            this.StartTime.Name = "StartTime";
            this.StartTime.ReadOnly = true;
            this.StartTime.Width = 125;
            // 
            // EndTime
            // 
            this.EndTime.DataPropertyName = "EndTime";
            this.EndTime.HeaderText = "EndTime";
            this.EndTime.MinimumWidth = 6;
            this.EndTime.Name = "EndTime";
            this.EndTime.ReadOnly = true;
            this.EndTime.Width = 125;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 125;
            // 
            // Language
            // 
            this.Language.DataPropertyName = "Language";
            this.Language.HeaderText = "Language";
            this.Language.MinimumWidth = 6;
            this.Language.Name = "Language";
            this.Language.ReadOnly = true;
            this.Language.Width = 125;
            // 
            // showTimeIdDataGridViewTextBoxColumn
            // 
            this.showTimeIdDataGridViewTextBoxColumn.DataPropertyName = "ShowTimeId";
            this.showTimeIdDataGridViewTextBoxColumn.HeaderText = "ShowTimeId";
            this.showTimeIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.showTimeIdDataGridViewTextBoxColumn.Name = "showTimeIdDataGridViewTextBoxColumn";
            this.showTimeIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.showTimeIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // movieIdDataGridViewTextBoxColumn
            // 
            this.movieIdDataGridViewTextBoxColumn.DataPropertyName = "MovieId";
            this.movieIdDataGridViewTextBoxColumn.HeaderText = "MovieId";
            this.movieIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.movieIdDataGridViewTextBoxColumn.Name = "movieIdDataGridViewTextBoxColumn";
            this.movieIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.movieIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // hallIdDataGridViewTextBoxColumn
            // 
            this.hallIdDataGridViewTextBoxColumn.DataPropertyName = "HallId";
            this.hallIdDataGridViewTextBoxColumn.HeaderText = "HallId";
            this.hallIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hallIdDataGridViewTextBoxColumn.Name = "hallIdDataGridViewTextBoxColumn";
            this.hallIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.hallIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // startTimeDataGridViewTextBoxColumn
            // 
            this.startTimeDataGridViewTextBoxColumn.DataPropertyName = "StartTime";
            this.startTimeDataGridViewTextBoxColumn.HeaderText = "StartTime";
            this.startTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
            this.startTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.startTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // endTimeDataGridViewTextBoxColumn
            // 
            this.endTimeDataGridViewTextBoxColumn.DataPropertyName = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.HeaderText = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
            this.endTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.endTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // languageDataGridViewTextBoxColumn
            // 
            this.languageDataGridViewTextBoxColumn.DataPropertyName = "Language";
            this.languageDataGridViewTextBoxColumn.HeaderText = "Language";
            this.languageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.languageDataGridViewTextBoxColumn.Name = "languageDataGridViewTextBoxColumn";
            this.languageDataGridViewTextBoxColumn.ReadOnly = true;
            this.languageDataGridViewTextBoxColumn.Width = 125;
            // 
            // showTimesBindingSource1
            // 
            this.showTimesBindingSource1.DataMember = "ShowTimes";
            this.showTimesBindingSource1.DataSource = this.moviesDBDataSet2;
            // 
            // moviesDBDataSet2
            // 
            this.moviesDBDataSet2.DataSetName = "MoviesDBDataSet2";
            this.moviesDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 41);
            this.label1.TabIndex = 8;
            this.label1.Text = "MANAGE SHOW TIMES";
            // 
            // moviesTableAdapter
            // 
            this.moviesTableAdapter.ClearBeforeFill = true;
            // 
            // moviesDBDataSet1
            // 
            this.moviesDBDataSet1.DataSetName = "MoviesDBDataSet1";
            this.moviesDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // moviesDBDataSet
            // 
            this.moviesDBDataSet.DataSetName = "MoviesDBDataSet";
            this.moviesDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // moviesBindingSource
            // 
            this.moviesBindingSource.DataMember = "Movies";
            this.moviesBindingSource.DataSource = this.moviesDBDataSet;
            // 
            // showTimesTableAdapter
            // 
            this.showTimesTableAdapter.ClearBeforeFill = true;
            // 
            // showTimesTableAdapter1
            // 
            this.showTimesTableAdapter1.ClearBeforeFill = true;
            // 
            // showTimesBindingSource
            // 
            this.showTimesBindingSource.DataMember = "ShowTimes";
            // 
            // btnBack
            // 
            this.btnBack.ForeColor = System.Drawing.Color.SandyBrown;
            this.btnBack.Image = global::Ui.Properties.Resources.user;
            this.btnBack.Location = new System.Drawing.Point(1092, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(73, 55);
            this.btnBack.TabIndex = 11;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // ManageShowTimes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1200, 622);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Tahoma", 8F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ManageShowTimes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cinema Library - Manage Show Times";
            this.Load += new System.EventHandler(this.ManageShowTimes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableShowTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showTimesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showTimesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox txtEndTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox txtStartTime;
        private System.Windows.Forms.RichTextBox txtHallId;
        private System.Windows.Forms.RichTextBox txtMovieId;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView tableShowTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton btn2D;
        private System.Windows.Forms.ListBox listLanguage;
        private System.Windows.Forms.RadioButton btnMax;
        private System.Windows.Forms.RadioButton btn3D;
        private MoviesDBDataSetTableAdapters.MoviesTableAdapter moviesTableAdapter;
        private System.Windows.Forms.BindingSource showTimesBindingSource;
        private MoviesDBDataSet1 moviesDBDataSet1;
        private MoviesDBDataSet moviesDBDataSet;
        private System.Windows.Forms.BindingSource moviesBindingSource;
        private System.Windows.Forms.Timer timer1;
        private MoviesDBDataSet1TableAdapters.ShowTimesTableAdapter showTimesTableAdapter;
        private MoviesDBDataSet2 moviesDBDataSet2;
        private System.Windows.Forms.BindingSource showTimesBindingSource1;
        private MoviesDBDataSet2TableAdapters.ShowTimesTableAdapter showTimesTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShowTimeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieId;
        private System.Windows.Forms.DataGridViewTextBoxColumn HallId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Language;
        private System.Windows.Forms.DataGridViewTextBoxColumn showTimeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hallIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn languageDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnBack;
    }
}