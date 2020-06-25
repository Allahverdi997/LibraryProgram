namespace LibraryWinFormsUI
{
    partial class YaziciForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YaziciForm));
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbIletisimID = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yeniIletisimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHakkinda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(70, 76);
            this.txtAdi.Multiline = true;
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(124, 21);
            this.txtAdi.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Adı";
            // 
            // cmbIletisimID
            // 
            this.cmbIletisimID.ContextMenuStrip = this.contextMenuStrip1;
            this.cmbIletisimID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIletisimID.FormattingEnabled = true;
            this.cmbIletisimID.Location = new System.Drawing.Point(312, 124);
            this.cmbIletisimID.Name = "cmbIletisimID";
            this.cmbIletisimID.Size = new System.Drawing.Size(124, 21);
            this.cmbIletisimID.TabIndex = 9;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniIletisimToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(138, 26);
            // 
            // yeniIletisimToolStripMenuItem
            // 
            this.yeniIletisimToolStripMenuItem.Name = "yeniIletisimToolStripMenuItem";
            this.yeniIletisimToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.yeniIletisimToolStripMenuItem.Text = "Yeni Iletisim";
            this.yeniIletisimToolStripMenuItem.Click += new System.EventHandler(this.yeniIletisimToolStripMenuItem_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(246, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Iletisimi";
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(302, 76);
            this.txtSoyadi.Multiline = true;
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(134, 21);
            this.txtSoyadi.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(254, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Soyadi";
            // 
            // txtHakkinda
            // 
            this.txtHakkinda.Location = new System.Drawing.Point(70, 127);
            this.txtHakkinda.Multiline = true;
            this.txtHakkinda.Name = "txtHakkinda";
            this.txtHakkinda.Size = new System.Drawing.Size(134, 75);
            this.txtHakkinda.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Hakkinda";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(339, 151);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(97, 51);
            this.btnEkle.TabIndex = 15;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(444, 48);
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
            this.button5.Location = new System.Drawing.Point(401, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(47, 30);
            this.button5.TabIndex = 35;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(454, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 30);
            this.button1.TabIndex = 34;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 223);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(471, 260);
            this.dataGridView1.TabIndex = 37;
            // 
            // YaziciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(495, 515);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtHakkinda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSoyadi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbIletisimID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "YaziciForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YaziciForm";
            this.Load += new System.EventHandler(this.YaziciForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbIletisimID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHakkinda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yeniIletisimToolStripMenuItem;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}