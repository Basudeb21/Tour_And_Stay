namespace TourStay.FormScreens
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.header_pnl = new System.Windows.Forms.Panel();
            this.minimize_btn = new System.Windows.Forms.PictureBox();
            this.cross_btn = new System.Windows.Forms.PictureBox();
            this.header_pic = new System.Windows.Forms.PictureBox();
            this.footer_pnl = new System.Windows.Forms.Panel();
            this.footer_pic = new System.Windows.Forms.PictureBox();
            this.navbar_pnl = new System.Windows.Forms.Panel();
            this.logout_pnl = new System.Windows.Forms.Panel();
            this.logout_img_btn = new System.Windows.Forms.PictureBox();
            this.logout_lbl = new System.Windows.Forms.Label();
            this.booking_pnl = new System.Windows.Forms.Panel();
            this.booking_img_btn = new System.Windows.Forms.PictureBox();
            this.booking_lbl = new System.Windows.Forms.Label();
            this.notification_pnl = new System.Windows.Forms.Panel();
            this.notification_img_btn = new System.Windows.Forms.PictureBox();
            this.notification_lbl = new System.Windows.Forms.Label();
            this.profile_pnl = new System.Windows.Forms.Panel();
            this.profile_img_btn = new System.Windows.Forms.PictureBox();
            this.profile_lbl = new System.Windows.Forms.Label();
            this.sidenav_pic = new System.Windows.Forms.PictureBox();
            this.body_pnl = new System.Windows.Forms.Panel();
            this.header_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cross_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.header_pic)).BeginInit();
            this.footer_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.footer_pic)).BeginInit();
            this.navbar_pnl.SuspendLayout();
            this.logout_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logout_img_btn)).BeginInit();
            this.booking_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booking_img_btn)).BeginInit();
            this.notification_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notification_img_btn)).BeginInit();
            this.profile_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profile_img_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sidenav_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // header_pnl
            // 
            this.header_pnl.Controls.Add(this.minimize_btn);
            this.header_pnl.Controls.Add(this.cross_btn);
            this.header_pnl.Controls.Add(this.header_pic);
            this.header_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_pnl.Location = new System.Drawing.Point(0, 0);
            this.header_pnl.Name = "header_pnl";
            this.header_pnl.Size = new System.Drawing.Size(1300, 82);
            this.header_pnl.TabIndex = 0;
            // 
            // minimize_btn
            // 
            this.minimize_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(10)))), ((int)(((byte)(145)))));
            this.minimize_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize_btn.Image = ((System.Drawing.Image)(resources.GetObject("minimize_btn.Image")));
            this.minimize_btn.Location = new System.Drawing.Point(1205, 25);
            this.minimize_btn.Name = "minimize_btn";
            this.minimize_btn.Size = new System.Drawing.Size(25, 25);
            this.minimize_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimize_btn.TabIndex = 3;
            this.minimize_btn.TabStop = false;
            this.minimize_btn.Click += new System.EventHandler(this.minimize_btn_Click);
            // 
            // cross_btn
            // 
            this.cross_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cross_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(10)))), ((int)(((byte)(145)))));
            this.cross_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cross_btn.Image = ((System.Drawing.Image)(resources.GetObject("cross_btn.Image")));
            this.cross_btn.Location = new System.Drawing.Point(1265, 31);
            this.cross_btn.Name = "cross_btn";
            this.cross_btn.Size = new System.Drawing.Size(15, 15);
            this.cross_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cross_btn.TabIndex = 2;
            this.cross_btn.TabStop = false;
            this.cross_btn.Click += new System.EventHandler(this.cross_btn_Click);
            // 
            // header_pic
            // 
            this.header_pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.header_pic.Image = ((System.Drawing.Image)(resources.GetObject("header_pic.Image")));
            this.header_pic.Location = new System.Drawing.Point(0, 0);
            this.header_pic.Name = "header_pic";
            this.header_pic.Size = new System.Drawing.Size(1300, 82);
            this.header_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.header_pic.TabIndex = 0;
            this.header_pic.TabStop = false;
            // 
            // footer_pnl
            // 
            this.footer_pnl.Controls.Add(this.footer_pic);
            this.footer_pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer_pnl.Location = new System.Drawing.Point(0, 646);
            this.footer_pnl.Name = "footer_pnl";
            this.footer_pnl.Size = new System.Drawing.Size(1300, 54);
            this.footer_pnl.TabIndex = 1;
            // 
            // footer_pic
            // 
            this.footer_pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.footer_pic.Image = ((System.Drawing.Image)(resources.GetObject("footer_pic.Image")));
            this.footer_pic.Location = new System.Drawing.Point(0, 0);
            this.footer_pic.Name = "footer_pic";
            this.footer_pic.Size = new System.Drawing.Size(1300, 54);
            this.footer_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.footer_pic.TabIndex = 0;
            this.footer_pic.TabStop = false;
            // 
            // navbar_pnl
            // 
            this.navbar_pnl.Controls.Add(this.logout_pnl);
            this.navbar_pnl.Controls.Add(this.booking_pnl);
            this.navbar_pnl.Controls.Add(this.notification_pnl);
            this.navbar_pnl.Controls.Add(this.profile_pnl);
            this.navbar_pnl.Controls.Add(this.sidenav_pic);
            this.navbar_pnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.navbar_pnl.Location = new System.Drawing.Point(0, 82);
            this.navbar_pnl.Name = "navbar_pnl";
            this.navbar_pnl.Size = new System.Drawing.Size(195, 564);
            this.navbar_pnl.TabIndex = 2;
            // 
            // logout_pnl
            // 
            this.logout_pnl.BackColor = System.Drawing.Color.White;
            this.logout_pnl.Controls.Add(this.logout_img_btn);
            this.logout_pnl.Controls.Add(this.logout_lbl);
            this.logout_pnl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_pnl.Location = new System.Drawing.Point(1, 493);
            this.logout_pnl.Name = "logout_pnl";
            this.logout_pnl.Size = new System.Drawing.Size(195, 48);
            this.logout_pnl.TabIndex = 15;
            // 
            // logout_img_btn
            // 
            this.logout_img_btn.Image = ((System.Drawing.Image)(resources.GetObject("logout_img_btn.Image")));
            this.logout_img_btn.Location = new System.Drawing.Point(7, 6);
            this.logout_img_btn.Name = "logout_img_btn";
            this.logout_img_btn.Size = new System.Drawing.Size(39, 36);
            this.logout_img_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logout_img_btn.TabIndex = 1;
            this.logout_img_btn.TabStop = false;
            // 
            // logout_lbl
            // 
            this.logout_lbl.AutoSize = true;
            this.logout_lbl.BackColor = System.Drawing.Color.White;
            this.logout_lbl.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_lbl.Location = new System.Drawing.Point(58, 11);
            this.logout_lbl.Name = "logout_lbl";
            this.logout_lbl.Size = new System.Drawing.Size(76, 24);
            this.logout_lbl.TabIndex = 0;
            this.logout_lbl.Text = "Logout";
            this.logout_lbl.Click += new System.EventHandler(this.logout_lbl_Click);
            // 
            // booking_pnl
            // 
            this.booking_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(10)))), ((int)(((byte)(145)))));
            this.booking_pnl.Controls.Add(this.booking_img_btn);
            this.booking_pnl.Controls.Add(this.booking_lbl);
            this.booking_pnl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.booking_pnl.Location = new System.Drawing.Point(0, 259);
            this.booking_pnl.Name = "booking_pnl";
            this.booking_pnl.Size = new System.Drawing.Size(195, 48);
            this.booking_pnl.TabIndex = 14;
            // 
            // booking_img_btn
            // 
            this.booking_img_btn.Image = ((System.Drawing.Image)(resources.GetObject("booking_img_btn.Image")));
            this.booking_img_btn.Location = new System.Drawing.Point(7, 6);
            this.booking_img_btn.Name = "booking_img_btn";
            this.booking_img_btn.Size = new System.Drawing.Size(39, 36);
            this.booking_img_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.booking_img_btn.TabIndex = 1;
            this.booking_img_btn.TabStop = false;
            this.booking_img_btn.Click += new System.EventHandler(this.booking_img_btn_Click);
            // 
            // booking_lbl
            // 
            this.booking_lbl.AutoSize = true;
            this.booking_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(10)))), ((int)(((byte)(145)))));
            this.booking_lbl.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booking_lbl.ForeColor = System.Drawing.Color.White;
            this.booking_lbl.Location = new System.Drawing.Point(58, 11);
            this.booking_lbl.Name = "booking_lbl";
            this.booking_lbl.Size = new System.Drawing.Size(88, 24);
            this.booking_lbl.TabIndex = 0;
            this.booking_lbl.Text = "Booking";
            this.booking_lbl.Click += new System.EventHandler(this.booking_lbl_Click);
            // 
            // notification_pnl
            // 
            this.notification_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(10)))), ((int)(((byte)(145)))));
            this.notification_pnl.Controls.Add(this.notification_img_btn);
            this.notification_pnl.Controls.Add(this.notification_lbl);
            this.notification_pnl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.notification_pnl.Location = new System.Drawing.Point(0, 189);
            this.notification_pnl.Name = "notification_pnl";
            this.notification_pnl.Size = new System.Drawing.Size(195, 48);
            this.notification_pnl.TabIndex = 13;
            // 
            // notification_img_btn
            // 
            this.notification_img_btn.Image = ((System.Drawing.Image)(resources.GetObject("notification_img_btn.Image")));
            this.notification_img_btn.Location = new System.Drawing.Point(7, 6);
            this.notification_img_btn.Name = "notification_img_btn";
            this.notification_img_btn.Size = new System.Drawing.Size(39, 36);
            this.notification_img_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.notification_img_btn.TabIndex = 1;
            this.notification_img_btn.TabStop = false;
            this.notification_img_btn.Click += new System.EventHandler(this.notification_img_btn_Click);
            // 
            // notification_lbl
            // 
            this.notification_lbl.AutoSize = true;
            this.notification_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(10)))), ((int)(((byte)(145)))));
            this.notification_lbl.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notification_lbl.ForeColor = System.Drawing.Color.White;
            this.notification_lbl.Location = new System.Drawing.Point(58, 11);
            this.notification_lbl.Name = "notification_lbl";
            this.notification_lbl.Size = new System.Drawing.Size(125, 24);
            this.notification_lbl.TabIndex = 0;
            this.notification_lbl.Text = "Notification";
            this.notification_lbl.Click += new System.EventHandler(this.notification_lbl_Click);
            // 
            // profile_pnl
            // 
            this.profile_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(10)))), ((int)(((byte)(145)))));
            this.profile_pnl.Controls.Add(this.profile_img_btn);
            this.profile_pnl.Controls.Add(this.profile_lbl);
            this.profile_pnl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profile_pnl.Location = new System.Drawing.Point(0, 115);
            this.profile_pnl.Name = "profile_pnl";
            this.profile_pnl.Size = new System.Drawing.Size(195, 48);
            this.profile_pnl.TabIndex = 12;
            // 
            // profile_img_btn
            // 
            this.profile_img_btn.Image = ((System.Drawing.Image)(resources.GetObject("profile_img_btn.Image")));
            this.profile_img_btn.Location = new System.Drawing.Point(7, 6);
            this.profile_img_btn.Name = "profile_img_btn";
            this.profile_img_btn.Size = new System.Drawing.Size(39, 36);
            this.profile_img_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profile_img_btn.TabIndex = 1;
            this.profile_img_btn.TabStop = false;
            this.profile_img_btn.Click += new System.EventHandler(this.profile_img_btn_Click);
            // 
            // profile_lbl
            // 
            this.profile_lbl.AutoSize = true;
            this.profile_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(10)))), ((int)(((byte)(145)))));
            this.profile_lbl.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profile_lbl.ForeColor = System.Drawing.Color.White;
            this.profile_lbl.Location = new System.Drawing.Point(58, 11);
            this.profile_lbl.Name = "profile_lbl";
            this.profile_lbl.Size = new System.Drawing.Size(73, 24);
            this.profile_lbl.TabIndex = 0;
            this.profile_lbl.Text = "Profile";
            this.profile_lbl.Click += new System.EventHandler(this.profile_lbl_Click);
            // 
            // sidenav_pic
            // 
            this.sidenav_pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidenav_pic.Image = ((System.Drawing.Image)(resources.GetObject("sidenav_pic.Image")));
            this.sidenav_pic.Location = new System.Drawing.Point(0, 0);
            this.sidenav_pic.Name = "sidenav_pic";
            this.sidenav_pic.Size = new System.Drawing.Size(195, 564);
            this.sidenav_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sidenav_pic.TabIndex = 0;
            this.sidenav_pic.TabStop = false;
            // 
            // body_pnl
            // 
            this.body_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.body_pnl.Location = new System.Drawing.Point(195, 82);
            this.body_pnl.Name = "body_pnl";
            this.body_pnl.Size = new System.Drawing.Size(1105, 564);
            this.body_pnl.TabIndex = 3;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.body_pnl);
            this.Controls.Add(this.navbar_pnl);
            this.Controls.Add(this.footer_pnl);
            this.Controls.Add(this.header_pnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserForm";
            this.header_pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minimize_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cross_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.header_pic)).EndInit();
            this.footer_pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.footer_pic)).EndInit();
            this.navbar_pnl.ResumeLayout(false);
            this.logout_pnl.ResumeLayout(false);
            this.logout_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logout_img_btn)).EndInit();
            this.booking_pnl.ResumeLayout(false);
            this.booking_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booking_img_btn)).EndInit();
            this.notification_pnl.ResumeLayout(false);
            this.notification_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notification_img_btn)).EndInit();
            this.profile_pnl.ResumeLayout(false);
            this.profile_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profile_img_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sidenav_pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header_pnl;
        private System.Windows.Forms.Panel footer_pnl;
        private System.Windows.Forms.Panel navbar_pnl;
        private System.Windows.Forms.Panel body_pnl;
        private System.Windows.Forms.PictureBox header_pic;
        private System.Windows.Forms.PictureBox footer_pic;
        private System.Windows.Forms.PictureBox sidenav_pic;
        private System.Windows.Forms.PictureBox minimize_btn;
        private System.Windows.Forms.PictureBox cross_btn;
        private System.Windows.Forms.Panel profile_pnl;
        private System.Windows.Forms.PictureBox profile_img_btn;
        private System.Windows.Forms.Label profile_lbl;
        private System.Windows.Forms.Panel notification_pnl;
        private System.Windows.Forms.PictureBox notification_img_btn;
        private System.Windows.Forms.Label notification_lbl;
        private System.Windows.Forms.Panel booking_pnl;
        private System.Windows.Forms.PictureBox booking_img_btn;
        private System.Windows.Forms.Label booking_lbl;
        private System.Windows.Forms.Panel logout_pnl;
        private System.Windows.Forms.PictureBox logout_img_btn;
        private System.Windows.Forms.Label logout_lbl;
    }
}