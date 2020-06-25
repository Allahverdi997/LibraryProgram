namespace LibraryWinFormsUI
{
    partial class KitablarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitablarForm));
            this.lblIsci = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbSirketTedarikciID = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.cmbYazarID = new System.Windows.Forms.ComboBox();
            this.nudFiyati = new System.Windows.Forms.NumericUpDown();
            this.nudMiktar = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudVereqSayi = new System.Windows.Forms.NumericUpDown();
            this.txtKitabAciklamasi = new System.Windows.Forms.TextBox();
            this.cmbKategoriID = new System.Windows.Forms.ComboBox();
            this.txtYayinEvi = new System.Windows.Forms.TextBox();
            this.txtKitabAdi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mtxBarkodNo = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbFerdiAdTedarikciID = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbArama = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFiyati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMiktar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVereqSayi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIsci
            // 
            this.lblIsci.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsci.ForeColor = System.Drawing.Color.White;
            this.lblIsci.Location = new System.Drawing.Point(99, 9);
            this.lblIsci.Name = "lblIsci";
            this.lblIsci.Size = new System.Drawing.Size(148, 31);
            this.lblIsci.TabIndex = 28;
            this.lblIsci.Text = "1";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(1028, 40);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(41, 38);
            this.button6.TabIndex = 33;
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(7, 324);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1067, 232);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(985, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(47, 30);
            this.button5.TabIndex = 31;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.cmbSirketTedarikciID);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnGuncelle);
            this.groupBox2.Controls.Add(this.btnInsert);
            this.groupBox2.Controls.Add(this.cmbYazarID);
            this.groupBox2.Controls.Add(this.nudFiyati);
            this.groupBox2.Controls.Add(this.nudMiktar);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.nudVereqSayi);
            this.groupBox2.Controls.Add(this.txtKitabAciklamasi);
            this.groupBox2.Controls.Add(this.cmbKategoriID);
            this.groupBox2.Controls.Add(this.txtYayinEvi);
            this.groupBox2.Controls.Add(this.txtKitabAdi);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.mtxBarkodNo);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cmbFerdiAdTedarikciID);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(7, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1067, 179);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            // 
            // cmbSirketTedarikciID
            // 
            this.cmbSirketTedarikciID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSirketTedarikciID.FormattingEnabled = true;
            this.cmbSirketTedarikciID.Location = new System.Drawing.Point(795, 76);
            this.cmbSirketTedarikciID.Name = "cmbSirketTedarikciID";
            this.cmbSirketTedarikciID.Size = new System.Drawing.Size(124, 21);
            this.cmbSirketTedarikciID.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(699, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 14);
            this.label6.TabIndex = 22;
            this.label6.Text = "SirketTedarikcisi";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.btnGuncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.BackgroundImage")));
            this.btnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnGuncelle.Location = new System.Drawing.Point(951, 93);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(86, 80);
            this.btnGuncelle.TabIndex = 21;
            this.btnGuncelle.Text = "Guncelle";
            this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.button3_Click);
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
            this.btnInsert.Location = new System.Drawing.Point(951, 16);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(86, 78);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "Ekle";
            this.btnInsert.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // cmbYazarID
            // 
            this.cmbYazarID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYazarID.FormattingEnabled = true;
            this.cmbYazarID.Location = new System.Drawing.Point(551, 25);
            this.cmbYazarID.Name = "cmbYazarID";
            this.cmbYazarID.Size = new System.Drawing.Size(124, 21);
            this.cmbYazarID.TabIndex = 5;
            // 
            // nudFiyati
            // 
            this.nudFiyati.Location = new System.Drawing.Point(547, 130);
            this.nudFiyati.Maximum = new decimal(new int[] {
            651588039,
            2587007,
            0,
            0});
            this.nudFiyati.Name = "nudFiyati";
            this.nudFiyati.Size = new System.Drawing.Size(58, 20);
            this.nudFiyati.TabIndex = 20;
            // 
            // nudMiktar
            // 
            this.nudMiktar.Location = new System.Drawing.Point(785, 128);
            this.nudMiktar.Maximum = new decimal(new int[] {
            415003079,
            100267741,
            6,
            0});
            this.nudMiktar.Name = "nudMiktar";
            this.nudMiktar.Size = new System.Drawing.Size(124, 20);
            this.nudMiktar.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(485, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Yazar Adi";
            // 
            // nudVereqSayi
            // 
            this.nudVereqSayi.Location = new System.Drawing.Point(321, 72);
            this.nudVereqSayi.Maximum = new decimal(new int[] {
            -1285418553,
            258,
            0,
            0});
            this.nudVereqSayi.Name = "nudVereqSayi";
            this.nudVereqSayi.Size = new System.Drawing.Size(134, 20);
            this.nudVereqSayi.TabIndex = 18;
            // 
            // txtKitabAciklamasi
            // 
            this.txtKitabAciklamasi.Location = new System.Drawing.Point(109, 119);
            this.txtKitabAciklamasi.Multiline = true;
            this.txtKitabAciklamasi.Name = "txtKitabAciklamasi";
            this.txtKitabAciklamasi.Size = new System.Drawing.Size(328, 49);
            this.txtKitabAciklamasi.TabIndex = 17;
            // 
            // cmbKategoriID
            // 
            this.cmbKategoriID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategoriID.FormattingEnabled = true;
            this.cmbKategoriID.Location = new System.Drawing.Point(552, 73);
            this.cmbKategoriID.Name = "cmbKategoriID";
            this.cmbKategoriID.Size = new System.Drawing.Size(123, 21);
            this.cmbKategoriID.TabIndex = 15;
            // 
            // txtYayinEvi
            // 
            this.txtYayinEvi.Location = new System.Drawing.Point(109, 73);
            this.txtYayinEvi.Multiline = true;
            this.txtYayinEvi.Name = "txtYayinEvi";
            this.txtYayinEvi.Size = new System.Drawing.Size(116, 21);
            this.txtYayinEvi.TabIndex = 13;
            // 
            // txtKitabAdi
            // 
            this.txtKitabAdi.Location = new System.Drawing.Point(321, 26);
            this.txtKitabAdi.Multiline = true;
            this.txtKitabAdi.Name = "txtKitabAdi";
            this.txtKitabAdi.Size = new System.Drawing.Size(134, 21);
            this.txtKitabAdi.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(480, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Kitab Növü";
            // 
            // mtxBarkodNo
            // 
            this.mtxBarkodNo.Location = new System.Drawing.Point(109, 26);
            this.mtxBarkodNo.Mask = "0000000000000";
            this.mtxBarkodNo.Name = "mtxBarkodNo";
            this.mtxBarkodNo.Size = new System.Drawing.Size(88, 20);
            this.mtxBarkodNo.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(17, 122);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 15);
            this.label13.TabIndex = 11;
            this.label13.Text = "Aciklamasi";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(699, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 14);
            this.label11.TabIndex = 9;
            this.label11.Text = "FerdTedarikcisi";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(31, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 18);
            this.label12.TabIndex = 10;
            this.label12.Text = "Yayin Evi";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(481, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 26);
            this.label10.TabIndex = 8;
            this.label10.Text = "Qiyməti";
            // 
            // cmbFerdiAdTedarikciID
            // 
            this.cmbFerdiAdTedarikciID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFerdiAdTedarikciID.FormattingEnabled = true;
            this.cmbFerdiAdTedarikciID.Location = new System.Drawing.Point(795, 23);
            this.cmbFerdiAdTedarikciID.Name = "cmbFerdiAdTedarikciID";
            this.cmbFerdiAdTedarikciID.Size = new System.Drawing.Size(124, 21);
            this.cmbFerdiAdTedarikciID.TabIndex = 14;
            this.cmbFerdiAdTedarikciID.SelectedIndexChanged += new System.EventHandler(this.cmbFerdiAdTedarikciID_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(717, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Miqdar";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(252, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Səhifə Sayı";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(273, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adı";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Barkod Nomrəsi";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtArama);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbArama);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(7, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 78);
            this.groupBox1.TabIndex = 27;
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
            this.button1.Location = new System.Drawing.Point(1038, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 30);
            this.button1.TabIndex = 26;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // KitablarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1081, 568);
            this.Controls.Add(this.lblIsci);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KitablarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KitablarForm";
            this.Load += new System.EventHandler(this.KitablarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFiyati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMiktar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVereqSayi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.NumericUpDown nudFiyati;
        private System.Windows.Forms.NumericUpDown nudMiktar;
        private System.Windows.Forms.NumericUpDown nudVereqSayi;
        private System.Windows.Forms.TextBox txtKitabAciklamasi;
        private System.Windows.Forms.ComboBox cmbKategoriID;
        private System.Windows.Forms.ComboBox cmbFerdiAdTedarikciID;
        private System.Windows.Forms.TextBox txtYayinEvi;
        private System.Windows.Forms.ComboBox cmbYazarID;
        private System.Windows.Forms.TextBox txtKitabAdi;
        private System.Windows.Forms.MaskedTextBox mtxBarkodNo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbArama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbSirketTedarikciID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
    }
}