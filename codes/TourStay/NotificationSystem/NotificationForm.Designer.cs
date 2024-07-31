namespace TourStay.FormScreens
{
    partial class NotificationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotificationForm));
            this.head_pnl = new System.Windows.Forms.Panel();
            this.exit_btn = new System.Windows.Forms.PictureBox();
            this.body_pnl = new System.Windows.Forms.Panel();
            this.head_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // head_pnl
            // 
            this.head_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.head_pnl.Controls.Add(this.exit_btn);
            this.head_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.head_pnl.Location = new System.Drawing.Point(0, 0);
            this.head_pnl.Name = "head_pnl";
            this.head_pnl.Size = new System.Drawing.Size(815, 63);
            this.head_pnl.TabIndex = 0;
            // 
            // exit_btn
            // 
            this.exit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_btn.Image = ((System.Drawing.Image)(resources.GetObject("exit_btn.Image")));
            this.exit_btn.Location = new System.Drawing.Point(773, 12);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(30, 28);
            this.exit_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exit_btn.TabIndex = 0;
            this.exit_btn.TabStop = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // body_pnl
            // 
            this.body_pnl.BackColor = System.Drawing.Color.White;
            this.body_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.body_pnl.Location = new System.Drawing.Point(0, 63);
            this.body_pnl.Name = "body_pnl";
            this.body_pnl.Size = new System.Drawing.Size(815, 385);
            this.body_pnl.TabIndex = 1;
            // 
            // NotificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 448);
            this.Controls.Add(this.body_pnl);
            this.Controls.Add(this.head_pnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NotificationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.head_pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.exit_btn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel head_pnl;
        private System.Windows.Forms.Panel body_pnl;
        private System.Windows.Forms.PictureBox exit_btn;
    }
}