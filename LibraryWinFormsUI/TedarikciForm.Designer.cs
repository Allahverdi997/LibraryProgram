namespace LibraryWinFormsUI
{
    partial class TedarikciForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTedarikciIDFerdi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.mstSexsiyyet = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEkle = new System.Windows.Forms.Button();
            this.cmbTedarikciIDSirket = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mskVoen = new System.Windows.Forms.MaskedTextBox();
            this.txtPersonelAd = new System.Windows.Forms.TextBox();
            this.txtSirketAdi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnSirketEkle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(383, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 377);
            this.label1.TabIndex = 0;
            this.label1.Text = " ";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(134, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ferdi";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(546, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sirket";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "TedarikciID";
            // 
            // cmbTedarikciIDFerdi
            // 
            this.cmbTedarikciIDFerdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTedarikciIDFerdi.FormattingEnabled = true;
            this.cmbTedarikciIDFerdi.Location = new System.Drawing.Point(113, 95);
            this.cmbTedarikciIDFerdi.Name = "cmbTedarikciIDFerdi";
            this.cmbTedarikciIDFerdi.Size = new System.Drawing.Size(121, 21);
            this.cmbTedarikciIDFerdi.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Soyad";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Sexsiyyet No";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 21);
            this.label7.TabIndex = 7;
            this.label7.Text = "Adi";
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(113, 144);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(121, 20);
            this.txtAdi.TabIndex = 8;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(113, 185);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(121, 20);
            this.txtSoyad.TabIndex = 9;
            // 
            // mstSexsiyyet
            // 
            this.mstSexsiyyet.Location = new System.Drawing.Point(113, 226);
            this.mstSexsiyyet.Mask = "000000000000000";
            this.mstSexsiyyet.Name = "mstSexsiyyet";
            this.mstSexsiyyet.Size = new System.Drawing.Size(121, 20);
            this.mstSexsiyyet.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 302);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(365, 83);
            this.dataGridView1.TabIndex = 11;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(159, 261);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 35);
            this.btnEkle.TabIndex = 12;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // cmbTedarikciIDSirket
            // 
            this.cmbTedarikciIDSirket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTedarikciIDSirket.FormattingEnabled = true;
            this.cmbTedarikciIDSirket.Location = new System.Drawing.Point(539, 97);
            this.cmbTedarikciIDSirket.Name = "cmbTedarikciIDSirket";
            this.cmbTedarikciIDSirket.Size = new System.Drawing.Size(121, 21);
            this.cmbTedarikciIDSirket.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(431, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 21);
            this.label8.TabIndex = 13;
            this.label8.Text = "TedarikciID";
            // 
            // mskVoen
            // 
            this.mskVoen.Location = new System.Drawing.Point(539, 224);
            this.mskVoen.Mask = "000000000000000";
            this.mskVoen.Name = "mskVoen";
            this.mskVoen.Size = new System.Drawing.Size(121, 20);
            this.mskVoen.TabIndex = 20;
            // 
            // txtPersonelAd
            // 
            this.txtPersonelAd.Location = new System.Drawing.Point(539, 183);
            this.txtPersonelAd.Name = "txtPersonelAd";
            this.txtPersonelAd.Size = new System.Drawing.Size(121, 20);
            this.txtPersonelAd.TabIndex = 19;
            // 
            // txtSirketAdi
            // 
            this.txtSirketAdi.Location = new System.Drawing.Point(539, 142);
            this.txtSirketAdi.Name = "txtSirketAdi";
            this.txtSirketAdi.Size = new System.Drawing.Size(121, 20);
            this.txtSirketAdi.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(438, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 21);
            this.label9.TabIndex = 17;
            this.label9.Text = "Sirket Adi";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(438, 224);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 21);
            this.label10.TabIndex = 16;
            this.label10.Text = "Voen";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(438, 183);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 21);
            this.label11.TabIndex = 15;
            this.label11.Text = "Personel Ad";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(413, 302);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(365, 83);
            this.dataGridView2.TabIndex = 21;
            // 
            // btnSirketEkle
            // 
            this.btnSirketEkle.Location = new System.Drawing.Point(585, 261);
            this.btnSirketEkle.Name = "btnSirketEkle";
            this.btnSirketEkle.Size = new System.Drawing.Size(75, 35);
            this.btnSirketEkle.TabIndex = 22;
            this.btnSirketEkle.Text = "Ekle";
            this.btnSirketEkle.UseVisualStyleBackColor = true;
            this.btnSirketEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(763, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 30);
            this.button1.TabIndex = 35;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // TedarikciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(806, 393);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSirketEkle);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.mskVoen);
            this.Controls.Add(this.txtPersonelAd);
            this.Controls.Add(this.txtSirketAdi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbTedarikciIDSirket);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.mstSexsiyyet);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbTedarikciIDFerdi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TedarikciForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TedarikciForm";
            this.Load += new System.EventHandler(this.TedarikciForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTedarikciIDFerdi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.MaskedTextBox mstSexsiyyet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ComboBox cmbTedarikciIDSirket;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mskVoen;
        private System.Windows.Forms.TextBox txtPersonelAd;
        private System.Windows.Forms.TextBox txtSirketAdi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnSirketEkle;
        private System.Windows.Forms.Button button1;
    }
}