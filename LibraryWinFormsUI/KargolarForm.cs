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
    public partial class KargolarForm : Form
    {
        public KargolarForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KargolarForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            cmbIletisimID.DataSource = Operations<Iletisimler>.SelectAll();
            cmbIletisimID.ValueMember = "Id";
            cmbIletisimID.DisplayMember = "Adresi";
            cmbIletisimID.SelectedIndex = -1;

            dataGridView1.DataSource = Operations<Kargolar>.SelectAll();

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
            Kargolar k = new Kargolar();
            k = Operations<Kargolar>.EntityDoldur(k, cmbIletisimID.SelectedValue, txtKargoAd.Text);

            bool sonuc=Operations<Kargolar>.Ekle(k);

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

        private void button6_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IletisimlerForm i = new IletisimlerForm();
            i.Show();

        }

        private void yeniIletisimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IletisimlerForm i = new IletisimlerForm();
            i.Show();
        }
    }
}
