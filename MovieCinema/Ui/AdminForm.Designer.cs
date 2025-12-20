namespace Ui
{
    partial class AdminForm
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
            this.panelContainer = new System.Windows.Forms.Panel();
            this.btnManageGenre = new System.Windows.Forms.Button();
            this.lblAdminInfo = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnManageShowTimes = new System.Windows.Forms.Button();
            this.btnManageMovies = new System.Windows.Forms.Button();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.panelContainer.Controls.Add(this.btnManageGenre);
            this.panelContainer.Controls.Add(this.lblAdminInfo);
            this.panelContainer.Controls.Add(this.lblSubtitle);
            this.panelContainer.Controls.Add(this.lblTitle);
            this.panelContainer.Controls.Add(this.btnManageShowTimes);
            this.panelContainer.Controls.Add(this.btnManageMovies);
            this.panelContainer.Location = new System.Drawing.Point(150, 50);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Padding = new System.Windows.Forms.Padding(20);
            this.panelContainer.Size = new System.Drawing.Size(500, 450);
            this.panelContainer.TabIndex = 0;
            // 
            // btnManageGenre
            // 
            this.btnManageGenre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnManageGenre.FlatAppearance.BorderSize = 0;
            this.btnManageGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageGenre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnManageGenre.ForeColor = System.Drawing.Color.White;
            this.btnManageGenre.Location = new System.Drawing.Point(50, 326);
            this.btnManageGenre.Name = "btnManageGenre";
            this.btnManageGenre.Size = new System.Drawing.Size(400, 60);
            this.btnManageGenre.TabIndex = 6;
            this.btnManageGenre.Text = "MANAGE GENRES";
            this.btnManageGenre.UseVisualStyleBackColor = false;
            this.btnManageGenre.Click += new System.EventHandler(this.btnManageGenre_Click);
            // 
            // lblAdminInfo
            // 
            this.lblAdminInfo.AutoSize = true;
            this.lblAdminInfo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAdminInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.lblAdminInfo.Location = new System.Drawing.Point(122, 407);
            this.lblAdminInfo.Name = "lblAdminInfo";
            this.lblAdminInfo.Size = new System.Drawing.Size(232, 23);
            this.lblAdminInfo.TabIndex = 5;
            this.lblAdminInfo.Text = "Welcome, Administrator User";
            this.lblAdminInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.lblSubtitle.Location = new System.Drawing.Point(88, 79);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(319, 25);
            this.lblSubtitle.TabIndex = 4;
            this.lblSubtitle.Text = "Manage Your Cinema Library System";
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.lblTitle.Location = new System.Drawing.Point(60, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(390, 50);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "ADMIN DASHBOARD";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnManageShowTimes
            // 
            this.btnManageShowTimes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnManageShowTimes.FlatAppearance.BorderSize = 0;
            this.btnManageShowTimes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageShowTimes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnManageShowTimes.ForeColor = System.Drawing.Color.White;
            this.btnManageShowTimes.Location = new System.Drawing.Point(50, 238);
            this.btnManageShowTimes.Name = "btnManageShowTimes";
            this.btnManageShowTimes.Size = new System.Drawing.Size(400, 60);
            this.btnManageShowTimes.TabIndex = 1;
            this.btnManageShowTimes.Text = "MANAGE SHOWTIMES";
            this.btnManageShowTimes.UseVisualStyleBackColor = false;
            this.btnManageShowTimes.Click += new System.EventHandler(this.btnManageShowTimes_Click);
            // 
            // btnManageMovies
            // 
            this.btnManageMovies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(123)))), ((int)(((byte)(222)))));
            this.btnManageMovies.FlatAppearance.BorderSize = 0;
            this.btnManageMovies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageMovies.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnManageMovies.ForeColor = System.Drawing.Color.White;
            this.btnManageMovies.Location = new System.Drawing.Point(50, 150);
            this.btnManageMovies.Name = "btnManageMovies";
            this.btnManageMovies.Size = new System.Drawing.Size(400, 60);
            this.btnManageMovies.TabIndex = 0;
            this.btnManageMovies.Text = "MANAGE MOVIES";
            this.btnManageMovies.UseVisualStyleBackColor = false;
            this.btnManageMovies.Click += new System.EventHandler(this.btnManageMovies_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.panelContainer);
            this.Font = new System.Drawing.Font("Tahoma", 8F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cinema Library - Admin";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button btnManageShowTimes;
        private System.Windows.Forms.Button btnManageMovies;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAdminInfo;
        private System.Windows.Forms.Button btnManageGenre;
    }
}