namespace TourStay.UserMenus
{
    partial class BookingUC
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
            this.view_pnl = new System.Windows.Forms.FlowLayoutPanel();
            this.search_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.search_inp = new System.Windows.Forms.TextBox();
            this.body_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // body_pnl
            // 
            this.body_pnl.Controls.Add(this.view_pnl);
            this.body_pnl.Controls.Add(this.search_btn);
            this.body_pnl.Controls.Add(this.label1);
            this.body_pnl.Controls.Add(this.search_inp);
            this.body_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.body_pnl.Location = new System.Drawing.Point(0, 0);
            this.body_pnl.Name = "body_pnl";
            this.body_pnl.Size = new System.Drawing.Size(1105, 564);
            this.body_pnl.TabIndex = 1;
            // 
            // view_pnl
            // 
            this.view_pnl.AutoScroll = true;
            this.view_pnl.Location = new System.Drawing.Point(16, 111);
            this.view_pnl.Name = "view_pnl";
            this.view_pnl.Size = new System.Drawing.Size(1077, 436);
            this.view_pnl.TabIndex = 10;
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.Blue;
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.search_btn.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.search_btn.Location = new System.Drawing.Point(488, 54);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(85, 34);
            this.search_btn.TabIndex = 9;
            this.search_btn.Text = "search";
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(59, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Enter the place to visit";
            // 
            // search_inp
            // 
            this.search_inp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.search_inp.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_inp.Location = new System.Drawing.Point(59, 54);
            this.search_inp.Name = "search_inp";
            this.search_inp.Size = new System.Drawing.Size(422, 34);
            this.search_inp.TabIndex = 7;
            // 
            // BookingUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.body_pnl);
            this.Name = "BookingUC";
            this.Size = new System.Drawing.Size(1105, 564);
            this.body_pnl.ResumeLayout(false);
            this.body_pnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel body_pnl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox search_inp;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.FlowLayoutPanel view_pnl;
    }
}
