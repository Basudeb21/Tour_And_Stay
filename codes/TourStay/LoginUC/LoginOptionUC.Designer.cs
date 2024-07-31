namespace TourStay.LoginUC
{
    partial class LoginOptionUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginOptionUC));
            this.body_img = new System.Windows.Forms.PictureBox();
            this.body_pnl = new System.Windows.Forms.Panel();
            this.user_login_btn = new System.Windows.Forms.Label();
            this.hotel_login_link = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.body_img)).BeginInit();
            this.body_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // body_img
            // 
            this.body_img.Dock = System.Windows.Forms.DockStyle.Fill;
            this.body_img.Image = ((System.Drawing.Image)(resources.GetObject("body_img.Image")));
            this.body_img.Location = new System.Drawing.Point(0, 0);
            this.body_img.Name = "body_img";
            this.body_img.Size = new System.Drawing.Size(900, 600);
            this.body_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.body_img.TabIndex = 0;
            this.body_img.TabStop = false;
            // 
            // body_pnl
            // 
            this.body_pnl.Controls.Add(this.user_login_btn);
            this.body_pnl.Controls.Add(this.hotel_login_link);
            this.body_pnl.Controls.Add(this.body_img);
            this.body_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.body_pnl.Location = new System.Drawing.Point(0, 0);
            this.body_pnl.Name = "body_pnl";
            this.body_pnl.Size = new System.Drawing.Size(900, 600);
            this.body_pnl.TabIndex = 1;
            // 
            // user_login_btn
            // 
            this.user_login_btn.AutoSize = true;
            this.user_login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(189)))), ((int)(((byte)(30)))));
            this.user_login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.user_login_btn.Font = new System.Drawing.Font("Consolas", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_login_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.user_login_btn.Location = new System.Drawing.Point(481, 277);
            this.user_login_btn.Name = "user_login_btn";
            this.user_login_btn.Size = new System.Drawing.Size(165, 33);
            this.user_login_btn.TabIndex = 2;
            this.user_login_btn.Text = "User Login";
            this.user_login_btn.Click += new System.EventHandler(this.user_login_btn_Click);
            // 
            // hotel_login_link
            // 
            this.hotel_login_link.AutoSize = true;
            this.hotel_login_link.BackColor = System.Drawing.Color.White;
            this.hotel_login_link.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hotel_login_link.Font = new System.Drawing.Font("Consolas", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotel_login_link.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.hotel_login_link.Location = new System.Drawing.Point(230, 277);
            this.hotel_login_link.Name = "hotel_login_link";
            this.hotel_login_link.Size = new System.Drawing.Size(180, 33);
            this.hotel_login_link.TabIndex = 1;
            this.hotel_login_link.Text = "Hotel Login";
            this.hotel_login_link.Click += new System.EventHandler(this.hotel_login_link_Click);
            // 
            // LoginOptionUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.body_pnl);
            this.Name = "LoginOptionUC";
            this.Size = new System.Drawing.Size(900, 600);
            ((System.ComponentModel.ISupportInitialize)(this.body_img)).EndInit();
            this.body_pnl.ResumeLayout(false);
            this.body_pnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox body_img;
        private System.Windows.Forms.Panel body_pnl;
        private System.Windows.Forms.Label hotel_login_link;
        private System.Windows.Forms.Label user_login_btn;
    }
}
