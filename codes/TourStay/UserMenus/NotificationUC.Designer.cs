namespace TourStay.UserMenus
{
    partial class NotificationUC
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
            this.body_pnl = new System.Windows.Forms.Panel();
            this.notify_pnl = new System.Windows.Forms.FlowLayoutPanel();
            this.body_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // body_pnl
            // 
            this.body_pnl.Controls.Add(this.notify_pnl);
            this.body_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.body_pnl.Location = new System.Drawing.Point(0, 0);
            this.body_pnl.Name = "body_pnl";
            this.body_pnl.Size = new System.Drawing.Size(1105, 564);
            this.body_pnl.TabIndex = 0;
            // 
            // notify_pnl
            // 
            this.notify_pnl.AutoScroll = true;
            this.notify_pnl.Location = new System.Drawing.Point(18, 22);
            this.notify_pnl.Name = "notify_pnl";
            this.notify_pnl.Size = new System.Drawing.Size(1068, 520);
            this.notify_pnl.TabIndex = 1;
            // 
            // NotificationUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.body_pnl);
            this.Name = "NotificationUC";
            this.Size = new System.Drawing.Size(1105, 564);
            this.body_pnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel body_pnl;
        private System.Windows.Forms.FlowLayoutPanel notify_pnl;
    }
}
