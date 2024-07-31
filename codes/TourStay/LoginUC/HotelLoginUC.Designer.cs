namespace TourStay.LoginUC
{
    partial class HotelLoginUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HotelLoginUC));
            this.body_pnl = new System.Windows.Forms.Panel();
            this.minimize_btn = new System.Windows.Forms.PictureBox();
            this.exit_btn = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.login_btn = new TourStay.CustomResources.RoundButton();
            this.pass_inp = new System.Windows.Forms.TextBox();
            this.pass_lbl = new System.Windows.Forms.Label();
            this.hid_inp = new System.Windows.Forms.TextBox();
            this.mob_no = new System.Windows.Forms.Label();
            this.hotel_img = new System.Windows.Forms.PictureBox();
            this.body_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_img)).BeginInit();
            this.SuspendLayout();
            // 
            // body_pnl
            // 
            this.body_pnl.Controls.Add(this.minimize_btn);
            this.body_pnl.Controls.Add(this.exit_btn);
            this.body_pnl.Controls.Add(this.pictureBox1);
            this.body_pnl.Controls.Add(this.login_btn);
            this.body_pnl.Controls.Add(this.pass_inp);
            this.body_pnl.Controls.Add(this.pass_lbl);
            this.body_pnl.Controls.Add(this.hid_inp);
            this.body_pnl.Controls.Add(this.mob_no);
            this.body_pnl.Controls.Add(this.hotel_img);
            this.body_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.body_pnl.Location = new System.Drawing.Point(0, 0);
            this.body_pnl.Name = "body_pnl";
            this.body_pnl.Size = new System.Drawing.Size(900, 600);
            this.body_pnl.TabIndex = 0;
            // 
            // minimize_btn
            // 
            this.minimize_btn.BackColor = System.Drawing.Color.White;
            this.minimize_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize_btn.Image = ((System.Drawing.Image)(resources.GetObject("minimize_btn.Image")));
            this.minimize_btn.Location = new System.Drawing.Point(830, 11);
            this.minimize_btn.Name = "minimize_btn";
            this.minimize_btn.Size = new System.Drawing.Size(20, 20);
            this.minimize_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimize_btn.TabIndex = 30;
            this.minimize_btn.TabStop = false;
            this.minimize_btn.Click += new System.EventHandler(this.minimize_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.White;
            this.exit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_btn.Image = ((System.Drawing.Image)(resources.GetObject("exit_btn.Image")));
            this.exit_btn.Location = new System.Drawing.Point(875, 17);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(10, 10);
            this.exit_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exit_btn.TabIndex = 29;
            this.exit_btn.TabStop = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(825, 540);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(247)))), ((int)(((byte)(129)))));
            this.login_btn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(247)))), ((int)(((byte)(129)))));
            this.login_btn.BorderColor = System.Drawing.Color.Black;
            this.login_btn.BorderRadius = 15;
            this.login_btn.BorderSize = 0;
            this.login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_btn.FlatAppearance.BorderSize = 0;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.Color.White;
            this.login_btn.Location = new System.Drawing.Point(464, 399);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(355, 45);
            this.login_btn.TabIndex = 26;
            this.login_btn.Text = "LOGIN";
            this.login_btn.TextColor = System.Drawing.Color.White;
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // pass_inp
            // 
            this.pass_inp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pass_inp.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_inp.Location = new System.Drawing.Point(464, 325);
            this.pass_inp.Name = "pass_inp";
            this.pass_inp.PasswordChar = '*';
            this.pass_inp.Size = new System.Drawing.Size(355, 31);
            this.pass_inp.TabIndex = 25;
            // 
            // pass_lbl
            // 
            this.pass_lbl.AutoSize = true;
            this.pass_lbl.BackColor = System.Drawing.Color.White;
            this.pass_lbl.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_lbl.ForeColor = System.Drawing.Color.Gray;
            this.pass_lbl.Location = new System.Drawing.Point(460, 287);
            this.pass_lbl.Name = "pass_lbl";
            this.pass_lbl.Size = new System.Drawing.Size(219, 23);
            this.pass_lbl.TabIndex = 24;
            this.pass_lbl.Text = "Enter your password";
            this.pass_lbl.Click += new System.EventHandler(this.pass_lbl_Click);
            // 
            // hid_inp
            // 
            this.hid_inp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hid_inp.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hid_inp.Location = new System.Drawing.Point(464, 221);
            this.hid_inp.Name = "hid_inp";
            this.hid_inp.Size = new System.Drawing.Size(355, 31);
            this.hid_inp.TabIndex = 23;
            // 
            // mob_no
            // 
            this.mob_no.AutoSize = true;
            this.mob_no.BackColor = System.Drawing.Color.White;
            this.mob_no.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mob_no.ForeColor = System.Drawing.Color.Gray;
            this.mob_no.Location = new System.Drawing.Point(460, 183);
            this.mob_no.Name = "mob_no";
            this.mob_no.Size = new System.Drawing.Size(219, 23);
            this.mob_no.TabIndex = 22;
            this.mob_no.Text = "Enter your hotel id";
            this.mob_no.Click += new System.EventHandler(this.mob_no_Click);
            // 
            // hotel_img
            // 
            this.hotel_img.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hotel_img.Image = ((System.Drawing.Image)(resources.GetObject("hotel_img.Image")));
            this.hotel_img.Location = new System.Drawing.Point(0, 0);
            this.hotel_img.Name = "hotel_img";
            this.hotel_img.Size = new System.Drawing.Size(900, 600);
            this.hotel_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hotel_img.TabIndex = 0;
            this.hotel_img.TabStop = false;
            // 
            // HotelLoginUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.body_pnl);
            this.Name = "HotelLoginUC";
            this.Size = new System.Drawing.Size(900, 600);
            this.body_pnl.ResumeLayout(false);
            this.body_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel body_pnl;
        private System.Windows.Forms.PictureBox hotel_img;
        private System.Windows.Forms.PictureBox minimize_btn;
        private System.Windows.Forms.PictureBox exit_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomResources.RoundButton login_btn;
        private System.Windows.Forms.TextBox pass_inp;
        private System.Windows.Forms.Label pass_lbl;
        private System.Windows.Forms.TextBox hid_inp;
        private System.Windows.Forms.Label mob_no;
    }
}
