namespace TourStay.LogoutSystem
{
    partial class LogoutForm
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
            this.logout_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.yes_btn = new System.Windows.Forms.Button();
            this.no_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logout_lbl
            // 
            this.logout_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logout_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.logout_lbl.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_lbl.ForeColor = System.Drawing.Color.White;
            this.logout_lbl.Location = new System.Drawing.Point(0, 0);
            this.logout_lbl.Name = "logout_lbl";
            this.logout_lbl.Size = new System.Drawing.Size(360, 38);
            this.logout_lbl.TabIndex = 0;
            this.logout_lbl.Text = "Logout";
            this.logout_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 104);
            this.label1.TabIndex = 1;
            this.label1.Text = "Are you sure want to logging out??";
            // 
            // yes_btn
            // 
            this.yes_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.yes_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yes_btn.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yes_btn.ForeColor = System.Drawing.Color.White;
            this.yes_btn.Location = new System.Drawing.Point(37, 172);
            this.yes_btn.Name = "yes_btn";
            this.yes_btn.Size = new System.Drawing.Size(103, 37);
            this.yes_btn.TabIndex = 2;
            this.yes_btn.Text = "YES";
            this.yes_btn.UseVisualStyleBackColor = false;
            this.yes_btn.Click += new System.EventHandler(this.yes_btn_Click);
            // 
            // no_btn
            // 
            this.no_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.no_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.no_btn.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_btn.ForeColor = System.Drawing.Color.White;
            this.no_btn.Location = new System.Drawing.Point(164, 172);
            this.no_btn.Name = "no_btn";
            this.no_btn.Size = new System.Drawing.Size(103, 37);
            this.no_btn.TabIndex = 3;
            this.no_btn.Text = "NO";
            this.no_btn.UseVisualStyleBackColor = false;
            this.no_btn.Click += new System.EventHandler(this.no_btn_Click);
            // 
            // LogoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 222);
            this.Controls.Add(this.no_btn);
            this.Controls.Add(this.yes_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logout_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogoutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogoutForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label logout_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button yes_btn;
        private System.Windows.Forms.Button no_btn;
    }
}