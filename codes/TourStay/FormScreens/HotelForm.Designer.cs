namespace TourStay.FormScreens
{
    partial class HotelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HotelForm));
            this.head_pnl = new System.Windows.Forms.Panel();
            this.minimize_btn = new System.Windows.Forms.PictureBox();
            this.cross_btn = new System.Windows.Forms.PictureBox();
            this.head_img = new System.Windows.Forms.PictureBox();
            this.footer_pnl = new System.Windows.Forms.Panel();
            this.footer_img = new System.Windows.Forms.PictureBox();
            this.nav_pnl = new System.Windows.Forms.Panel();
            this.logout_pnl = new System.Windows.Forms.Panel();
            this.logout_img_btn = new System.Windows.Forms.PictureBox();
            this.logout_lbl = new System.Windows.Forms.Label();
            this.notification_pnl = new System.Windows.Forms.Panel();
            this.notification_img_btn = new System.Windows.Forms.PictureBox();
            this.notification_lbl = new System.Windows.Forms.Label();
            this.update_btn_pnl = new System.Windows.Forms.Panel();
            this.update_img_btn = new System.Windows.Forms.PictureBox();
            this.update_lbl = new System.Windows.Forms.Label();
            this.profile_btn_pnl = new System.Windows.Forms.Panel();
            this.profile_img_btn = new System.Windows.Forms.PictureBox();
            this.profile_lbl = new System.Windows.Forms.Label();
            this.nav_img = new System.Windows.Forms.PictureBox();
            this.body_pnl = new System.Windows.Forms.Panel();
            this.head_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cross_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.head_img)).BeginInit();
            this.footer_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.footer_img)).BeginInit();
            this.nav_pnl.SuspendLayout();
            this.logout_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logout_img_btn)).BeginInit();
            this.notification_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notification_img_btn)).BeginInit();
            this.update_btn_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.update_img_btn)).BeginInit();
            this.profile_btn_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profile_img_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nav_img)).BeginInit();
            this.SuspendLayout();
            // 
            // head_pnl
            // 
            this.head_pnl.Controls.Add(this.minimize_btn);
            this.head_pnl.Controls.Add(this.cross_btn);
            this.head_pnl.Controls.Add(this.head_img);
            this.head_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.head_pnl.Location = new System.Drawing.Point(0, 0);
            this.head_pnl.Name = "head_pnl";
            this.head_pnl.Size = new System.Drawing.Size(1300, 82);
            this.head_pnl.TabIndex = 0;
            // 
            // minimize_btn
            // 
            this.minimize_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(176)))), ((int)(((byte)(30)))));
            this.minimize_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize_btn.Image = ((System.Drawing.Image)(resources.GetObject("minimize_btn.Image")));
            this.minimize_btn.Location = new System.Drawing.Point(1192, 29);
            this.minimize_btn.Name = "minimize_btn";
            this.minimize_btn.Size = new System.Drawing.Size(25, 25);
            this.minimize_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimize_btn.TabIndex = 1;
            this.minimize_btn.TabStop = false;
            this.minimize_btn.Click += new System.EventHandler(this.minimize_btn_Click);
            // 
            // cross_btn
            // 
            this.cross_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cross_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(176)))), ((int)(((byte)(30)))));
            this.cross_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cross_btn.Image = ((System.Drawing.Image)(resources.GetObject("cross_btn.Image")));
            this.cross_btn.Location = new System.Drawing.Point(1252, 35);
            this.cross_btn.Name = "cross_btn";
            this.cross_btn.Size = new System.Drawing.Size(15, 15);
            this.cross_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cross_btn.TabIndex = 0;
            this.cross_btn.TabStop = false;
            this.cross_btn.Click += new System.EventHandler(this.cross_btn_Click);
            // 
            // head_img
            // 
            this.head_img.Dock = System.Windows.Forms.DockStyle.Fill;
            this.head_img.Image = ((System.Drawing.Image)(resources.GetObject("head_img.Image")));
            this.head_img.Location = new System.Drawing.Point(0, 0);
            this.head_img.Name = "head_img";
            this.head_img.Size = new System.Drawing.Size(1300, 82);
            this.head_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.head_img.TabIndex = 0;
            this.head_img.TabStop = false;
            // 
            // footer_pnl
            // 
            this.footer_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(10)))), ((int)(((byte)(145)))));
            this.footer_pnl.Controls.Add(this.footer_img);
            this.footer_pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer_pnl.Location = new System.Drawing.Point(0, 646);
            this.footer_pnl.Name = "footer_pnl";
            this.footer_pnl.Size = new System.Drawing.Size(1300, 54);
            this.footer_pnl.TabIndex = 1;
            // 
            // footer_img
            // 
            this.footer_img.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(10)))), ((int)(((byte)(145)))));
            this.footer_img.Dock = System.Windows.Forms.DockStyle.Fill;
            this.footer_img.Image = ((System.Drawing.Image)(resources.GetObject("footer_img.Image")));
            this.footer_img.Location = new System.Drawing.Point(0, 0);
            this.footer_img.Name = "footer_img";
            this.footer_img.Size = new System.Drawing.Size(1300, 54);
            this.footer_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.footer_img.TabIndex = 0;
            this.footer_img.TabStop = false;
            // 
            // nav_pnl
            // 
            this.nav_pnl.Controls.Add(this.logout_pnl);
            this.nav_pnl.Controls.Add(this.notification_pnl);
            this.nav_pnl.Controls.Add(this.update_btn_pnl);
            this.nav_pnl.Controls.Add(this.profile_btn_pnl);
            this.nav_pnl.Controls.Add(this.nav_img);
            this.nav_pnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.nav_pnl.Location = new System.Drawing.Point(0, 82);
            this.nav_pnl.Name = "nav_pnl";
            this.nav_pnl.Size = new System.Drawing.Size(195, 564);
            this.nav_pnl.TabIndex = 2;
            // 
            // logout_pnl
            // 
            this.logout_pnl.BackColor = System.Drawing.Color.White;
            this.logout_pnl.Controls.Add(this.logout_img_btn);
            this.logout_pnl.Controls.Add(this.logout_lbl);
            this.logout_pnl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_pnl.Location = new System.Drawing.Point(0, 495);
            this.logout_pnl.Name = "logout_pnl";
            this.logout_pnl.Size = new System.Drawing.Size(195, 48);
            this.logout_pnl.TabIndex = 12;
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
            // notification_pnl
            // 
            this.notification_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(189)))), ((int)(((byte)(30)))));
            this.notification_pnl.Controls.Add(this.notification_img_btn);
            this.notification_pnl.Controls.Add(this.notification_lbl);
            this.notification_pnl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.notification_pnl.Location = new System.Drawing.Point(0, 259);
            this.notification_pnl.Name = "notification_pnl";
            this.notification_pnl.Size = new System.Drawing.Size(195, 48);
            this.notification_pnl.TabIndex = 10;
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
            this.notification_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(189)))), ((int)(((byte)(30)))));
            this.notification_lbl.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notification_lbl.Location = new System.Drawing.Point(58, 11);
            this.notification_lbl.Name = "notification_lbl";
            this.notification_lbl.Size = new System.Drawing.Size(125, 24);
            this.notification_lbl.TabIndex = 0;
            this.notification_lbl.Text = "Notification";
            this.notification_lbl.Click += new System.EventHandler(this.notification_lbl_Click);
            // 
            // update_btn_pnl
            // 
            this.update_btn_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(189)))), ((int)(((byte)(30)))));
            this.update_btn_pnl.Controls.Add(this.update_img_btn);
            this.update_btn_pnl.Controls.Add(this.update_lbl);
            this.update_btn_pnl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update_btn_pnl.Location = new System.Drawing.Point(1, 189);
            this.update_btn_pnl.Name = "update_btn_pnl";
            this.update_btn_pnl.Size = new System.Drawing.Size(194, 48);
            this.update_btn_pnl.TabIndex = 9;
            // 
            // update_img_btn
            // 
            this.update_img_btn.Image = ((System.Drawing.Image)(resources.GetObject("update_img_btn.Image")));
            this.update_img_btn.Location = new System.Drawing.Point(7, 6);
            this.update_img_btn.Name = "update_img_btn";
            this.update_img_btn.Size = new System.Drawing.Size(39, 36);
            this.update_img_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.update_img_btn.TabIndex = 1;
            this.update_img_btn.TabStop = false;
            this.update_img_btn.Click += new System.EventHandler(this.update_img_btn_Click);
            // 
            // update_lbl
            // 
            this.update_lbl.AutoSize = true;
            this.update_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(189)))), ((int)(((byte)(30)))));
            this.update_lbl.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_lbl.Location = new System.Drawing.Point(57, 12);
            this.update_lbl.Name = "update_lbl";
            this.update_lbl.Size = new System.Drawing.Size(78, 24);
            this.update_lbl.TabIndex = 0;
            this.update_lbl.Text = "Update";
            this.update_lbl.Click += new System.EventHandler(this.update_lbl_Click);
            // 
            // profile_btn_pnl
            // 
            this.profile_btn_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(189)))), ((int)(((byte)(30)))));
            this.profile_btn_pnl.Controls.Add(this.profile_img_btn);
            this.profile_btn_pnl.Controls.Add(this.profile_lbl);
            this.profile_btn_pnl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profile_btn_pnl.Location = new System.Drawing.Point(1, 115);
            this.profile_btn_pnl.Name = "profile_btn_pnl";
            this.profile_btn_pnl.Size = new System.Drawing.Size(194, 48);
            this.profile_btn_pnl.TabIndex = 7;
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
            this.profile_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(189)))), ((int)(((byte)(30)))));
            this.profile_lbl.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profile_lbl.Location = new System.Drawing.Point(57, 12);
            this.profile_lbl.Name = "profile_lbl";
            this.profile_lbl.Size = new System.Drawing.Size(73, 24);
            this.profile_lbl.TabIndex = 0;
            this.profile_lbl.Text = "Profile";
            this.profile_lbl.Click += new System.EventHandler(this.profile_lbl_Click);
            // 
            // nav_img
            // 
            this.nav_img.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nav_img.Image = ((System.Drawing.Image)(resources.GetObject("nav_img.Image")));
            this.nav_img.Location = new System.Drawing.Point(0, 0);
            this.nav_img.Name = "nav_img";
            this.nav_img.Size = new System.Drawing.Size(195, 564);
            this.nav_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nav_img.TabIndex = 8;
            this.nav_img.TabStop = false;
            // 
            // body_pnl
            // 
            this.body_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.body_pnl.Location = new System.Drawing.Point(195, 82);
            this.body_pnl.Name = "body_pnl";
            this.body_pnl.Size = new System.Drawing.Size(1105, 564);
            this.body_pnl.TabIndex = 3;
            // 
            // HotelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.body_pnl);
            this.Controls.Add(this.nav_pnl);
            this.Controls.Add(this.footer_pnl);
            this.Controls.Add(this.head_pnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HotelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HotelForm";
            this.head_pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minimize_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cross_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.head_img)).EndInit();
            this.footer_pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.footer_img)).EndInit();
            this.nav_pnl.ResumeLayout(false);
            this.logout_pnl.ResumeLayout(false);
            this.logout_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logout_img_btn)).EndInit();
            this.notification_pnl.ResumeLayout(false);
            this.notification_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notification_img_btn)).EndInit();
            this.update_btn_pnl.ResumeLayout(false);
            this.update_btn_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.update_img_btn)).EndInit();
            this.profile_btn_pnl.ResumeLayout(false);
            this.profile_btn_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profile_img_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nav_img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel head_pnl;
        private System.Windows.Forms.Panel footer_pnl;
        private System.Windows.Forms.Panel nav_pnl;
        private System.Windows.Forms.Panel body_pnl;
        private System.Windows.Forms.PictureBox head_img;
        private System.Windows.Forms.PictureBox footer_img;
        private System.Windows.Forms.PictureBox cross_btn;
        private System.Windows.Forms.PictureBox minimize_btn;
        private System.Windows.Forms.Panel notification_pnl;
        private System.Windows.Forms.PictureBox notification_img_btn;
        private System.Windows.Forms.Label notification_lbl;
        private System.Windows.Forms.Panel update_btn_pnl;
        private System.Windows.Forms.PictureBox update_img_btn;
        private System.Windows.Forms.Label update_lbl;
        private System.Windows.Forms.Panel profile_btn_pnl;
        private System.Windows.Forms.PictureBox profile_img_btn;
        private System.Windows.Forms.Label profile_lbl;
        private System.Windows.Forms.PictureBox nav_img;
        private System.Windows.Forms.Panel logout_pnl;
        private System.Windows.Forms.PictureBox logout_img_btn;
        private System.Windows.Forms.Label logout_lbl;
    }
}