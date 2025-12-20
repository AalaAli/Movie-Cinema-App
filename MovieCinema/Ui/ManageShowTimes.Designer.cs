namespace Ui
{
    partial class ManageShowTimes
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
            this.label1 = new System.Windows.Forms.Label();
            this.moviesTableAdapter = new Ui.MoviesDBDataSetTableAdapters.MoviesTableAdapter();
            this.showTimesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moviesDBDataSet1 = new Ui.MoviesDBDataSet1();
            this.moviesDBDataSet = new Ui.MoviesDBDataSet();
            this.moviesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.showTimesTableAdapter = new Ui.MoviesDBDataSet1TableAdapters.ShowTimesTableAdapter();
            this.moviesDBDataSet2 = new Ui.MoviesDBDataSet2();
            this.showTimesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.showTimesTableAdapter1 = new Ui.MoviesDBDataSet2TableAdapters.ShowTimesTableAdapter();
            this.ShowTimeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HallId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Language = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableShowTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showTimesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showTimesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "End Time";
            // 
            // txtEndTime
            // 
            this.txtEndTime.Location = new System.Drawing.Point(39, 257);
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.Size = new System.Drawing.Size(323, 42);
            this.txtEndTime.TabIndex = 11;
            this.txtEndTime.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Start Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(267, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Show Type (price depends on show Type)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Hall Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "MovieId";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(158, 466);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(99, 37);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(271, 466);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 37);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(39, 466);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 37);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel1
            // 
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
            this.panel1.Size = new System.Drawing.Size(405, 520);
            this.panel1.TabIndex = 6;
            // 
            // listLanguage
            // 
            this.listLanguage.FormattingEnabled = true;
            this.listLanguage.ItemHeight = 16;
            this.listLanguage.Items.AddRange(new object[] {
            "English",
            "Arabic"});
            this.listLanguage.Location = new System.Drawing.Point(39, 389);
            this.listLanguage.Name = "listLanguage";
            this.listLanguage.Size = new System.Drawing.Size(226, 52);
            this.listLanguage.TabIndex = 18;
            // 
            // btnMax
            // 
            this.btnMax.AutoSize = true;
            this.btnMax.Location = new System.Drawing.Point(294, 322);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(59, 21);
            this.btnMax.TabIndex = 17;
            this.btnMax.TabStop = true;
            this.btnMax.Text = "IMAX";
            this.btnMax.UseVisualStyleBackColor = true;
            // 
            // btn3D
            // 
            this.btn3D.AutoSize = true;
            this.btn3D.Location = new System.Drawing.Point(173, 322);
            this.btn3D.Name = "btn3D";
            this.btn3D.Size = new System.Drawing.Size(47, 21);
            this.btn3D.TabIndex = 16;
            this.btn3D.TabStop = true;
            this.btn3D.Text = "3D";
            this.btn3D.UseVisualStyleBackColor = true;
            // 
            // btn2D
            // 
            this.btn2D.AutoSize = true;
            this.btn2D.Location = new System.Drawing.Point(44, 322);
            this.btn2D.Name = "btn2D";
            this.btn2D.Size = new System.Drawing.Size(47, 21);
            this.btn2D.TabIndex = 15;
            this.btn2D.TabStop = true;
            this.btn2D.Text = "2D";
            this.btn2D.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Language";
            // 
            // txtStartTime
            // 
            this.txtStartTime.Location = new System.Drawing.Point(39, 178);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(323, 42);
            this.txtStartTime.TabIndex = 4;
            this.txtStartTime.Text = "";
            // 
            // txtHallId
            // 
            this.txtHallId.Location = new System.Drawing.Point(39, 109);
            this.txtHallId.Name = "txtHallId";
            this.txtHallId.Size = new System.Drawing.Size(323, 42);
            this.txtHallId.TabIndex = 3;
            this.txtHallId.Text = "";
            // 
            // txtMovieId
            // 
            this.txtMovieId.Location = new System.Drawing.Point(39, 46);
            this.txtMovieId.Name = "txtMovieId";
            this.txtMovieId.Size = new System.Drawing.Size(323, 42);
            this.txtMovieId.TabIndex = 0;
            this.txtMovieId.Text = "";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableShowTime);
            this.panel2.Location = new System.Drawing.Point(450, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(715, 520);
            this.panel2.TabIndex = 7;
            // 
            // tableShowTime
            // 
            this.tableShowTime.AllowUserToDeleteRows = false;
            this.tableShowTime.AutoGenerateColumns = false;
            this.tableShowTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableShowTime.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ShowTimeId,
            this.MovieId,
            this.HallId,
            this.StartTime,
            this.EndTime,
            this.Price,
            this.Language});
            this.tableShowTime.DataSource = this.showTimesBindingSource1;
            this.tableShowTime.Location = new System.Drawing.Point(19, 36);
            this.tableShowTime.Name = "tableShowTime";
            this.tableShowTime.ReadOnly = true;
            this.tableShowTime.RowHeadersWidth = 51;
            this.tableShowTime.RowTemplate.Height = 26;
            this.tableShowTime.Size = new System.Drawing.Size(679, 379);
            this.tableShowTime.TabIndex = 3;
            this.tableShowTime.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableShowTime_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = " Show Times";
            // 
            // moviesTableAdapter
            // 
            this.moviesTableAdapter.ClearBeforeFill = true;
            // 
            // showTimesBindingSource
            // 
            this.showTimesBindingSource.DataMember = "ShowTimes";
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
            // moviesDBDataSet2
            // 
            this.moviesDBDataSet2.DataSetName = "MoviesDBDataSet2";
            this.moviesDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // showTimesBindingSource1
            // 
            this.showTimesBindingSource1.DataMember = "ShowTimes";
            this.showTimesBindingSource1.DataSource = this.moviesDBDataSet2;
            // 
            // showTimesTableAdapter1
            // 
            this.showTimesTableAdapter1.ClearBeforeFill = true;
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
            // ManageShowTimes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 622);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "ManageShowTimes";
            this.Text = "ManageShowTimes";
            this.Load += new System.EventHandler(this.ManageShowTimes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableShowTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showTimesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showTimesBindingSource1)).EndInit();
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
    }
}