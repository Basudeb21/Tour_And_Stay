namespace TourStay.HotelMenus
{
    partial class NotificataionUC
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
            this.notify_pnl = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // notify_pnl
            // 
            this.notify_pnl.AutoScroll = true;
            this.notify_pnl.Location = new System.Drawing.Point(17, 20);
            this.notify_pnl.Name = "notify_pnl";
            this.notify_pnl.Size = new System.Drawing.Size(1068, 520);
            this.notify_pnl.TabIndex = 0;
            // 
            // NotificataionUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.notify_pnl);
            this.Name = "NotificataionUC";
            this.Size = new System.Drawing.Size(1105, 564);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel notify_pnl;
    }
}
