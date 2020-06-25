namespace LibraryWinFormsUI
{
    partial class OduncAlVerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OduncAlVerForm));
            this.dtpQaytarilmaTarihim = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpVerilmeTarixi = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.mtxBarkodNo = new System.Windows.Forms.MaskedTextBox();
            this.dtpQaytarilmaTarihi = new System.Windows.Forms.DateTimePicker();
            this.cmbMusteriID = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbKitabID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbIsciID = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbIsci = new System.Windows.Forms.ComboBox();
            this.chkTeslim = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.mtxKitab = new System.Windows.Forms.MaskedTextBox();
            this.cmbMusteri = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbKitab = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpQaytarilmaTarihim
            // 
            this.dtpQaytarilmaTarihim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpQaytarilmaTarihim.Location = new System.Drawing.Point(151, 130);
            this.dtpQaytarilmaTarihim.Name = "dtpQaytarilmaTarihim";
            this.dtpQaytarilmaTarihim.Size = new System.Drawing.Size(123, 20);
            this.dtpQaytarilmaTarihim.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(31, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 17);
            this.label5.TabIndex = 35;
            this.label5.Text = "Qaytarilma Tarixi:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Barkod No:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dtpVerilmeTarixi);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.mtxBarkodNo);
            this.groupBox1.Controls.Add(this.dtpQaytarilmaTarihi);
            this.groupBox1.Controls.Add(this.cmbMusteriID);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbKitabID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbIsciID);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 279);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Emanet Ver";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dtpVerilmeTarixi
            // 
            this.dtpVerilmeTarixi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVerilmeTarixi.Location = new System.Drawing.Point(136, 183);
            this.dtpVerilmeTarixi.Name = "dtpVerilmeTarixi";
            this.dtpVerilmeTarixi.Size = new System.Drawing.Size(123, 20);
            this.dtpVerilmeTarixi.TabIndex = 55;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(6, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 56);
            this.button1.TabIndex = 45;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 17);
            this.label3.TabIndex = 54;
            this.label3.Text = "Verilme Tarixi:";
            // 
            // mtxBarkodNo
            // 
            this.mtxBarkodNo.Location = new System.Drawing.Point(136, 130);
            this.mtxBarkodNo.Mask = "0000000000000";
            this.mtxBarkodNo.Name = "mtxBarkodNo";
            this.mtxBarkodNo.Size = new System.Drawing.Size(123, 20);
            this.mtxBarkodNo.TabIndex = 39;
            // 
            // dtpQaytarilmaTarihi
            // 
            this.dtpQaytarilmaTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpQaytarilmaTarihi.Location = new System.Drawing.Point(136, 157);
            this.dtpQaytarilmaTarihi.Name = "dtpQaytarilmaTarihi";
            this.dtpQaytarilmaTarihi.Size = new System.Drawing.Size(123, 20);
            this.dtpQaytarilmaTarihi.TabIndex = 53;
            // 
            // cmbMusteriID
            // 
            this.cmbMusteriID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMusteriID.FormattingEnabled = true;
            this.cmbMusteriID.Location = new System.Drawing.Point(136, 100);
            this.cmbMusteriID.Name = "cmbMusteriID";
            this.cmbMusteriID.Size = new System.Drawing.Size(123, 21);
            this.cmbMusteriID.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(16, 159);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 17);
            this.label12.TabIndex = 52;
            this.label12.Text = "Qaytarilma Tarixi:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Musteri:";
            // 
            // cmbKitabID
            // 
            this.cmbKitabID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKitabID.FormattingEnabled = true;
            this.cmbKitabID.Location = new System.Drawing.Point(136, 73);
            this.cmbKitabID.Name = "cmbKitabID";
            this.cmbKitabID.Size = new System.Drawing.Size(123, 21);
            this.cmbKitabID.TabIndex = 19;
            this.cmbKitabID.SelectedIndexChanged += new System.EventHandler(this.cmbKitabID_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Kitab:";
            // 
            // cmbIsciID
            // 
            this.cmbIsciID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIsciID.FormattingEnabled = true;
            this.cmbIsciID.Location = new System.Drawing.Point(136, 46);
            this.cmbIsciID.Name = "cmbIsciID";
            this.cmbIsciID.Size = new System.Drawing.Size(123, 21);
            this.cmbIsciID.TabIndex = 17;
            this.cmbIsciID.SelectedIndexChanged += new System.EventHandler(this.cmbIsciID_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(16, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "Isci:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 333);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(619, 155);
            this.dataGridView1.TabIndex = 45;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(637, 54);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(31, 38);
            this.button6.TabIndex = 49;
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(576, 18);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(47, 30);
            this.button5.TabIndex = 48;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(629, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 30);
            this.button2.TabIndex = 46;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.cmbIsci);
            this.groupBox2.Controls.Add(this.chkTeslim);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.mtxKitab);
            this.groupBox2.Controls.Add(this.cmbMusteri);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cmbKitab);
            this.groupBox2.Controls.Add(this.dtpQaytarilmaTarihim);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(302, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(329, 279);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "EmanetAl";
            // 
            // cmbIsci
            // 
            this.cmbIsci.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIsci.FormattingEnabled = true;
            this.cmbIsci.Location = new System.Drawing.Point(151, 100);
            this.cmbIsci.Name = "cmbIsci";
            this.cmbIsci.Size = new System.Drawing.Size(123, 21);
            this.cmbIsci.TabIndex = 51;
            // 
            // chkTeslim
            // 
            this.chkTeslim.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTeslim.Location = new System.Drawing.Point(98, 186);
            this.chkTeslim.Name = "chkTeslim";
            this.chkTeslim.Size = new System.Drawing.Size(170, 26);
            this.chkTeslim.TabIndex = 46;
            this.chkTeslim.Text = "Qaytarildi";
            this.chkTeslim.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(31, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 18);
            this.label10.TabIndex = 50;
            this.label10.Text = "Isci:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(12, 217);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(262, 55);
            this.button3.TabIndex = 45;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // mtxKitab
            // 
            this.mtxKitab.Location = new System.Drawing.Point(151, 160);
            this.mtxKitab.Mask = "0000000000000";
            this.mtxKitab.Name = "mtxKitab";
            this.mtxKitab.Size = new System.Drawing.Size(123, 20);
            this.mtxKitab.TabIndex = 39;
            // 
            // cmbMusteri
            // 
            this.cmbMusteri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMusteri.FormattingEnabled = true;
            this.cmbMusteri.Location = new System.Drawing.Point(151, 71);
            this.cmbMusteri.Name = "cmbMusteri";
            this.cmbMusteri.Size = new System.Drawing.Size(123, 21);
            this.cmbMusteri.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(31, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 18);
            this.label7.TabIndex = 20;
            this.label7.Text = "Musteri:";
            // 
            // cmbKitab
            // 
            this.cmbKitab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKitab.FormattingEnabled = true;
            this.cmbKitab.Location = new System.Drawing.Point(151, 44);
            this.cmbKitab.Name = "cmbKitab";
            this.cmbKitab.Size = new System.Drawing.Size(123, 21);
            this.cmbKitab.TabIndex = 19;
            this.cmbKitab.SelectedIndexChanged += new System.EventHandler(this.cmbKitab_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(31, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 18);
            this.label9.TabIndex = 18;
            this.label9.Text = "Kitab:";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(31, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 20);
            this.label11.TabIndex = 33;
            this.label11.Text = "Barkod No:";
            // 
            // OduncAlVerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(684, 500);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OduncAlVerForm";
            this.Text = "OduncAlVerForm";
            this.Load += new System.EventHandler(this.OduncAlVerForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpQaytarilmaTarihim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbIsciID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbMusteriID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbKitabID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox mtxBarkodNo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkTeslim;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MaskedTextBox mtxKitab;
        private System.Windows.Forms.ComboBox cmbMusteri;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbKitab;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbIsci;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpVerilmeTarixi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpQaytarilmaTarihi;
        private System.Windows.Forms.Label label12;
    }
}