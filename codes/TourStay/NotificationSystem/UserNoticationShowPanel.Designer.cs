namespace TourStay.NotificationSystem
{
    partial class UserNoticationShowPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserNoticationShowPanel));
            this.phno_lbl = new System.Windows.Forms.Label();
            this.hid_lbl = new System.Windows.Forms.Label();
            this.msg_lbl = new System.Windows.Forms.Label();
            this.hotel_notification_pic = new System.Windows.Forms.PictureBox();
            this.booking_sts = new System.Windows.Forms.Label();
            this.sts = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_notification_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // phno_lbl
            // 
            this.phno_lbl.AutoSize = true;
            this.phno_lbl.BackColor = System.Drawing.Color.White;
            this.phno_lbl.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phno_lbl.ForeColor = System.Drawing.Color.Navy;
            this.phno_lbl.Location = new System.Drawing.Point(295, 90);
            this.phno_lbl.Name = "phno_lbl";
            this.phno_lbl.Size = new System.Drawing.Size(110, 21);
            this.phno_lbl.TabIndex = 10;
            this.phno_lbl.Text = "9784561203";
            // 
            // hid_lbl
            // 
            this.hid_lbl.AutoSize = true;
            this.hid_lbl.BackColor = System.Drawing.Color.White;
            this.hid_lbl.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hid_lbl.ForeColor = System.Drawing.Color.Red;
            this.hid_lbl.Location = new System.Drawing.Point(106, 90);
            this.hid_lbl.Name = "hid_lbl";
            this.hid_lbl.Size = new System.Drawing.Size(138, 21);
            this.hid_lbl.TabIndex = 8;
            this.hid_lbl.Text = "Hotel Contact :";
            // 
            // msg_lbl
            // 
            this.msg_lbl.BackColor = System.Drawing.Color.White;
            this.msg_lbl.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msg_lbl.ForeColor = System.Drawing.Color.Black;
            this.msg_lbl.Location = new System.Drawing.Point(106, 151);
            this.msg_lbl.Name = "msg_lbl";
            this.msg_lbl.Size = new System.Drawing.Size(607, 100);
            this.msg_lbl.TabIndex = 9;
            this.msg_lbl.Text = "null";
            // 
            // hotel_notification_pic
            // 
            this.hotel_notification_pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hotel_notification_pic.Image = ((System.Drawing.Image)(resources.GetObject("hotel_notification_pic.Image")));
            this.hotel_notification_pic.Location = new System.Drawing.Point(0, 0);
            this.hotel_notification_pic.Name = "hotel_notification_pic";
            this.hotel_notification_pic.Size = new System.Drawing.Size(815, 385);
            this.hotel_notification_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hotel_notification_pic.TabIndex = 7;
            this.hotel_notification_pic.TabStop = false;
            // 
            // booking_sts
            // 
            this.booking_sts.AutoSize = true;
            this.booking_sts.BackColor = System.Drawing.Color.White;
            this.booking_sts.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booking_sts.ForeColor = System.Drawing.Color.Red;
            this.booking_sts.Location = new System.Drawing.Point(106, 289);
            this.booking_sts.Name = "booking_sts";
            this.booking_sts.Size = new System.Drawing.Size(149, 21);
            this.booking_sts.TabIndex = 11;
            this.booking_sts.Text = "Booking Status :";
            // 
            // sts
            // 
            this.sts.AutoSize = true;
            this.sts.BackColor = System.Drawing.Color.White;
            this.sts.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sts.ForeColor = System.Drawing.Color.Navy;
            this.sts.Location = new System.Drawing.Point(274, 289);
            this.sts.Name = "sts";
            this.sts.Size = new System.Drawing.Size(42, 21);
            this.sts.TabIndex = 12;
            this.sts.Text = "null";
            // 
            // UserNoticationShowPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sts);
            this.Controls.Add(this.booking_sts);
            this.Controls.Add(this.phno_lbl);
            this.Controls.Add(this.hid_lbl);
            this.Controls.Add(this.msg_lbl);
            this.Controls.Add(this.hotel_notification_pic);
            this.Name = "UserNoticationShowPanel";
            this.Size = new System.Drawing.Size(815, 385);
            ((System.ComponentModel.ISupportInitialize)(this.hotel_notification_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label phno_lbl;
        private System.Windows.Forms.Label hid_lbl;
        private System.Windows.Forms.Label msg_lbl;
        private System.Windows.Forms.PictureBox hotel_notification_pic;
        private System.Windows.Forms.Label booking_sts;
        private System.Windows.Forms.Label sts;
    }
}
