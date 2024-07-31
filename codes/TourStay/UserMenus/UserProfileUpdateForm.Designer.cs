namespace TourStay.UserMenus
{
    partial class UserProfileUpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserProfileUpdateForm));
            this.body_pnl = new System.Windows.Forms.Panel();
            this.browse_btn = new System.Windows.Forms.Button();
            this.update_btn = new TourStay.CustomResources.RoundButton();
            this.path_inp = new System.Windows.Forms.TextBox();
            this.profile_pic = new TourStay.CustomResources.RoundImg();
            this.email_inp = new System.Windows.Forms.TextBox();
            this.email_lbl = new System.Windows.Forms.Label();
            this.pass_inp = new System.Windows.Forms.TextBox();
            this.pass_lbl = new System.Windows.Forms.Label();
            this.mob_inp = new System.Windows.Forms.TextBox();
            this.mob_lbl = new System.Windows.Forms.Label();
            this.user_inp = new System.Windows.Forms.TextBox();
            this.username_lbl = new System.Windows.Forms.Label();
            this.profile_update_img = new System.Windows.Forms.PictureBox();
            this.body_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profile_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profile_update_img)).BeginInit();
            this.SuspendLayout();
            // 
            // body_pnl
            // 
            this.body_pnl.Controls.Add(this.browse_btn);
            this.body_pnl.Controls.Add(this.update_btn);
            this.body_pnl.Controls.Add(this.path_inp);
            this.body_pnl.Controls.Add(this.profile_pic);
            this.body_pnl.Controls.Add(this.email_inp);
            this.body_pnl.Controls.Add(this.email_lbl);
            this.body_pnl.Controls.Add(this.pass_inp);
            this.body_pnl.Controls.Add(this.pass_lbl);
            this.body_pnl.Controls.Add(this.mob_inp);
            this.body_pnl.Controls.Add(this.mob_lbl);
            this.body_pnl.Controls.Add(this.user_inp);
            this.body_pnl.Controls.Add(this.username_lbl);
            this.body_pnl.Controls.Add(this.profile_update_img);
            this.body_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.body_pnl.Location = new System.Drawing.Point(0, 0);
            this.body_pnl.Name = "body_pnl";
            this.body_pnl.Size = new System.Drawing.Size(1105, 564);
            this.body_pnl.TabIndex = 0;
            // 
            // browse_btn
            // 
            this.browse_btn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.browse_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.browse_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.browse_btn.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browse_btn.ForeColor = System.Drawing.Color.White;
            this.browse_btn.Location = new System.Drawing.Point(432, 324);
            this.browse_btn.Name = "browse_btn";
            this.browse_btn.Size = new System.Drawing.Size(88, 31);
            this.browse_btn.TabIndex = 44;
            this.browse_btn.Text = "Browse";
            this.browse_btn.UseVisualStyleBackColor = false;
            this.browse_btn.Click += new System.EventHandler(this.browse_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.Color.Yellow;
            this.update_btn.BackgroundColor = System.Drawing.Color.Yellow;
            this.update_btn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.update_btn.BorderRadius = 13;
            this.update_btn.BorderSize = 0;
            this.update_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update_btn.FlatAppearance.BorderSize = 0;
            this.update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_btn.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.ForeColor = System.Drawing.Color.White;
            this.update_btn.Location = new System.Drawing.Point(121, 376);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(245, 40);
            this.update_btn.TabIndex = 43;
            this.update_btn.Text = "Save changes";
            this.update_btn.TextColor = System.Drawing.Color.White;
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // path_inp
            // 
            this.path_inp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.path_inp.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.path_inp.Location = new System.Drawing.Point(121, 324);
            this.path_inp.Name = "path_inp";
            this.path_inp.Size = new System.Drawing.Size(308, 31);
            this.path_inp.TabIndex = 42;
            // 
            // profile_pic
            // 
            this.profile_pic.Image = ((System.Drawing.Image)(resources.GetObject("profile_pic.Image")));
            this.profile_pic.Location = new System.Drawing.Point(121, 89);
            this.profile_pic.Name = "profile_pic";
            this.profile_pic.Size = new System.Drawing.Size(227, 220);
            this.profile_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profile_pic.TabIndex = 41;
            this.profile_pic.TabStop = false;
            // 
            // email_inp
            // 
            this.email_inp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email_inp.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_inp.Location = new System.Drawing.Point(551, 324);
            this.email_inp.Name = "email_inp";
            this.email_inp.Size = new System.Drawing.Size(423, 31);
            this.email_inp.TabIndex = 40;
            // 
            // email_lbl
            // 
            this.email_lbl.AutoSize = true;
            this.email_lbl.BackColor = System.Drawing.Color.White;
            this.email_lbl.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_lbl.ForeColor = System.Drawing.Color.Gray;
            this.email_lbl.Location = new System.Drawing.Point(547, 286);
            this.email_lbl.Name = "email_lbl";
            this.email_lbl.Size = new System.Drawing.Size(65, 23);
            this.email_lbl.TabIndex = 39;
            this.email_lbl.Text = "Email";
            // 
            // pass_inp
            // 
            this.pass_inp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pass_inp.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_inp.Location = new System.Drawing.Point(551, 414);
            this.pass_inp.Name = "pass_inp";
            this.pass_inp.PasswordChar = '*';
            this.pass_inp.Size = new System.Drawing.Size(423, 31);
            this.pass_inp.TabIndex = 38;
            // 
            // pass_lbl
            // 
            this.pass_lbl.AutoSize = true;
            this.pass_lbl.BackColor = System.Drawing.Color.White;
            this.pass_lbl.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_lbl.ForeColor = System.Drawing.Color.Gray;
            this.pass_lbl.Location = new System.Drawing.Point(547, 376);
            this.pass_lbl.Name = "pass_lbl";
            this.pass_lbl.Size = new System.Drawing.Size(98, 23);
            this.pass_lbl.TabIndex = 37;
            this.pass_lbl.Text = "Password";
            // 
            // mob_inp
            // 
            this.mob_inp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mob_inp.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mob_inp.Location = new System.Drawing.Point(551, 232);
            this.mob_inp.Name = "mob_inp";
            this.mob_inp.Size = new System.Drawing.Size(423, 31);
            this.mob_inp.TabIndex = 36;
            // 
            // mob_lbl
            // 
            this.mob_lbl.AutoSize = true;
            this.mob_lbl.BackColor = System.Drawing.Color.White;
            this.mob_lbl.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mob_lbl.ForeColor = System.Drawing.Color.Gray;
            this.mob_lbl.Location = new System.Drawing.Point(547, 194);
            this.mob_lbl.Name = "mob_lbl";
            this.mob_lbl.Size = new System.Drawing.Size(153, 23);
            this.mob_lbl.TabIndex = 35;
            this.mob_lbl.Text = "Mobile Number";
            // 
            // user_inp
            // 
            this.user_inp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user_inp.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_inp.Location = new System.Drawing.Point(551, 140);
            this.user_inp.Name = "user_inp";
            this.user_inp.Size = new System.Drawing.Size(423, 31);
            this.user_inp.TabIndex = 34;
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.BackColor = System.Drawing.Color.White;
            this.username_lbl.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_lbl.ForeColor = System.Drawing.Color.Gray;
            this.username_lbl.Location = new System.Drawing.Point(547, 102);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(109, 23);
            this.username_lbl.TabIndex = 33;
            this.username_lbl.Text = "User Name";
            // 
            // profile_update_img
            // 
            this.profile_update_img.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profile_update_img.Image = ((System.Drawing.Image)(resources.GetObject("profile_update_img.Image")));
            this.profile_update_img.Location = new System.Drawing.Point(0, 0);
            this.profile_update_img.Name = "profile_update_img";
            this.profile_update_img.Size = new System.Drawing.Size(1105, 564);
            this.profile_update_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profile_update_img.TabIndex = 0;
            this.profile_update_img.TabStop = false;
            // 
            // UserProfileUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.body_pnl);
            this.Name = "UserProfileUpdateForm";
            this.Size = new System.Drawing.Size(1105, 564);
            this.body_pnl.ResumeLayout(false);
            this.body_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profile_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profile_update_img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel body_pnl;
        private System.Windows.Forms.PictureBox profile_update_img;
        private System.Windows.Forms.TextBox email_inp;
        private System.Windows.Forms.Label email_lbl;
        private System.Windows.Forms.TextBox pass_inp;
        private System.Windows.Forms.Label pass_lbl;
        private System.Windows.Forms.TextBox mob_inp;
        private System.Windows.Forms.Label mob_lbl;
        private System.Windows.Forms.TextBox user_inp;
        private System.Windows.Forms.Label username_lbl;
        private CustomResources.RoundImg profile_pic;
        private System.Windows.Forms.TextBox path_inp;
        private CustomResources.RoundButton update_btn;
        private System.Windows.Forms.Button browse_btn;
    }
}
