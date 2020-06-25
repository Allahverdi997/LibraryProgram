using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicalLayer;
using Entities.Models;

namespace LibraryWinFormsUI
{
    public partial class YaziciForm : Form
    {
        public YaziciForm()
        {
            InitializeComponent();
        }

        private void yeniIletisimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IletisimlerForm i = new IletisimlerForm();
            i.Show();
        }

        private void YaziciForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            dataGridView1.DataSource = Operations<Yazarlar>.SelectAll();

            cmbIletisimID.DataSource = Operations<Iletisimler>.SelectAll();
            cmbIletisimID.ValueMember = "Id";
            cmbIletisimID.DisplayMember = "Adresi";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Yazarlar y = new Yazarlar();
            y = Operations<Yazarlar>.EntityDoldur(y, txtAdi.Text, txtSoyadi.Text, txtHakkinda.Text, cmbIletisimID.SelectedValue);

            bool sonuc = Operations<Yazarlar>.Ekle(y);
            if (sonuc)
            {
                MessageBox.Show("Kayit Eklendi");
            }
            else
            {
                MessageBox.Show("Kayit Eklenemedi...");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
