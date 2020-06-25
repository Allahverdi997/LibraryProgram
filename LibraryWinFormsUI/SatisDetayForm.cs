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
    public partial class SatisDetayForm : Form
    {
        public SatisDetayForm()
        {
            InitializeComponent();
        }

        private void SatisDetayForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            cmbSatisID.DataSource = Operations<Satislar>.SelectAll();
            cmbSatisID.ValueMember = "Id";
            cmbSatisID.DisplayMember = "Id";

            dataGridView1.DataSource = Operations<SatisDetaylar>.SelectAll();

            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SatisDetaylar sd = new SatisDetaylar();
            sd = Operations<SatisDetaylar>.EntityDoldur(sd, cmbSatisID.SelectedValue,nudMiktar.Value, nudFiyat.Value, nudIndirim.Value);

            bool sonuc = Operations<SatisDetaylar>.Ekle(sd);

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
