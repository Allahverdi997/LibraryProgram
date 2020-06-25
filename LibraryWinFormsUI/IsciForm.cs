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
    public partial class IsciForm : Form
    {
        public IsciForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IsciForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            cmbIletisimler.DataSource = Operations<Iletisimler>.SelectAll();
            cmbIletisimler.DisplayMember = "Adresi";
            cmbIletisimler.ValueMember = "Id";

            dataGridView1.DataSource = Operations<Iskiler>.SelectAll();

            foreach (DataGridViewColumn dgc in dataGridView1.Columns)
            {
                if (dgc.DataPropertyName.Contains("ID") || dgc.DataPropertyName.Contains("Sonlandi"))
                {
                    dgc.Visible = false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IletisimlerForm i = new IletisimlerForm();
            i.Show();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Iskiler i = new Iskiler();

            i = Operations<Iskiler>.EntityDoldur(i,txtIsciAdi.Text,txtIsciSoyadi.Text,dtpDogumTarihi.Value,nudMaas.Value,cmbIletisimler.SelectedValue);
            bool sonuc=Operations<Iskiler>.Ekle(i);

            if (sonuc)
            {
                MessageBox.Show("Kayit Eklendi");
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            object id = row.Cells["IsciId"].Value;
            txtIsciAdi.Tag = id;

            txtIsciAdi.Text = row.Cells["IsciAdi"].Value.ToString();
            txtIsciSoyadi.Text = row.Cells["Soyadi"].Value.ToString();
            nudMaas.Value =Convert.ToDecimal(row.Cells["Maas"].Value);
            if (row.Cells["Dogum"].Value!=DBNull.Value)
            {
                dtpDogumTarihi.Value =Convert.ToDateTime(row.Cells["Dogum"].Value);
            }
            cmbIletisimler.SelectedValue =Convert.ToInt32(row.Cells["IletisimID"].Value);

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id =Convert.ToInt32(txtIsciAdi.Tag);

            Iskiler i = new Iskiler();
            i = Operations<Iskiler>.EntityDoldur(i, txtIsciAdi.Text, txtIsciSoyadi.Text, dtpDogumTarihi.Value, nudMaas.Value, cmbIletisimler.SelectedValue);

            bool sonuc=Operations<Iskiler>.Guncelle(i, id);

            if (sonuc)
            {
                MessageBox.Show("Kayit Guncellendi");
            }
            else
            {
                MessageBox.Show("Kayit Guncellenemedi...");
            }
        }

        private void yeniIletisimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IletisimlerForm i = new IletisimlerForm();
            i.Show();
        }
    }
}
