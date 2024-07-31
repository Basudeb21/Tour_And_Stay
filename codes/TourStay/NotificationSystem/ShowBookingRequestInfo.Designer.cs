namespace TourStay.NotificationSystem
{
    partial class ShowBookingRequestInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowBookingRequestInfo));
            this.body_pnl = new System.Windows.Forms.Panel();
            this.phno_lbl = new System.Windows.Forms.Label();
            this.contact_lbl = new System.Windows.Forms.Label();
            this.msg_lbl = new System.Windows.Forms.Label();
            this.message_inp = new System.Windows.Forms.TextBox();
            this.hotel_notification_pic = new System.Windows.Forms.PictureBox();
            this.send_btn = new TourStay.CustomResources.RoundImg();
            this.select_box = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.body_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_notification_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.send_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // body_pnl
            // 
            this.body_pnl.Controls.Add(this.label1);
            this.body_pnl.Controls.Add(this.select_box);
            this.body_pnl.Controls.Add(this.send_btn);
            this.body_pnl.Controls.Add(this.phno_lbl);
            this.body_pnl.Controls.Add(this.contact_lbl);
            this.body_pnl.Controls.Add(this.msg_lbl);
            this.body_pnl.Controls.Add(this.message_inp);
            this.body_pnl.Controls.Add(this.hotel_notification_pic);
            this.body_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.body_pnl.Location = new System.Drawing.Point(0, 0);
            this.body_pnl.Name = "body_pnl";
            this.body_pnl.Size = new System.Drawing.Size(815, 385);
            this.body_pnl.TabIndex = 0;
            // 
            // phno_lbl
            // 
            this.phno_lbl.AutoSize = true;
            this.phno_lbl.BackColor = System.Drawing.Color.White;
            this.phno_lbl.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phno_lbl.ForeColor = System.Drawing.Color.Navy;
            this.phno_lbl.Location = new System.Drawing.Point(283, 46);
            this.phno_lbl.Name = "phno_lbl";
            this.phno_lbl.Size = new System.Drawing.Size(42, 21);
            this.phno_lbl.TabIndex = 6;
            this.phno_lbl.Text = "null";
            // 
            // contact_lbl
            // 
            this.contact_lbl.AutoSize = true;
            this.contact_lbl.BackColor = System.Drawing.Color.White;
            this.contact_lbl.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact_lbl.ForeColor = System.Drawing.Color.Red;
            this.contact_lbl.Location = new System.Drawing.Point(33, 46);
            this.contact_lbl.Name = "contact_lbl";
            this.contact_lbl.Size = new System.Drawing.Size(203, 21);
            this.contact_lbl.TabIndex = 2;
            this.contact_lbl.Text = "User contact number : ";
            // 
            // msg_lbl
            // 
            this.msg_lbl.BackColor = System.Drawing.Color.White;
            this.msg_lbl.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msg_lbl.ForeColor = System.Drawing.Color.Black;
            this.msg_lbl.Location = new System.Drawing.Point(33, 90);
            this.msg_lbl.Name = "msg_lbl";
            this.msg_lbl.Size = new System.Drawing.Size(733, 135);
            this.msg_lbl.TabIndex = 3;
            this.msg_lbl.Text = "null";
            // 
            // message_inp
            // 
            this.message_inp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.message_inp.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message_inp.Location = new System.Drawing.Point(51, 330);
            this.message_inp.Name = "message_inp";
            this.message_inp.Size = new System.Drawing.Size(681, 38);
            this.message_inp.TabIndex = 5;
            // 
            // hotel_notification_pic
            // 
            this.hotel_notification_pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hotel_notification_pic.Image = ((System.Drawing.Image)(resources.GetObject("hotel_notification_pic.Image")));
            this.hotel_notification_pic.Location = new System.Drawing.Point(0, 0);
            this.hotel_notification_pic.Name = "hotel_notification_pic";
            this.hotel_notification_pic.Size = new System.Drawing.Size(815, 385);
            this.hotel_notification_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hotel_notification_pic.TabIndex = 0;
            this.hotel_notification_pic.TabStop = false;
            // 
            // send_btn
            // 
            this.send_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.send_btn.Image = ((System.Drawing.Image)(resources.GetObject("send_btn.Image")));
            this.send_btn.Location = new System.Drawing.Point(738, 323);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(53, 52);
            this.send_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.send_btn.TabIndex = 7;
            this.send_btn.TabStop = false;
            this.send_btn.Click += new System.EventHandler(this.send_btn_Click);
            // 
            // select_box
            // 
            this.select_box.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_box.FormattingEnabled = true;
            this.select_box.Items.AddRange(new object[] {
            "Approved",
            "Dislined"});
            this.select_box.Location = new System.Drawing.Point(411, 259);
            this.select_box.Name = "select_box";
            this.select_box.Size = new System.Drawing.Size(355, 32);
            this.select_box.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(33, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Accept or Disline request from here : ";
            // 
            // ShowBookingRequestInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.body_pnl);
            this.Name = "ShowBookingRequestInfo";
            this.Size = new System.Drawing.Size(815, 385);
            this.body_pnl.ResumeLayout(false);
            this.body_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_notification_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.send_btn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel body_pnl;
        private System.Windows.Forms.Label phno_lbl;
        private System.Windows.Forms.Label contact_lbl;
        private System.Windows.Forms.Label msg_lbl;
        private System.Windows.Forms.TextBox message_inp;
        private System.Windows.Forms.PictureBox hotel_notification_pic;
        private CustomResources.RoundImg send_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox select_box;
    }
}
