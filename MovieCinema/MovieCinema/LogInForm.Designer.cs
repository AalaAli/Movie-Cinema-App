namespace MovieCinema
{
    partial class LogInForm
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
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.EmailTxt = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            this.LoginBtn = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.LoginBtn);
            this.kryptonPanel1.Controls.Add(this.kryptonTextBox1);
            this.kryptonPanel1.Controls.Add(this.EmailTxt);
            this.kryptonPanel1.Location = new System.Drawing.Point(-5, -2);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PaletteMode = Krypton.Toolkit.PaletteMode.MaterialDark;
            this.kryptonPanel1.Size = new System.Drawing.Size(804, 401);
            this.kryptonPanel1.TabIndex = 0;
            this.kryptonPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonPanel1_Paint);
            // 
            // EmailTxt
            // 
            this.EmailTxt.Location = new System.Drawing.Point(265, 138);
            this.EmailTxt.Name = "EmailTxt";
            this.EmailTxt.Size = new System.Drawing.Size(309, 44);
            this.EmailTxt.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EmailTxt.StateActive.Border.Color1 = System.Drawing.Color.WhiteSmoke;
            this.EmailTxt.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.EmailTxt.StateCommon.Border.Rounding = 20F;
            this.EmailTxt.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.EmailTxt.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5);
            this.EmailTxt.StateNormal.Border.Color1 = System.Drawing.Color.WhiteSmoke;
            this.EmailTxt.StateNormal.Border.Color2 = System.Drawing.Color.White;
            this.EmailTxt.StateNormal.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.EmailTxt.TabIndex = 0;
            this.EmailTxt.Text = "Enter Email...";
            this.EmailTxt.TextChanged += new System.EventHandler(this.kryptonTextBox1_TextChanged);
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.Location = new System.Drawing.Point(265, 223);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(309, 44);
            this.kryptonTextBox1.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonTextBox1.StateActive.Border.Color1 = System.Drawing.Color.WhiteSmoke;
            this.kryptonTextBox1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.kryptonTextBox1.StateCommon.Border.Rounding = 20F;
            this.kryptonTextBox1.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonTextBox1.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5);
            this.kryptonTextBox1.StateNormal.Border.Color1 = System.Drawing.Color.WhiteSmoke;
            this.kryptonTextBox1.StateNormal.Border.Color2 = System.Drawing.Color.White;
            this.kryptonTextBox1.StateNormal.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonTextBox1.TabIndex = 1;
            this.kryptonTextBox1.Text = "Enter Password...";
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(356, 302);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(125, 38);
            this.LoginBtn.StateCommon.Back.Color1 = System.Drawing.Color.Maroon;
            this.LoginBtn.StateCommon.Back.Color2 = System.Drawing.Color.DarkRed;
            this.LoginBtn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LoginBtn.StateCommon.Border.Color2 = System.Drawing.Color.Maroon;
            this.LoginBtn.StateCommon.Border.Rounding = 10F;
            this.LoginBtn.StateCommon.Content.Draw = Krypton.Toolkit.InheritBool.True;
            this.LoginBtn.StateCommon.Content.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LoginBtn.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.LoginBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.LoginBtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LoginBtn.StateNormal.Border.Rounding = 20F;
            this.LoginBtn.StateNormal.Border.Width = 1;
            this.LoginBtn.TabIndex = 2;
            this.LoginBtn.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.LoginBtn.Values.Text = "LogIn";
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "LogInForm";
            this.Text = "LogInForm";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.LogInForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Diagnostics.PerformanceCounter performanceCounter1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonTextBox EmailTxt;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Krypton.Toolkit.KryptonButton LoginBtn;
    }
}