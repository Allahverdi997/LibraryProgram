namespace LibraryWinFormsUI
{
    partial class OkuyucularForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OkuyucularForm));
            this.lblIsci = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkKadin = new System.Windows.Forms.CheckBox();
            this.chkErkek = new System.Windows.Forms.CheckBox();
            this.mtxSexsiyyetNo = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpQeydiyyatTarixi = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtOkuyucuAdi = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbIletisimID = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yeniIletisimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtOkuyucuSoyad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbArama = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIsci
            // 
            this.lblIsci.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsci.ForeColor = System.Drawing.Color.White;
            this.lblIsci.Location = new System.Drawing.Point(189, 9);
            this.lblIsci.Name = "lblIsci";
            this.lblIsci.Size = new System.Drawing.Size(148, 31);
            this.lblIsci.TabIndex = 36;
            this.lblIsci.Text = "1";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(976, 52);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(41, 38);
            this.button6.TabIndex = 41;
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 250);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1005, 238);
            this.dataGridView1.TabIndex = 40;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(933, 16);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(47, 30);
            this.button5.TabIndex = 39;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.mtxSexsiyyetNo);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.dtpQeydiyyatTarixi);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.dtpDogumTarihi);
            this.groupBox2.Controls.Add(this.txtOkuyucuAdi);
            this.groupBox2.Controls.Add(this.btnGuncelle);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmbIletisimID);
            this.groupBox2.Controls.Add(this.btnInsert);
            this.groupBox2.Controls.Add(this.txtOkuyucuSoyad);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1005, 104);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkKadin);
            this.groupBox3.Controls.Add(this.chkErkek);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(224, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(192, 43);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cinsiyyet";
            // 
            // chkKadin
            // 
            this.chkKadin.AutoSize = true;
            this.chkKadin.Location = new System.Drawing.Point(109, 18);
            this.chkKadin.Name = "chkKadin";
            this.chkKadin.Size = new System.Drawing.Size(53, 17);
            this.chkKadin.TabIndex = 27;
            this.chkKadin.Text = "Kadin";
            this.chkKadin.UseVisualStyleBackColor = true;
            // 
            // chkErkek
            // 
            this.chkErkek.AutoSize = true;
            this.chkErkek.Location = new System.Drawing.Point(20, 19);
            this.chkErkek.Name = "chkErkek";
            this.chkErkek.Size = new System.Drawing.Size(54, 17);
            this.chkErkek.TabIndex = 26;
            this.chkErkek.Text = "Erkek";
            this.chkErkek.UseVisualStyleBackColor = true;
            this.chkErkek.CheckedChanged += new System.EventHandler(this.chkErkek_CheckedChanged);
            // 
            // mtxSexsiyyetNo
            // 
            this.mtxSexsiyyetNo.Location = new System.Drawing.Point(331, 68);
            this.mtxSexsiyyetNo.Mask = "0000000000000";
            this.mtxSexsiyyetNo.Name = "mtxSexsiyyetNo";
            this.mtxSexsiyyetNo.Size = new System.Drawing.Size(85, 20);
            this.mtxSexsiyyetNo.TabIndex = 31;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(221, 68);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(114, 20);
            this.label14.TabIndex = 30;
            this.label14.Text = "Sexsiyyet Nomresi";
            // 
            // dtpQeydiyyatTarixi
            // 
            this.dtpQeydiyyatTarixi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpQeydiyyatTarixi.Location = new System.Drawing.Point(546, 62);
            this.dtpQeydiyyatTarixi.Name = "dtpQeydiyyatTarixi";
            this.dtpQeydiyyatTarixi.Size = new System.Drawing.Size(95, 20);
            this.dtpQeydiyyatTarixi.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(448, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 17);
            this.label12.TabIndex = 28;
            this.label12.Text = "Qeydiyyat Tarihi";
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDogumTarihi.Location = new System.Drawing.Point(546, 23);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(95, 20);
            this.dtpDogumTarihi.TabIndex = 25;
            // 
            // txtOkuyucuAdi
            // 
            this.txtOkuyucuAdi.Location = new System.Drawing.Point(56, 26);
            this.txtOkuyucuAdi.Multiline = true;
            this.txtOkuyucuAdi.Name = "txtOkuyucuAdi";
            this.txtOkuyucuAdi.Size = new System.Drawing.Size(134, 21);
            this.txtOkuyucuAdi.TabIndex = 24;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.btnGuncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.BackgroundImage")));
            this.btnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnGuncelle.Location = new System.Drawing.Point(912, 19);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(71, 66);
            this.btnGuncelle.TabIndex = 21;
            this.btnGuncelle.Text = "Guncelle";
            this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(448, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Dogum Tarihi";
            // 
            // cmbIletisimID
            // 
            this.cmbIletisimID.ContextMenuStrip = this.contextMenuStrip2;
            this.cmbIletisimID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIletisimID.FormattingEnabled = true;
            this.cmbIletisimID.Location = new System.Drawing.Point(673, 43);
            this.cmbIletisimID.Name = "cmbIletisimID";
            this.cmbIletisimID.Size = new System.Drawing.Size(97, 21);
            this.cmbIletisimID.TabIndex = 15;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniIletisimToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(138, 26);
            // 
            // yeniIletisimToolStripMenuItem
            // 
            this.yeniIletisimToolStripMenuItem.Name = "yeniIletisimToolStripMenuItem";
            this.yeniIletisimToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.yeniIletisimToolStripMenuItem.Text = "Yeni Iletisim";
            this.yeniIletisimToolStripMenuItem.Click += new System.EventHandler(this.yeniIletisimToolStripMenuItem_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Transparent;
            this.btnInsert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInsert.BackgroundImage")));
            this.btnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInsert.Location = new System.Drawing.Point(819, 19);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(87, 68);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "Ekle";
            this.btnInsert.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtOkuyucuSoyad
            // 
            this.txtOkuyucuSoyad.Location = new System.Drawing.Point(56, 65);
            this.txtOkuyucuSoyad.Multiline = true;
            this.txtOkuyucuSoyad.Name = "txtOkuyucuSoyad";
            this.txtOkuyucuSoyad.Size = new System.Drawing.Size(134, 21);
            this.txtOkuyucuSoyad.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(670, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Iletisim Adress";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyadı";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Adi";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtArama);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbArama);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 78);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arama Yap:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Location = new System.Drawing.Point(345, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(41, 38);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(191, 34);
            this.txtArama.Multiline = true;
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(134, 21);
            this.txtArama.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(198, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Arama Turu";
            // 
            // cmbArama
            // 
            this.cmbArama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArama.FormattingEnabled = true;
            this.cmbArama.Location = new System.Drawing.Point(9, 34);
            this.cmbArama.Name = "cmbArama";
            this.cmbArama.Size = new System.Drawing.Size(142, 21);
            this.cmbArama.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arama Turu";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(986, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 30);
            this.button1.TabIndex = 34;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(87, 26);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // OkuyucularForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1034, 496);
            this.Controls.Add(this.lblIsci);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OkuyucularForm";
            this.Text = "OkuyucularForm";
            this.Load += new System.EventHandler(this.OkuyucularForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblIsci;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOkuyucuSoyad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbArama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox mtxSexsiyyetNo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtpQeydiyyatTarixi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox chkKadin;
        private System.Windows.Forms.CheckBox chkErkek;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.TextBox txtOkuyucuAdi;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbIletisimID;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem yeniIletisimToolStripMenuItem;
    }
}