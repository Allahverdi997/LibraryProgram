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
    public partial class SatislarForm : Form
    {
        public SatislarForm()
        {
            InitializeComponent();
        }

        private void SatislarForm_Load(object sender, EventArgs e)
        {
            Listele();

        }

        private void Listele()
        {
            cmbIsciID.DataSource = Operations<Iskiler>.SelectAll();
            cmbIsciID.ValueMember = "IsciId";
            cmbIsciID.DisplayMember = "IsciAdi";

            cmbKitabID.DataSource = Operations<Kitablar>.SelectAll();
            cmbKitabID.ValueMember = "Id";
            cmbKitabID.DisplayMember = "KitabAdi";

            cmbMusteriID.DataSource = Operations<Musteriler>.SelectAll();
            cmbMusteriID.ValueMember = "Id";
            cmbMusteriID.DisplayMember = "Adi";

            cmbKargoID.DataSource = Operations<Kargolar>.SelectAll();
            cmbKargoID.ValueMember = "Id";
            cmbKargoID.DisplayMember = "KargoAd";

            dataGridView1.DataSource = Operations<Satislar>.SelectAll();

            foreach (DataGridViewColumn dgc in dataGridView1.Columns)
            {
                if (dgc.DataPropertyName.Contains("ID") || dgc.DataPropertyName.Contains("Sonlandi"))
                {
                    dgc.Visible = false;
                }
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Satislar o = new Satislar();
            o = Operations<Satislar>.EntityDoldur(o, cmbIsciID.SelectedValue, cmbMusteriID.SelectedValue,cmbKitabID.SelectedValue,cmbKargoID.SelectedValue,dtpSatisTarihi.Value);

            bool sonuc = Operations<Satislar>.Ekle(o);

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
