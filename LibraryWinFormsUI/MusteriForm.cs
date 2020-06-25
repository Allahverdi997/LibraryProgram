using BusinessLogicalLayer;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryWinFormsUI
{
    public partial class MusteriForm : Form
    {
        public MusteriForm()
        {
            InitializeComponent();
        }

        private void MusteriForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            dataGridView1.DataSource = Operations<Musteriler>.SelectAll();

            cmbIletisimID.DataSource = Operations<Iletisimler>.SelectAll();
            cmbIletisimID.ValueMember = "Id";
            cmbIletisimID.DisplayMember = "Adresi";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Musteriler m = new Musteriler();
            m = Operations<Musteriler>.EntityDoldur(m, txtAdi.Text, txtSoyadi.Text, mtxSexsiyyetNo.Text, cmbIletisimID.SelectedValue);

            bool sonuc = Operations<Musteriler>.Ekle(m);
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

        private void button6_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
