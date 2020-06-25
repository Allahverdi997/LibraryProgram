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
    public partial class TedarikciForm : Form
    {
        public TedarikciForm()
        {
            InitializeComponent();
        }

        private void TedarikciForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            cmbTedarikciIDFerdi.DataSource = Operations<Tedarikciler>.SelectAll();
            cmbTedarikciIDFerdi.ValueMember = "TedarikciId";
            cmbTedarikciIDFerdi.DisplayMember = "TedarikciId";

            cmbTedarikciIDSirket.DataSource = Operations<Tedarikciler>.SelectAll();
            cmbTedarikciIDSirket.ValueMember = "TedarikciId";
            cmbTedarikciIDSirket.DisplayMember = "TedarikciId";

            dataGridView1.DataSource = Operations<FerdiTedarikci>.SelectAll();
            dataGridView2.DataSource = Operations<SirketTedarikci>.SelectAll();

            foreach (DataGridViewColumn dgc in dataGridView1.Columns)
            {
                if (dgc.DataPropertyName.Contains("ID"))
                {
                    dgc.Visible = false;
                }
            }

            foreach (DataGridViewColumn dgc in dataGridView2.Columns)
            {
                if (dgc.DataPropertyName.Contains("ID") || dgc.DataPropertyName.Contains("Sonlandi"))
                {
                    dgc.Visible = false;
                }
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FerdiTedarikci ft = new FerdiTedarikci();
            ft = Operations<FerdiTedarikci>.EntityDoldur(ft, cmbTedarikciIDFerdi.SelectedValue, txtSoyad.Text, mstSexsiyyet.Text, txtAdi.Text);

            bool sonuc=Operations<FerdiTedarikci>.Ekle(ft);

            if (sonuc)
            {
                MessageBox.Show("Ferdi Tedarikci Eklendi");
                Listele();
            }
            else
            {
                MessageBox.Show("Ferdi Tedarikci Eklenemedi...");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SirketTedarikci st = new SirketTedarikci();
            st = Operations<SirketTedarikci>.EntityDoldur(st, cmbTedarikciIDSirket.SelectedValue, txtSirketAdi.Text, mskVoen.Text, txtPersonelAd.Text);

            bool sonuc = Operations<SirketTedarikci>.Ekle(st);
            if (sonuc)
            {
                MessageBox.Show("Kayit Eklenmistir");
                Listele();
            }
            else
            {
                MessageBox.Show("Kayit Eklenemedi...");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
