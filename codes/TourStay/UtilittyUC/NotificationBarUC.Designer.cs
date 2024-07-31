namespace TourStay.UtilittyUC
{
    partial class NotificationBarUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotificationBarUC));
            this.notification_pnl = new System.Windows.Forms.Panel();
            this.i_btn = new TourStay.CustomResources.RoundImg();
            this.notification_msg = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.notification_box = new System.Windows.Forms.PictureBox();
            this.notification_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.i_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notification_box)).BeginInit();
            this.SuspendLayout();
            // 
            // notification_pnl
            // 
            this.notification_pnl.Controls.Add(this.i_btn);
            this.notification_pnl.Controls.Add(this.notification_msg);
            this.notification_pnl.Controls.Add(this.pictureBox1);
            this.notification_pnl.Controls.Add(this.notification_box);
            this.notification_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notification_pnl.Location = new System.Drawing.Point(0, 0);
            this.notification_pnl.Name = "notification_pnl";
            this.notification_pnl.Size = new System.Drawing.Size(954, 77);
            this.notification_pnl.TabIndex = 0;
            // 
            // i_btn
            // 
            this.i_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.i_btn.Image = ((System.Drawing.Image)(resources.GetObject("i_btn.Image")));
            this.i_btn.Location = new System.Drawing.Point(901, 19);
            this.i_btn.Name = "i_btn";
            this.i_btn.Size = new System.Drawing.Size(34, 35);
            this.i_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.i_btn.TabIndex = 3;
            this.i_btn.TabStop = false;
            this.i_btn.Click += new System.EventHandler(this.i_btn_Click);
            // 
            // notification_msg
            // 
            this.notification_msg.AutoSize = true;
            this.notification_msg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.notification_msg.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notification_msg.Location = new System.Drawing.Point(85, 24);
            this.notification_msg.Name = "notification_msg";
            this.notification_msg.Size = new System.Drawing.Size(335, 24);
            this.notification_msg.TabIndex = 2;
            this.notification_msg.Text = "Pleace check the new notification.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // notification_box
            // 
            this.notification_box.Cursor = System.Windows.Forms.Cursors.Hand;
            this.notification_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notification_box.Image = ((System.Drawing.Image)(resources.GetObject("notification_box.Image")));
            this.notification_box.Location = new System.Drawing.Point(0, 0);
            this.notification_box.Name = "notification_box";
            this.notification_box.Size = new System.Drawing.Size(954, 77);
            this.notification_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.notification_box.TabIndex = 0;
            this.notification_box.TabStop = false;
            // 
            // NotificationBarUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.notification_pnl);
            this.Name = "NotificationBarUC";
            this.Size = new System.Drawing.Size(954, 77);
            this.notification_pnl.ResumeLayout(false);
            this.notification_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.i_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notification_box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel notification_pnl;
        private System.Windows.Forms.PictureBox notification_box;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label notification_msg;
        private CustomResources.RoundImg i_btn;
    }
}
