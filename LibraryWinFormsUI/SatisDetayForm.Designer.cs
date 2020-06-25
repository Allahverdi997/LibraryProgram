namespace LibraryWinFormsUI
{
    partial class SatisDetayForm
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.cmbSatisID = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nudMiktar = new System.Windows.Forms.NumericUpDown();
            this.nudFiyat = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudIndirim = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMiktar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIndirim)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(478, 86);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 77;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // cmbSatisID
            // 
            this.cmbSatisID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSatisID.FormattingEnabled = true;
            this.cmbSatisID.Location = new System.Drawing.Point(68, 43);
            this.cmbSatisID.Name = "cmbSatisID";
            this.cmbSatisID.Size = new System.Drawing.Size(112, 21);
            this.cmbSatisID.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 26);
            this.label4.TabIndex = 69;
            this.label4.Text = "Satis:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(591, 244);
            this.dataGridView1.TabIndex = 68;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(626, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 24);
            this.button1.TabIndex = 67;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(217, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 26);
            this.label2.TabIndex = 78;
            this.label2.Text = "Mitari:";
            // 
            // nudMiktar
            // 
            this.nudMiktar.Location = new System.Drawing.Point(275, 45);
            this.nudMiktar.Name = "nudMiktar";
            this.nudMiktar.Size = new System.Drawing.Size(82, 20);
            this.nudMiktar.TabIndex = 79;
            // 
            // nudFiyat
            // 
            this.nudFiyat.Location = new System.Drawing.Point(275, 86);
            this.nudFiyat.Name = "nudFiyat";
            this.nudFiyat.Size = new System.Drawing.Size(82, 20);
            this.nudFiyat.TabIndex = 81;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(217, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 26);
            this.label3.TabIndex = 80;
            this.label3.Text = "Fiyati:";
            // 
            // nudIndirim
            // 
            this.nudIndirim.Location = new System.Drawing.Point(471, 45);
            this.nudIndirim.Name = "nudIndirim";
            this.nudIndirim.Size = new System.Drawing.Size(82, 20);
            this.nudIndirim.TabIndex = 83;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(403, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 26);
            this.label5.TabIndex = 82;
            this.label5.Text = "Indirimi:";
            // 
            // SatisDetayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(718, 412);
            this.Controls.Add(this.nudIndirim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudFiyat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudMiktar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.cmbSatisID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SatisDetayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SatisDetayForm";
            this.Load += new System.EventHandler(this.SatisDetayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMiktar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIndirim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ComboBox cmbSatisID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudMiktar;
        private System.Windows.Forms.NumericUpDown nudFiyat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudIndirim;
        private System.Windows.Forms.Label label5;
    }
}