namespace LibraryWinFormsUI
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iscilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iscileriGosterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iscilerinMelumatlariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kargolarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odunclerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satislarGeneralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satislarCiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satisRaporuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kATEGORIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tedarikciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musteriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iscilerToolStripMenuItem,
            this.kargolarToolStripMenuItem,
            this.odunclerToolStripMenuItem,
            this.satislarGeneralToolStripMenuItem,
            this.satislarCiroToolStripMenuItem,
            this.raporlarToolStripMenuItem,
            this.kATEGORIToolStripMenuItem,
            this.tedarikciToolStripMenuItem,
            this.yazarlarToolStripMenuItem,
            this.musteriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1104, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iscilerToolStripMenuItem
            // 
            this.iscilerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iscileriGosterToolStripMenuItem,
            this.iscilerinMelumatlariToolStripMenuItem});
            this.iscilerToolStripMenuItem.Name = "iscilerToolStripMenuItem";
            this.iscilerToolStripMenuItem.Size = new System.Drawing.Size(62, 25);
            this.iscilerToolStripMenuItem.Text = "Isciler";
            // 
            // iscileriGosterToolStripMenuItem
            // 
            this.iscileriGosterToolStripMenuItem.Name = "iscileriGosterToolStripMenuItem";
            this.iscileriGosterToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.iscileriGosterToolStripMenuItem.Text = "Iscileri Goster";
            this.iscileriGosterToolStripMenuItem.Click += new System.EventHandler(this.iscileriGosterToolStripMenuItem_Click);
            // 
            // iscilerinMelumatlariToolStripMenuItem
            // 
            this.iscilerinMelumatlariToolStripMenuItem.Name = "iscilerinMelumatlariToolStripMenuItem";
            this.iscilerinMelumatlariToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.iscilerinMelumatlariToolStripMenuItem.Text = "Iscilerin Melumatlari";
            this.iscilerinMelumatlariToolStripMenuItem.Click += new System.EventHandler(this.iscilerinMelumatlariToolStripMenuItem_Click);
            // 
            // kargolarToolStripMenuItem
            // 
            this.kargolarToolStripMenuItem.Name = "kargolarToolStripMenuItem";
            this.kargolarToolStripMenuItem.Size = new System.Drawing.Size(81, 25);
            this.kargolarToolStripMenuItem.Text = "Kargolar";
            this.kargolarToolStripMenuItem.Click += new System.EventHandler(this.kargolarToolStripMenuItem_Click);
            // 
            // odunclerToolStripMenuItem
            // 
            this.odunclerToolStripMenuItem.Name = "odunclerToolStripMenuItem";
            this.odunclerToolStripMenuItem.Size = new System.Drawing.Size(86, 25);
            this.odunclerToolStripMenuItem.Text = "Oduncler";
            this.odunclerToolStripMenuItem.Click += new System.EventHandler(this.odunclerToolStripMenuItem_Click);
            // 
            // satislarGeneralToolStripMenuItem
            // 
            this.satislarGeneralToolStripMenuItem.Name = "satislarGeneralToolStripMenuItem";
            this.satislarGeneralToolStripMenuItem.Size = new System.Drawing.Size(131, 25);
            this.satislarGeneralToolStripMenuItem.Text = "Satislar General";
            this.satislarGeneralToolStripMenuItem.Click += new System.EventHandler(this.satislarGeneralToolStripMenuItem_Click);
            // 
            // satislarCiroToolStripMenuItem
            // 
            this.satislarCiroToolStripMenuItem.Name = "satislarCiroToolStripMenuItem";
            this.satislarCiroToolStripMenuItem.Size = new System.Drawing.Size(106, 25);
            this.satislarCiroToolStripMenuItem.Text = "Satislar Ciro";
            this.satislarCiroToolStripMenuItem.Click += new System.EventHandler(this.satislarCiroToolStripMenuItem_Click);
            // 
            // raporlarToolStripMenuItem
            // 
            this.raporlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.satisRaporuToolStripMenuItem});
            this.raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            this.raporlarToolStripMenuItem.Size = new System.Drawing.Size(82, 25);
            this.raporlarToolStripMenuItem.Text = "Raporlar";
            // 
            // satisRaporuToolStripMenuItem
            // 
            this.satisRaporuToolStripMenuItem.Name = "satisRaporuToolStripMenuItem";
            this.satisRaporuToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.satisRaporuToolStripMenuItem.Text = "Satis Raporu";
            this.satisRaporuToolStripMenuItem.Click += new System.EventHandler(this.satisRaporuToolStripMenuItem_Click);
            // 
            // kATEGORIToolStripMenuItem
            // 
            this.kATEGORIToolStripMenuItem.Name = "kATEGORIToolStripMenuItem";
            this.kATEGORIToolStripMenuItem.Size = new System.Drawing.Size(80, 25);
            this.kATEGORIToolStripMenuItem.Text = "Kategori";
            this.kATEGORIToolStripMenuItem.Click += new System.EventHandler(this.kATEGORIToolStripMenuItem_Click);
            // 
            // tedarikciToolStripMenuItem
            // 
            this.tedarikciToolStripMenuItem.Name = "tedarikciToolStripMenuItem";
            this.tedarikciToolStripMenuItem.Size = new System.Drawing.Size(82, 25);
            this.tedarikciToolStripMenuItem.Text = "Tedarikci";
            this.tedarikciToolStripMenuItem.Click += new System.EventHandler(this.tedarikciToolStripMenuItem_Click);
            // 
            // yazarlarToolStripMenuItem
            // 
            this.yazarlarToolStripMenuItem.Name = "yazarlarToolStripMenuItem";
            this.yazarlarToolStripMenuItem.Size = new System.Drawing.Size(77, 25);
            this.yazarlarToolStripMenuItem.Text = "Yazarlar";
            this.yazarlarToolStripMenuItem.Click += new System.EventHandler(this.yazarlarToolStripMenuItem_Click);
            // 
            // musteriToolStripMenuItem
            // 
            this.musteriToolStripMenuItem.Name = "musteriToolStripMenuItem";
            this.musteriToolStripMenuItem.Size = new System.Drawing.Size(75, 25);
            this.musteriToolStripMenuItem.Text = "Musteri";
            this.musteriToolStripMenuItem.Click += new System.EventHandler(this.musteriToolStripMenuItem_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(1007, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(47, 24);
            this.button5.TabIndex = 37;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1060, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 24);
            this.button1.TabIndex = 36;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1104, 472);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iscilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iscileriGosterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iscilerinMelumatlariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kargolarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odunclerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satislarGeneralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satislarCiroToolStripMenuItem;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem raporlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satisRaporuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kATEGORIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tedarikciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musteriToolStripMenuItem;
    }
}