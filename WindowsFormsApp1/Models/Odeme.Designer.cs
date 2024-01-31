namespace WindowsFormsApp1
{
    partial class Odeme
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
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TutarTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Periyot = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.AdSoyadCb = new System.Windows.Forms.ComboBox();
            this.YenileTb = new System.Windows.Forms.Button();
            this.AraTbClickButton = new System.Windows.Forms.Button();
            this.AraTb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(299, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(343, 43);
            this.label7.TabIndex = 14;
            this.label7.Text = "FITNESS CENTER\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.RosyBrown;
            this.label2.Location = new System.Drawing.Point(378, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 35);
            this.label2.TabIndex = 13;
            this.label2.Text = "Odemeler";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(58, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 35);
            this.label8.TabIndex = 36;
            this.label8.Text = "Tutar";
            // 
            // TutarTb
            // 
            this.TutarTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TutarTb.Location = new System.Drawing.Point(64, 310);
            this.TutarTb.Multiline = true;
            this.TutarTb.Name = "TutarTb";
            this.TutarTb.Size = new System.Drawing.Size(199, 42);
            this.TutarTb.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(58, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 35);
            this.label1.TabIndex = 33;
            this.label1.Text = "Ad Soyad";
            // 
            // Periyot
            // 
            this.Periyot.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Periyot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Periyot.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Periyot.Location = new System.Drawing.Point(64, 154);
            this.Periyot.Name = "Periyot";
            this.Periyot.Size = new System.Drawing.Size(199, 26);
            this.Periyot.TabIndex = 37;
            this.Periyot.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(58, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 35);
            this.label3.TabIndex = 38;
            this.label3.Text = "Ödeme Ayı";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RosyBrown;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(181, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 35);
            this.button2.TabIndex = 39;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.RosyBrown;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(131, 425);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 35);
            this.button3.TabIndex = 40;
            this.button3.Text = "Geri";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RosyBrown;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(80, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 35);
            this.button1.TabIndex = 41;
            this.button1.Text = "Ödeme";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(347, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(570, 302);
            this.dataGridView1.TabIndex = 42;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.Location = new System.Drawing.Point(965, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 43);
            this.label10.TabIndex = 43;
            this.label10.Text = "X";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // AdSoyadCb
            // 
            this.AdSoyadCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AdSoyadCb.FormattingEnabled = true;
            this.AdSoyadCb.Items.AddRange(new object[] {
            "Bay",
            "Bayan"});
            this.AdSoyadCb.Location = new System.Drawing.Point(64, 241);
            this.AdSoyadCb.Name = "AdSoyadCb";
            this.AdSoyadCb.Size = new System.Drawing.Size(199, 28);
            this.AdSoyadCb.TabIndex = 44;
            this.AdSoyadCb.SelectedIndexChanged += new System.EventHandler(this.CinsiyetTb_SelectedIndexChanged);
            // 
            // YenileTb
            // 
            this.YenileTb.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.YenileTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YenileTb.ForeColor = System.Drawing.SystemColors.Control;
            this.YenileTb.Location = new System.Drawing.Point(756, 121);
            this.YenileTb.Name = "YenileTb";
            this.YenileTb.Size = new System.Drawing.Size(76, 35);
            this.YenileTb.TabIndex = 47;
            this.YenileTb.Text = "Yenile";
            this.YenileTb.UseVisualStyleBackColor = false;
            this.YenileTb.Click += new System.EventHandler(this.YenileTb_Click);
            // 
            // AraTbClickButton
            // 
            this.AraTbClickButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AraTbClickButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AraTbClickButton.ForeColor = System.Drawing.SystemColors.Control;
            this.AraTbClickButton.Location = new System.Drawing.Point(660, 120);
            this.AraTbClickButton.Name = "AraTbClickButton";
            this.AraTbClickButton.Size = new System.Drawing.Size(68, 36);
            this.AraTbClickButton.TabIndex = 46;
            this.AraTbClickButton.Text = "Ara";
            this.AraTbClickButton.UseVisualStyleBackColor = false;
            this.AraTbClickButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // AraTb
            // 
            this.AraTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AraTb.Location = new System.Drawing.Point(406, 121);
            this.AraTb.Multiline = true;
            this.AraTb.Name = "AraTb";
            this.AraTb.Size = new System.Drawing.Size(224, 35);
            this.AraTb.TabIndex = 45;
            this.AraTb.TextChanged += new System.EventHandler(this.AraTb_TextChanged);
            // 
            // Odeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 563);
            this.Controls.Add(this.YenileTb);
            this.Controls.Add(this.AraTbClickButton);
            this.Controls.Add(this.AraTb);
            this.Controls.Add(this.AdSoyadCb);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Periyot);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TutarTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Odeme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Odeme";
            this.Load += new System.EventHandler(this.Odeme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TutarTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Periyot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox AdSoyadCb;
        private System.Windows.Forms.Button YenileTb;
        private System.Windows.Forms.Button AraTbClickButton;
        private System.Windows.Forms.TextBox AraTb;
    }
}