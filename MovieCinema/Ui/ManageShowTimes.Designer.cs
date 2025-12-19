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
            this.moviesTableAdapter = new Ui.MoviesDBDataSetTableAdapters.MoviesTableAdapter();
            this.moviesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moviesDBDataSet = new Ui.MoviesDBDataSet();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPosterPath = new System.Windows.Forms.RichTextBox();
            this.txtReleaseYear = new System.Windows.Forms.RichTextBox();
            this.txtTitle = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableMovie = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.moviesDBDataSet1 = new Ui.MoviesDBDataSet1();
            this.showTimesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.showTimesTableAdapter = new Ui.MoviesDBDataSet1TableAdapters.ShowTimesTableAdapter();
            this.ShowTimeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HallId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Language = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesDBDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableMovie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showTimesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // moviesTableAdapter
            // 
            this.moviesTableAdapter.ClearBeforeFill = true;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "End Time";
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
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Start Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Price";
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
            this.btnUpdate.Location = new System.Drawing.Point(148, 466);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(99, 37);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(271, 466);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 37);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(39, 466);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 37);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.label2);
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
            this.panel1.Controls.Add(this.txtTitle);
            this.panel1.Location = new System.Drawing.Point(12, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 520);
            this.panel1.TabIndex = 6;
            // 
            // txtPosterPath
            // 
            this.txtPosterPath.Location = new System.Drawing.Point(39, 178);
            this.txtPosterPath.Name = "txtPosterPath";
            this.txtPosterPath.Size = new System.Drawing.Size(323, 42);
            this.txtPosterPath.TabIndex = 4;
            this.txtPosterPath.Text = "";
            // 
            // txtReleaseYear
            // 
            this.txtReleaseYear.Location = new System.Drawing.Point(39, 109);
            this.txtReleaseYear.Name = "txtReleaseYear";
            this.txtReleaseYear.Size = new System.Drawing.Size(323, 42);
            this.txtReleaseYear.TabIndex = 3;
            this.txtReleaseYear.Text = "";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(39, 46);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(323, 42);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.Text = "";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableMovie);
            this.panel2.Location = new System.Drawing.Point(450, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(715, 520);
            this.panel2.TabIndex = 7;
            // 
            // tableMovie
            // 
            this.tableMovie.AutoGenerateColumns = false;
            this.tableMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableMovie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ShowTimeId,
            this.MovieId,
            this.HallId,
            this.StartTime,
            this.EndTime,
            this.Price,
            this.Language});
            this.tableMovie.DataSource = this.showTimesBindingSource;
            this.tableMovie.Location = new System.Drawing.Point(3, 26);
            this.tableMovie.Name = "tableMovie";
            this.tableMovie.RowHeadersWidth = 51;
            this.tableMovie.RowTemplate.Height = 26;
            this.tableMovie.Size = new System.Drawing.Size(693, 379);
            this.tableMovie.TabIndex = 3;
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
            // moviesDBDataSet1
            // 
            this.moviesDBDataSet1.DataSetName = "MoviesDBDataSet1";
            this.moviesDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // showTimesBindingSource
            // 
            this.showTimesBindingSource.DataMember = "ShowTimes";
            this.showTimesBindingSource.DataSource = this.moviesDBDataSet1;
            // 
            // showTimesTableAdapter
            // 
            this.showTimesTableAdapter.ClearBeforeFill = true;
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
            this.MovieId.Width = 125;
            // 
            // HallId
            // 
            this.HallId.DataPropertyName = "HallId";
            this.HallId.HeaderText = "HallId";
            this.HallId.MinimumWidth = 6;
            this.HallId.Name = "HallId";
            this.HallId.Width = 125;
            // 
            // StartTime
            // 
            this.StartTime.DataPropertyName = "StartTime";
            this.StartTime.HeaderText = "StartTime";
            this.StartTime.MinimumWidth = 6;
            this.StartTime.Name = "StartTime";
            this.StartTime.Width = 125;
            // 
            // EndTime
            // 
            this.EndTime.DataPropertyName = "EndTime";
            this.EndTime.HeaderText = "EndTime";
            this.EndTime.MinimumWidth = 6;
            this.EndTime.Name = "EndTime";
            this.EndTime.Width = 125;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // Language
            // 
            this.Language.DataPropertyName = "Language";
            this.Language.HeaderText = "Language";
            this.Language.MinimumWidth = 6;
            this.Language.Name = "Language";
            this.Language.Width = 125;
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
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(44, 322);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(57, 21);
            this.radioButton1.TabIndex = 15;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "10 $";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(169, 322);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(57, 21);
            this.radioButton2.TabIndex = 16;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "15 $";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(305, 322);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(57, 21);
            this.radioButton3.TabIndex = 17;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "20 $";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "English",
            "Arabic"});
            this.listBox1.Location = new System.Drawing.Point(39, 380);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(226, 52);
            this.listBox1.TabIndex = 18;
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
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesDBDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableMovie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showTimesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MoviesDBDataSetTableAdapters.MoviesTableAdapter moviesTableAdapter;
        private System.Windows.Forms.BindingSource moviesBindingSource;
        private MoviesDBDataSet moviesDBDataSet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox txtDuration;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox txtPosterPath;
        private System.Windows.Forms.RichTextBox txtReleaseYear;
        private System.Windows.Forms.RichTextBox txtTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView tableMovie;
        private System.Windows.Forms.Label label1;
        private MoviesDBDataSet1 moviesDBDataSet1;
        private System.Windows.Forms.BindingSource showTimesBindingSource;
        private MoviesDBDataSet1TableAdapters.ShowTimesTableAdapter showTimesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShowTimeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieId;
        private System.Windows.Forms.DataGridViewTextBoxColumn HallId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Language;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}