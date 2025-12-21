namespace Ui
{
    partial class MoviesForm
    {
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.PictureBox picProfile;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutMovies;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.picProfile = new System.Windows.Forms.PictureBox();
            this.flowLayoutMovies = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.pnlHeader.Controls.Add(this.lblLogo);
            this.pnlHeader.Controls.Add(this.picProfile);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1006, 80);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.lblLogo.Location = new System.Drawing.Point(26, 22);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(268, 41);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "CINEMA LIBRARY";
            // 
            // picProfile
            // 
            this.picProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.picProfile.Location = new System.Drawing.Point(1767, 12);
            this.picProfile.Name = "picProfile";
            this.picProfile.Size = new System.Drawing.Size(48, 55);
            this.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProfile.TabIndex = 1;
            this.picProfile.TabStop = false;
            // 
            // flowLayoutMovies
            // 
            this.flowLayoutMovies.AutoScroll = true;
            this.flowLayoutMovies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.flowLayoutMovies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutMovies.Location = new System.Drawing.Point(0, 80);
            this.flowLayoutMovies.Name = "flowLayoutMovies";
            this.flowLayoutMovies.Padding = new System.Windows.Forms.Padding(31, 35, 31, 35);
            this.flowLayoutMovies.Size = new System.Drawing.Size(1006, 720);
            this.flowLayoutMovies.TabIndex = 0;
            // 
            // MoviesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1006, 800);
            this.Controls.Add(this.flowLayoutMovies);
            this.Controls.Add(this.pnlHeader);
            this.Name = "MoviesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cinema Library";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).EndInit();
            this.ResumeLayout(false);

        }
    }
}