namespace TourStay.LoginUC
{
    partial class SplashUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashUC));
            this.splash_pnl = new System.Windows.Forms.Panel();
            this.splash_img = new System.Windows.Forms.PictureBox();
            this.splash_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splash_img)).BeginInit();
            this.SuspendLayout();
            // 
            // splash_pnl
            // 
            this.splash_pnl.Controls.Add(this.splash_img);
            this.splash_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splash_pnl.Location = new System.Drawing.Point(0, 0);
            this.splash_pnl.Name = "splash_pnl";
            this.splash_pnl.Size = new System.Drawing.Size(1000, 600);
            this.splash_pnl.TabIndex = 0;
            // 
            // splash_img
            // 
            this.splash_img.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splash_img.Image = ((System.Drawing.Image)(resources.GetObject("splash_img.Image")));
            this.splash_img.Location = new System.Drawing.Point(0, 0);
            this.splash_img.Name = "splash_img";
            this.splash_img.Size = new System.Drawing.Size(1000, 600);
            this.splash_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.splash_img.TabIndex = 0;
            this.splash_img.TabStop = false;
            // 
            // SplashUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splash_pnl);
            this.Name = "SplashUC";
            this.Size = new System.Drawing.Size(1000, 600);
            this.splash_pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splash_img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel splash_pnl;
        private System.Windows.Forms.PictureBox splash_img;
    }
}
