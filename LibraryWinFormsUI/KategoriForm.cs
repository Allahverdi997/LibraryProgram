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
    public partial class KategoriForm : Form
    {
        public KategoriForm()
        {
            InitializeComponent();
        }

        private void KategoriForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            dataGridView1.DataSource = Operations<Kategoriler>.SelectAll();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Kategoriler k = new Kategoriler();
            k = Operations<Kategoriler>.EntityDoldur(k, txtAdi.Text, txtAciklamasi.Text);

            bool sonuc =Operations<Kategoriler>.Ekle(k);

            if (sonuc)
            {
                MessageBox.Show("Kayit Eklendi");
                Listele();
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
    }
}
