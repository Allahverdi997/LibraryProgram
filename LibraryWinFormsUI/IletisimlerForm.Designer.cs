namespace LibraryWinFormsUI
{
    partial class IletisimlerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IletisimlerForm));
            this.label1 = new System.Windows.Forms.Label();
            this.mtxTelefonNo = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtWebSitesi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mtxPosta = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "TelefonNo:";
            // 
            // mtxTelefonNo
            // 
            this.mtxTelefonNo.Location = new System.Drawing.Point(112, 52);
            this.mtxTelefonNo.Mask = "000-000-0000";
            this.mtxTelefonNo.Name = "mtxTelefonNo";
            this.mtxTelefonNo.Size = new System.Drawing.Size(100, 20);
            this.mtxTelefonNo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adresi:";
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(112, 95);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(100, 20);
            this.txtAdress.TabIndex = 3;
            // 
            // txtWebSitesi
            // 
            this.txtWebSitesi.Location = new System.Drawing.Point(112, 143);
            this.txtWebSitesi.Name = "txtWebSitesi";
            this.txtWebSitesi.Size = new System.Drawing.Size(100, 20);
            this.txtWebSitesi.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Web Sitesi:";
            // 
            // mtxPosta
            // 
            this.mtxPosta.Location = new System.Drawing.Point(112, 189);
            this.mtxPosta.Mask = "000000000000000";
            this.mtxPosta.Name = "mtxPosta";
            this.mtxPosta.Size = new System.Drawing.Size(100, 20);
            this.mtxPosta.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "PostaKodu:";
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
            this.btnInsert.Location = new System.Drawing.Point(112, 224);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(100, 31);
            this.btnInsert.TabIndex = 28;
            this.btnInsert.Text = "Ekle";
            this.btnInsert.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(215, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 30);
            this.button1.TabIndex = 35;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // IletisimlerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(258, 272);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.mtxPosta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtWebSitesi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtxTelefonNo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IletisimlerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IletisimlerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtxTelefonNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox txtWebSitesi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtxPosta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button button1;
    }
}