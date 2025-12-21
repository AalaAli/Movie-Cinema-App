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

            // pnlHeader
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(22, 22, 30);
            this.pnlHeader.Controls.Add(this.lblLogo);
            this.pnlHeader.Controls.Add(this.picProfile);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 80;

            // lblLogo
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(255, 193, 7);
            this.lblLogo.Location = new System.Drawing.Point(30, 22);
            this.lblLogo.Text = "CINEMA LIBRARY";

            this.picProfile.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
            this.picProfile.BackColor = System.Drawing.Color.FromArgb(45, 45, 55);
            this.picProfile.Location = new System.Drawing.Point(1070, 12);
            this.picProfile.Size = new System.Drawing.Size(55, 55);
            this.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            // flowLayoutMovies
            this.flowLayoutMovies.AutoScroll = true;
            this.flowLayoutMovies.BackColor = System.Drawing.Color.FromArgb(15, 15, 20);
            this.flowLayoutMovies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutMovies.Padding = new System.Windows.Forms.Padding(35);

            // MoviesForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(15, 15, 20);
            this.ClientSize = new System.Drawing.Size(1150, 800);
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