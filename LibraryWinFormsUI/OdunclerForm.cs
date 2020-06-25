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
    public partial class OdunclerForm : Form
    {
        public OdunclerForm()
        {
            InitializeComponent();
        }

        private void OdunclerForm_Load(object sender, EventArgs e)
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

            dataGridView1.DataSource = Operations<Oduncler>.SelectAll();

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
            Oduncler o = new Oduncler();
            o = Operations<Oduncler>.EntityDoldur(o, cmbIsciID.SelectedValue, cmbKitabID.SelectedValue, cmbMusteriID.SelectedValue, dtpVerilmeTarihi.Value, dtpQaytarilmaTarixi.Value);

            bool sonuc = Operations<Oduncler>.Ekle(o);

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
