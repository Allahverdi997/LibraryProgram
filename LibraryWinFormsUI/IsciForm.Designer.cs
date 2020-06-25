namespace LibraryWinFormsUI
{
    partial class IsciForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IsciForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtIsciAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudMaas = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIsciSoyadi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbIletisimler = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yeniIletisimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaas)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(16, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(740, 279);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtIsciAdi
            // 
            this.txtIsciAdi.Location = new System.Drawing.Point(79, 58);
            this.txtIsciAdi.Multiline = true;
            this.txtIsciAdi.Name = "txtIsciAdi";
            this.txtIsciAdi.Size = new System.Drawing.Size(134, 21);
            this.txtIsciAdi.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "IsciAdi:";
            // 
            // nudMaas
            // 
            this.nudMaas.Location = new System.Drawing.Point(331, 56);
            this.nudMaas.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudMaas.Name = "nudMaas";
            this.nudMaas.Size = new System.Drawing.Size(58, 20);
            this.nudMaas.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(245, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 26);
            this.label10.TabIndex = 21;
            this.label10.Text = "Maasi:";
            // 
            // txtIsciSoyadi
            // 
            this.txtIsciSoyadi.Location = new System.Drawing.Point(79, 103);
            this.txtIsciSoyadi.Multiline = true;
            this.txtIsciSoyadi.Name = "txtIsciSoyadi";
            this.txtIsciSoyadi.Size = new System.Drawing.Size(134, 21);
            this.txtIsciSoyadi.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "IsciSoyadi:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(243, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "DogumTarihi:";
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDogumTarihi.Location = new System.Drawing.Point(331, 104);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(83, 20);
            this.dtpDogumTarihi.TabIndex = 26;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.btnGuncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.BackgroundImage")));
            this.btnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnGuncelle.Location = new System.Drawing.Point(475, 99);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(86, 30);
            this.btnGuncelle.TabIndex = 28;
            this.btnGuncelle.Text = "Guncelle";
            this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
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
            this.btnInsert.Location = new System.Drawing.Point(573, 99);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(86, 31);
            this.btnInsert.TabIndex = 27;
            this.btnInsert.Text = "Ekle";
            this.btnInsert.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(715, 41);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(41, 38);
            this.button6.TabIndex = 36;
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
            this.button5.Location = new System.Drawing.Point(672, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(47, 30);
            this.button5.TabIndex = 35;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(725, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 30);
            this.button1.TabIndex = 34;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(472, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 26);
            this.label4.TabIndex = 37;
            this.label4.Text = "Iletisimi:";
            // 
            // cmbIletisimler
            // 
            this.cmbIletisimler.ContextMenuStrip = this.contextMenuStrip2;
            this.cmbIletisimler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIletisimler.FormattingEnabled = true;
            this.cmbIletisimler.Location = new System.Drawing.Point(528, 50);
            this.cmbIletisimler.Name = "cmbIletisimler";
            this.cmbIletisimler.Size = new System.Drawing.Size(97, 21);
            this.cmbIletisimler.TabIndex = 39;
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
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniIletisimToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(141, 26);
            // 
            // yeniIletisimToolStripMenuItem
            // 
            this.yeniIletisimToolStripMenuItem.Name = "yeniIletisimToolStripMenuItem";
            this.yeniIletisimToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.yeniIletisimToolStripMenuItem.Text = "Yeni Iletisim ";
            this.yeniIletisimToolStripMenuItem.Click += new System.EventHandler(this.yeniIletisimToolStripMenuItem_Click);
            // 
            // IsciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(772, 427);
            this.Controls.Add(this.cmbIletisimler);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dtpDogumTarihi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIsciSoyadi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudMaas);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtIsciAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IsciForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IsciForm";
            this.Load += new System.EventHandler(this.IsciForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaas)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtIsciAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudMaas;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIsciSoyadi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbIletisimler;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem yeniIletisimToolStripMenuItem;
    }
}