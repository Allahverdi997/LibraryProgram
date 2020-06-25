using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using DataAccessLayer.AdoNet;
using BusinessLogicalLayer;
using Entities;
using Entities.Models;
using System.Reflection;
using DataAccessLayer.Tools;
namespace LibraryWinFormsUI
{
    public partial class OduncAlVerForm : Form
    {
        public OduncAlVerForm()
        {
            InitializeComponent();
        }
        ORM<Oduncler> ormo = new ORM<Oduncler>(ORMBase<Oduncler>.InstanceGetir());
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void OduncAlVerForm_Load(object sender, EventArgs e)
        {
            Listele();
            cmbIsci.Enabled = false;
            cmbKitab.Enabled = false;
            cmbMusteri.Enabled = false;
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

            cmbKitab.DataSource = ormo.SelectAll();
            cmbKitab.ValueMember = "KitabID";
            cmbKitab.DisplayMember = "KitabAdi";

            cmbMusteri.DataSource = ormo.SelectAll();
            cmbMusteri.ValueMember = "MusteriID";
            cmbMusteri.DisplayMember = "Adi";

            cmbIsci.DataSource = ormo.SelectAll();
            cmbIsci.ValueMember = "IsciID";
            cmbIsci.DisplayMember = "IsciAdi";

            dataGridView1.DataSource = ormo.SelectAll();

            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                if (col.Name.Contains("ID"))
                {
                    col.Visible = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Oduncler o = EntityDoldur();

            bool sonuc=ormo.Ekle(o);

            if (sonuc)
            {
                MessageBox.Show("Kayit Eklendi");
            }
            else
            {
                MessageBox.Show("Kayit Eklenemedi...");
            }
        }

        private Oduncler EntityDoldur()
        {
            Oduncler o = new Oduncler();

            o.IsciID = (int)cmbIsciID.SelectedValue;
            o.KitabID = (int)cmbKitabID.SelectedValue;
            o.MusteriID = (int)cmbMusteriID.SelectedValue;
            o.QaytarilmaTarihi = dtpQaytarilmaTarihi.Value;
            o.VerilmeTarihi = dtpVerilmeTarixi.Value;
            return o;
        }

        private void cmbKitabID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ad = cmbKitabID.Text;

            DataTable dt = Operations<Kitablar>.Select("KitabAdi", ad);

            foreach (DataRow dr in dt.Rows)
            {
                mtxBarkodNo.Text = dr["BarkodNo"].ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            IstifadeciGirisi i = new IstifadeciGirisi();
            i.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LibraryGeneral lgf = new LibraryGeneral();
            lgf.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Listele();

            foreach (Control item in groupBox1.Controls)
            {
                if (item is ComboBox || item is MaskedTextBox || item is DateTimePicker)
                {
                    item.Text = "";
                }
            }

            foreach (Control item in groupBox2.Controls)
            {
                if (item is ComboBox || item is MaskedTextBox || item is DateTimePicker)
                {
                    item.Text = "";
                }
            }
        }

        private void cmbKitab_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                string ad = cmbKitab.Text;

                DataTable dt = Operations<Kitablar>.Select("KitabAdi", ad);

                foreach (DataRow dr in dt.Rows)
                {
                    mtxKitab.Text = dr["BarkodNo"].ToString();
                }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Oduncler o = new Oduncler();

            o.KitabID = Convert.ToInt32(cmbKitab.SelectedValue);
            o.MusteriID = Convert.ToInt32(cmbMusteri.SelectedValue);
            o.QaytarilmaTarihi = dtpQaytarilmaTarihim.Value;
            o.IsciID =Convert.ToInt32(cmbIsci.SelectedValue);
            if (chkTeslim.Checked)
            {
                o.TeslimDurumu = true;
            }

            int id =Convert.ToInt32(cmbIsci.Tag);
            
            bool sonuc=ormo.Guncelle(o, id);

            if (sonuc)
            {
                MessageBox.Show("Kayit Guncellendi");
                Listele();
            }
            else
            {
                MessageBox.Show("Kayit Guncellenemedi...");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            object id = row.Cells["Id"].Value;
            cmbIsci.Tag = id;

            
            cmbIsci.SelectedValue = row.Cells["IsciID"].Value;
            cmbKitab.SelectedValue = row.Cells["KitabID"].Value;
            cmbMusteri.SelectedValue = row.Cells["MusteriID"].Value;
            dtpQaytarilmaTarihim.Value =Convert.ToDateTime(row.Cells["QaytarilmaTarihi"].Value);

        }

        private void cmbIsciID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
