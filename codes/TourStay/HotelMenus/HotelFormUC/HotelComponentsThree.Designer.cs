namespace TourStay.HotelMenus.HotelFormUC
{
    partial class HotelComponentsThree
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HotelComponentsThree));
            this.hotel_comp3_pnl = new System.Windows.Forms.Panel();
            this.formpic = new System.Windows.Forms.PictureBox();
            this.food_inp = new System.Windows.Forms.ComboBox();
            this.parking_inp = new System.Windows.Forms.ComboBox();
            this.travel_inp = new System.Windows.Forms.ComboBox();
            this.fridge_lbl = new System.Windows.Forms.Label();
            this.this_txt = new System.Windows.Forms.Label();
            this.nxt_btn = new System.Windows.Forms.PictureBox();
            this.prev_btn = new System.Windows.Forms.PictureBox();
            this.wifi_lbl = new System.Windows.Forms.Label();
            this.ac_lbl = new System.Windows.Forms.Label();
            this.submit_form = new TourStay.CustomResources.RoundButton();
            this.hotel_comp3_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nxt_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prev_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // hotel_comp3_pnl
            // 
            this.hotel_comp3_pnl.BackColor = System.Drawing.Color.White;
            this.hotel_comp3_pnl.Controls.Add(this.submit_form);
            this.hotel_comp3_pnl.Controls.Add(this.formpic);
            this.hotel_comp3_pnl.Controls.Add(this.food_inp);
            this.hotel_comp3_pnl.Controls.Add(this.parking_inp);
            this.hotel_comp3_pnl.Controls.Add(this.travel_inp);
            this.hotel_comp3_pnl.Controls.Add(this.fridge_lbl);
            this.hotel_comp3_pnl.Controls.Add(this.this_txt);
            this.hotel_comp3_pnl.Controls.Add(this.nxt_btn);
            this.hotel_comp3_pnl.Controls.Add(this.prev_btn);
            this.hotel_comp3_pnl.Controls.Add(this.wifi_lbl);
            this.hotel_comp3_pnl.Controls.Add(this.ac_lbl);
            this.hotel_comp3_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hotel_comp3_pnl.Location = new System.Drawing.Point(0, 0);
            this.hotel_comp3_pnl.Name = "hotel_comp3_pnl";
            this.hotel_comp3_pnl.Size = new System.Drawing.Size(905, 386);
            this.hotel_comp3_pnl.TabIndex = 4;
            // 
            // formpic
            // 
            this.formpic.Image = ((System.Drawing.Image)(resources.GetObject("formpic.Image")));
            this.formpic.Location = new System.Drawing.Point(15, 60);
            this.formpic.Name = "formpic";
            this.formpic.Size = new System.Drawing.Size(261, 251);
            this.formpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.formpic.TabIndex = 29;
            this.formpic.TabStop = false;
            // 
            // food_inp
            // 
            this.food_inp.Font = new System.Drawing.Font("Gadugi", 12F);
            this.food_inp.FormattingEnabled = true;
            this.food_inp.Items.AddRange(new object[] {
            "Yes",
            "No",
            "Both"});
            this.food_inp.Location = new System.Drawing.Point(305, 175);
            this.food_inp.Name = "food_inp";
            this.food_inp.Size = new System.Drawing.Size(448, 32);
            this.food_inp.TabIndex = 28;
            // 
            // parking_inp
            // 
            this.parking_inp.Font = new System.Drawing.Font("Gadugi", 12F);
            this.parking_inp.FormattingEnabled = true;
            this.parking_inp.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.parking_inp.Location = new System.Drawing.Point(305, 264);
            this.parking_inp.Name = "parking_inp";
            this.parking_inp.Size = new System.Drawing.Size(448, 32);
            this.parking_inp.TabIndex = 27;
            // 
            // travel_inp
            // 
            this.travel_inp.Font = new System.Drawing.Font("Gadugi", 12F);
            this.travel_inp.FormattingEnabled = true;
            this.travel_inp.Items.AddRange(new object[] {
            "Yes",
            "No",
            "Both"});
            this.travel_inp.Location = new System.Drawing.Point(305, 92);
            this.travel_inp.Name = "travel_inp";
            this.travel_inp.Size = new System.Drawing.Size(448, 32);
            this.travel_inp.TabIndex = 25;
            // 
            // fridge_lbl
            // 
            this.fridge_lbl.AutoSize = true;
            this.fridge_lbl.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fridge_lbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.fridge_lbl.Location = new System.Drawing.Point(301, 142);
            this.fridge_lbl.Name = "fridge_lbl";
            this.fridge_lbl.Size = new System.Drawing.Size(49, 20);
            this.fridge_lbl.TabIndex = 20;
            this.fridge_lbl.Text = "Food";
            // 
            // this_txt
            // 
            this.this_txt.AutoSize = true;
            this.this_txt.Font = new System.Drawing.Font("Gadugi", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.this_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.this_txt.Location = new System.Drawing.Point(207, 9);
            this.this_txt.Name = "this_txt";
            this.this_txt.Size = new System.Drawing.Size(407, 34);
            this.this_txt.TabIndex = 18;
            this.this_txt.Text = "Hotel Tour Components Form";
            // 
            // nxt_btn
            // 
            this.nxt_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nxt_btn.Image = ((System.Drawing.Image)(resources.GetObject("nxt_btn.Image")));
            this.nxt_btn.Location = new System.Drawing.Point(69, 338);
            this.nxt_btn.Name = "nxt_btn";
            this.nxt_btn.Size = new System.Drawing.Size(30, 30);
            this.nxt_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nxt_btn.TabIndex = 17;
            this.nxt_btn.TabStop = false;
            this.nxt_btn.Click += new System.EventHandler(this.nxt_btn_Click);
            // 
            // prev_btn
            // 
            this.prev_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.prev_btn.Image = ((System.Drawing.Image)(resources.GetObject("prev_btn.Image")));
            this.prev_btn.Location = new System.Drawing.Point(19, 338);
            this.prev_btn.Name = "prev_btn";
            this.prev_btn.Size = new System.Drawing.Size(30, 30);
            this.prev_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prev_btn.TabIndex = 16;
            this.prev_btn.TabStop = false;
            this.prev_btn.Click += new System.EventHandler(this.prev_btn_Click);
            // 
            // wifi_lbl
            // 
            this.wifi_lbl.AutoSize = true;
            this.wifi_lbl.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wifi_lbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.wifi_lbl.Location = new System.Drawing.Point(301, 235);
            this.wifi_lbl.Name = "wifi_lbl";
            this.wifi_lbl.Size = new System.Drawing.Size(71, 20);
            this.wifi_lbl.TabIndex = 15;
            this.wifi_lbl.Text = "Parking";
            // 
            // ac_lbl
            // 
            this.ac_lbl.AutoSize = true;
            this.ac_lbl.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ac_lbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ac_lbl.Location = new System.Drawing.Point(301, 55);
            this.ac_lbl.Name = "ac_lbl";
            this.ac_lbl.Size = new System.Drawing.Size(58, 20);
            this.ac_lbl.TabIndex = 11;
            this.ac_lbl.Text = "Travel";
            // 
            // submit_form
            // 
            this.submit_form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(13)))), ((int)(((byte)(73)))));
            this.submit_form.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(13)))), ((int)(((byte)(73)))));
            this.submit_form.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.submit_form.BorderRadius = 15;
            this.submit_form.BorderSize = 0;
            this.submit_form.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submit_form.FlatAppearance.BorderSize = 0;
            this.submit_form.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit_form.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_form.ForeColor = System.Drawing.Color.White;
            this.submit_form.Location = new System.Drawing.Point(305, 327);
            this.submit_form.Name = "submit_form";
            this.submit_form.Size = new System.Drawing.Size(141, 41);
            this.submit_form.TabIndex = 37;
            this.submit_form.Text = "Submit";
            this.submit_form.TextColor = System.Drawing.Color.White;
            this.submit_form.UseVisualStyleBackColor = false;
            this.submit_form.Click += new System.EventHandler(this.submit_form_Click);
            // 
            // HotelComponentsThree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.hotel_comp3_pnl);
            this.Name = "HotelComponentsThree";
            this.Size = new System.Drawing.Size(905, 386);
            this.hotel_comp3_pnl.ResumeLayout(false);
            this.hotel_comp3_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nxt_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prev_btn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel hotel_comp3_pnl;
        private System.Windows.Forms.PictureBox formpic;
        private System.Windows.Forms.ComboBox food_inp;
        private System.Windows.Forms.ComboBox parking_inp;
        private System.Windows.Forms.ComboBox travel_inp;
        private System.Windows.Forms.Label fridge_lbl;
        private System.Windows.Forms.Label this_txt;
        private System.Windows.Forms.PictureBox nxt_btn;
        private System.Windows.Forms.PictureBox prev_btn;
        private System.Windows.Forms.Label wifi_lbl;
        private System.Windows.Forms.Label ac_lbl;
        private CustomResources.RoundButton submit_form;
    }
}
