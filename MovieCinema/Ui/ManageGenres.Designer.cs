namespace Ui
{
    partial class ManageGenres
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtGenreName = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.genreTable = new System.Windows.Forms.DataGridView();
            this.txtParentId = new System.Windows.Forms.RichTextBox();
            this.txtParentIdlabel = new System.Windows.Forms.Label();
            this.genreIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moviesDBDataSet3 = new Ui.MoviesDBDataSet3();
            this.genresTableAdapter = new Ui.MoviesDBDataSet3TableAdapters.GenresTableAdapter();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genreTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesDBDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.genreTable);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(374, 89);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(473, 239);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Manage Movie Genres";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(23, 350);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(325, 239);
            this.panel3.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(374, 350);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(473, 239);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // txtGenreName
            // 
            this.txtGenreName.Location = new System.Drawing.Point(16, 39);
            this.txtGenreName.Name = "txtGenreName";
            this.txtGenreName.Size = new System.Drawing.Size(278, 32);
            this.txtGenreName.TabIndex = 1;
            this.txtGenreName.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Genre Name";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 42);
            this.button2.TabIndex = 0;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(210, 158);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 42);
            this.button3.TabIndex = 7;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // genreTable
            // 
            this.genreTable.AllowUserToAddRows = false;
            this.genreTable.AllowUserToDeleteRows = false;
            this.genreTable.AutoGenerateColumns = false;
            this.genreTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.genreTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.genreIdDataGridViewTextBoxColumn,
            this.genreNameDataGridViewTextBoxColumn,
            this.parentIdDataGridViewTextBoxColumn});
            this.genreTable.DataSource = this.genresBindingSource;
            this.genreTable.Location = new System.Drawing.Point(3, 3);
            this.genreTable.Name = "genreTable";
            this.genreTable.ReadOnly = true;
            this.genreTable.RowHeadersWidth = 51;
            this.genreTable.RowTemplate.Height = 26;
            this.genreTable.Size = new System.Drawing.Size(429, 150);
            this.genreTable.TabIndex = 0;
            this.genreTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.genreTable_CellContentClick);
            // 
            // txtParentId
            // 
            this.txtParentId.Location = new System.Drawing.Point(16, 107);
            this.txtParentId.Name = "txtParentId";
            this.txtParentId.Size = new System.Drawing.Size(278, 32);
            this.txtParentId.TabIndex = 8;
            this.txtParentId.Text = "";
            // 
            // txtParentIdlabel
            // 
            this.txtParentIdlabel.AutoSize = true;
            this.txtParentIdlabel.Location = new System.Drawing.Point(17, 87);
            this.txtParentIdlabel.Name = "txtParentIdlabel";
            this.txtParentIdlabel.Size = new System.Drawing.Size(64, 17);
            this.txtParentIdlabel.TabIndex = 9;
            this.txtParentIdlabel.Text = "Parent Id";
            // 
            // genreIdDataGridViewTextBoxColumn
            // 
            this.genreIdDataGridViewTextBoxColumn.DataPropertyName = "GenreId";
            this.genreIdDataGridViewTextBoxColumn.HeaderText = "GenreId";
            this.genreIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genreIdDataGridViewTextBoxColumn.Name = "genreIdDataGridViewTextBoxColumn";
            this.genreIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.genreIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // genreNameDataGridViewTextBoxColumn
            // 
            this.genreNameDataGridViewTextBoxColumn.DataPropertyName = "GenreName";
            this.genreNameDataGridViewTextBoxColumn.HeaderText = "GenreName";
            this.genreNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genreNameDataGridViewTextBoxColumn.Name = "genreNameDataGridViewTextBoxColumn";
            this.genreNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.genreNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // parentIdDataGridViewTextBoxColumn
            // 
            this.parentIdDataGridViewTextBoxColumn.DataPropertyName = "ParentId";
            this.parentIdDataGridViewTextBoxColumn.HeaderText = "ParentId";
            this.parentIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.parentIdDataGridViewTextBoxColumn.Name = "parentIdDataGridViewTextBoxColumn";
            this.parentIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.parentIdDataGridViewTextBoxColumn.Width = 125;
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
            // genresTableAdapter
            // 
            this.genresTableAdapter.ClearBeforeFill = true;
            // 
            // ManageGenres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 601);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "ManageGenres";
            this.Text = "ManageGenres";
            this.Load += new System.EventHandler(this.ManageGenres_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.genreTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesDBDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtGenreName;
        private System.Windows.Forms.DataGridView genreTable;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private MoviesDBDataSet3 moviesDBDataSet3;
        private System.Windows.Forms.BindingSource genresBindingSource;
        private MoviesDBDataSet3TableAdapters.GenresTableAdapter genresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label txtParentIdlabel;
        private System.Windows.Forms.RichTextBox txtParentId;
    }
}