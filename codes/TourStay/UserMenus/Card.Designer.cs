namespace TourStay.UserMenus
{
    partial class Card
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Card));
            this.body_pnl = new System.Windows.Forms.Panel();
            this.i_btn = new TourStay.CustomResources.RoundImg();
            this.book = new System.Windows.Forms.Button();
            this.ph_lbl = new System.Windows.Forms.Label();
            this.hotel_pic = new System.Windows.Forms.PictureBox();
            this.body_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.i_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // body_pnl
            // 
            this.body_pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.body_pnl.Controls.Add(this.i_btn);
            this.body_pnl.Controls.Add(this.book);
            this.body_pnl.Controls.Add(this.ph_lbl);
            this.body_pnl.Controls.Add(this.hotel_pic);
            this.body_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.body_pnl.Location = new System.Drawing.Point(0, 0);
            this.body_pnl.Name = "body_pnl";
            this.body_pnl.Size = new System.Drawing.Size(237, 208);
            this.body_pnl.TabIndex = 0;
            // 
            // i_btn
            // 
            this.i_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.i_btn.Image = ((System.Drawing.Image)(resources.GetObject("i_btn.Image")));
            this.i_btn.Location = new System.Drawing.Point(188, 11);
            this.i_btn.Name = "i_btn";
            this.i_btn.Size = new System.Drawing.Size(35, 35);
            this.i_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.i_btn.TabIndex = 5;
            this.i_btn.TabStop = false;
            this.i_btn.Click += new System.EventHandler(this.i_btn_Click);
            // 
            // book
            // 
            this.book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.book.Cursor = System.Windows.Forms.Cursors.Hand;
            this.book.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book.Location = new System.Drawing.Point(6, 165);
            this.book.Name = "book";
            this.book.Size = new System.Drawing.Size(220, 30);
            this.book.TabIndex = 4;
            this.book.Text = "Place Booking";
            this.book.UseVisualStyleBackColor = false;
            this.book.Click += new System.EventHandler(this.book_Click);
            // 
            // ph_lbl
            // 
            this.ph_lbl.AutoSize = true;
            this.ph_lbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ph_lbl.Location = new System.Drawing.Point(3, 135);
            this.ph_lbl.Name = "ph_lbl";
            this.ph_lbl.Size = new System.Drawing.Size(0, 16);
            this.ph_lbl.TabIndex = 1;
            // 
            // hotel_pic
            // 
            this.hotel_pic.Image = ((System.Drawing.Image)(resources.GetObject("hotel_pic.Image")));
            this.hotel_pic.Location = new System.Drawing.Point(4, 4);
            this.hotel_pic.Name = "hotel_pic";
            this.hotel_pic.Size = new System.Drawing.Size(222, 119);
            this.hotel_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hotel_pic.TabIndex = 0;
            this.hotel_pic.TabStop = false;
            // 
            // Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.body_pnl);
            this.Name = "Card";
            this.Size = new System.Drawing.Size(237, 208);
            this.body_pnl.ResumeLayout(false);
            this.body_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.i_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel body_pnl;
        private System.Windows.Forms.Label ph_lbl;
        private System.Windows.Forms.PictureBox hotel_pic;
        private System.Windows.Forms.Button book;
        private CustomResources.RoundImg i_btn;
    }
}
