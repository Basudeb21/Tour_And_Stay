namespace TourStay.HotelMenus
{
    partial class UpdateUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateUC));
            this.body_pnl = new System.Windows.Forms.Panel();
            this.upd_bg_pnl = new System.Windows.Forms.Panel();
            this.update_pic = new System.Windows.Forms.PictureBox();
            this.body_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.update_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // body_pnl
            // 
            this.body_pnl.Controls.Add(this.upd_bg_pnl);
            this.body_pnl.Controls.Add(this.update_pic);
            this.body_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.body_pnl.Location = new System.Drawing.Point(0, 0);
            this.body_pnl.Name = "body_pnl";
            this.body_pnl.Size = new System.Drawing.Size(1105, 564);
            this.body_pnl.TabIndex = 0;
            // 
            // upd_bg_pnl
            // 
            this.upd_bg_pnl.BackColor = System.Drawing.Color.White;
            this.upd_bg_pnl.Location = new System.Drawing.Point(99, 88);
            this.upd_bg_pnl.Name = "upd_bg_pnl";
            this.upd_bg_pnl.Size = new System.Drawing.Size(905, 386);
            this.upd_bg_pnl.TabIndex = 1;
            // 
            // update_pic
            // 
            this.update_pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.update_pic.Image = ((System.Drawing.Image)(resources.GetObject("update_pic.Image")));
            this.update_pic.Location = new System.Drawing.Point(0, 0);
            this.update_pic.Name = "update_pic";
            this.update_pic.Size = new System.Drawing.Size(1105, 564);
            this.update_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.update_pic.TabIndex = 0;
            this.update_pic.TabStop = false;
            // 
            // UpdateUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.body_pnl);
            this.Name = "UpdateUC";
            this.Size = new System.Drawing.Size(1105, 564);
            this.body_pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.update_pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel body_pnl;
        private System.Windows.Forms.PictureBox update_pic;
        private System.Windows.Forms.Panel upd_bg_pnl;
    }
}
