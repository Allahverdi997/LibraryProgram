namespace LibraryWinFormsUI
{
    partial class SatislarForm
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
            this.dtpSatisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMusteriID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbKitabID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbIsciID = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbKargoID = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(366, 98);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 64;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dtpSatisTarihi
            // 
            this.dtpSatisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSatisTarihi.Location = new System.Drawing.Point(347, 54);
            this.dtpSatisTarihi.Name = "dtpSatisTarihi";
            this.dtpSatisTarihi.Size = new System.Drawing.Size(112, 20);
            this.dtpSatisTarihi.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(254, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 26);
            this.label3.TabIndex = 60;
            this.label3.Text = "Satis Tarixi:";
            // 
            // cmbMusteriID
            // 
            this.cmbMusteriID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMusteriID.FormattingEnabled = true;
            this.cmbMusteriID.Location = new System.Drawing.Point(71, 95);
            this.cmbMusteriID.Name = "cmbMusteriID";
            this.cmbMusteriID.Size = new System.Drawing.Size(112, 21);
            this.cmbMusteriID.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 26);
            this.label2.TabIndex = 58;
            this.label2.Text = "Musteri:";
            // 
            // cmbKitabID
            // 
            this.cmbKitabID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKitabID.FormattingEnabled = true;
            this.cmbKitabID.Location = new System.Drawing.Point(71, 53);
            this.cmbKitabID.Name = "cmbKitabID";
            this.cmbKitabID.Size = new System.Drawing.Size(112, 21);
            this.cmbKitabID.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 26);
            this.label1.TabIndex = 56;
            this.label1.Text = "Kitab:";
            // 
            // cmbIsciID
            // 
            this.cmbIsciID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIsciID.FormattingEnabled = true;
            this.cmbIsciID.Location = new System.Drawing.Point(71, 11);
            this.cmbIsciID.Name = "cmbIsciID";
            this.cmbIsciID.Size = new System.Drawing.Size(112, 21);
            this.cmbIsciID.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 26);
            this.label4.TabIndex = 54;
            this.label4.Text = "Isci:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(591, 244);
            this.dataGridView1.TabIndex = 53;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(577, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 24);
            this.button1.TabIndex = 52;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbKargoID
            // 
            this.cmbKargoID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKargoID.FormattingEnabled = true;
            this.cmbKargoID.Location = new System.Drawing.Point(347, 11);
            this.cmbKargoID.Name = "cmbKargoID";
            this.cmbKargoID.Size = new System.Drawing.Size(112, 21);
            this.cmbKargoID.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(289, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 26);
            this.label5.TabIndex = 65;
            this.label5.Text = "Kargo:";
            // 
            // SatislarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(620, 386);
            this.Controls.Add(this.cmbKargoID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dtpSatisTarihi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbMusteriID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbKitabID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbIsciID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SatislarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SatislarForm";
            this.Load += new System.EventHandler(this.SatislarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DateTimePicker dtpSatisTarihi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMusteriID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbKitabID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbIsciID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbKargoID;
        private System.Windows.Forms.Label label5;
    }
}