namespace LibraryWinFormsUI
{
    partial class TedarikciEkleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TedarikciEkleForm));
            this.button1 = new System.Windows.Forms.Button();
            this.cmbIletisim = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yeniIletisimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(293, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 30);
            this.button1.TabIndex = 36;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbIletisim
            // 
            this.cmbIletisim.ContextMenuStrip = this.contextMenuStrip2;
            this.cmbIletisim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIletisim.FormattingEnabled = true;
            this.cmbIletisim.Location = new System.Drawing.Point(86, 51);
            this.cmbIletisim.Name = "cmbIletisim";
            this.cmbIletisim.Size = new System.Drawing.Size(121, 21);
            this.cmbIletisim.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 21);
            this.label4.TabIndex = 38;
            this.label4.Text = "Iletisim";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(129, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 21);
            this.button2.TabIndex = 40;
            this.button2.Text = "Ferdi Veya Sirket Ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(259, 13);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(28, 26);
            this.button6.TabIndex = 41;
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
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
            // TedarikciEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(329, 131);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmbIletisim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TedarikciEkleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TedarikciEkleForm";
            this.Load += new System.EventHandler(this.TedarikciEkleForm_Load);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbIletisim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem yeniIletisimToolStripMenuItem;
    }
}