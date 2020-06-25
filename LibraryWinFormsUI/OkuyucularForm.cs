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
    public partial class OkuyucularForm : Form
    {
        public OkuyucularForm()
        {
            InitializeComponent();
        }

        private void OkuyucularForm_Load(object sender, EventArgs e)
        {
            Listele();
        }
        ORM<Okuyucular> orm = new ORM<Okuyucular>(ORMBase<Okuyucular>.InstanceGetir());
        private void Listele()
        {
            cmbIletisimID.DataSource = Operations<Iletisimler>.SelectAll();
            cmbIletisimID.DisplayMember = "Adresi";
            cmbIletisimID.ValueMember =AditionTools<Iletisimler>.PKGetir();

            dataGridView1.DataSource =Operations<Okuyucular>.SelectAll();

            PropertyInfo[] props = typeof(Okuyucular).GetProperties();

            if (cmbArama.Items.Count==0)
            {
                foreach (PropertyInfo pi in props)
                {
                    if (pi.Name.Contains("ID") == false && pi.Name.Contains("Cinsiyyet") == false && pi.Name.Contains("Tar") == false)
                    {
                        cmbArama.Items.Add(pi.Name);
                    }
                }
            }
            
            foreach (DataGridViewColumn dgc in dataGridView1.Columns)
            {
                if (dgc.DataPropertyName.Contains("ID") || dgc.DataPropertyName.Contains("Sonlandi"))
                {
                    dgc.Visible = false;
                }
            }

            string id = IstifadeciGirisi.Id;
            string rol = IstifadeciGirisi.Rol.Trim().ToUpper();

            lblIsci.Text = "Islem Yapiyorsunuz " + User.AdGetir(id);
        }

        private void button1_Click(object sender, EventArgs e)
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
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string tur = cmbArama.Text;
            string axtarilan = txtArama.Text;

            dataGridView1.DataSource =Operations<Okuyucular>.Select(tur, axtarilan);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Okuyucular o = EntityDoldur();

            int ekle = Operations<Okuyucular>.EkleneniYoxla(AditionTools<Okuyucular>.YoxlananGetir(),o.SexsiyyetNo);
            if (ekle==0)
            {
                bool sonuc = Operations<Okuyucular>.Ekle(o);
                if (sonuc == true)
                {
                    MessageBox.Show("Kayit Eklendi");
                    Listele();
                }
                else
                {
                    MessageBox.Show("Kayit Eklenemedi...");
                }
            }
            else
            {
                MessageBox.Show("Eklemek istediginiz kisi zaten eklidi. Lutfen Yeniden Deneyin");
            }
        }

        private Okuyucular EntityDoldur()
        {
            Okuyucular o = new Okuyucular();
            if (chkErkek.Checked)
            {
                Operations<Okuyucular>.EntityDoldur(o, txtOkuyucuAdi.Text, txtOkuyucuSoyad.Text, dtpDogumTarihi.Value, true, dtpQeydiyyatTarixi.Value, cmbIletisimID.SelectedValue, mtxSexsiyyetNo.Text);
            }
            else if (chkKadin.Checked)
            {
                Operations<Okuyucular>.EntityDoldur(o, txtOkuyucuAdi.Text, txtOkuyucuSoyad.Text, dtpDogumTarihi.Value, false, dtpQeydiyyatTarixi.Value, cmbIletisimID.SelectedValue, mtxSexsiyyetNo.Text);
            }
            return o;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;

            txtArama.Tag = row.Cells["Id"].Value;

            foreach (Control con in groupBox2.Controls)
            {
                string conname = con.Name.Remove(0, 3);
                if (con is TextBox || con is MaskedTextBox || con is DateTimePicker)
                {
                    object value = row.Cells[conname].Value;
                    if (value!=DBNull.Value)
                    {
                        con.Text = value.ToString();
                    }
                    
                }
            }
            bool cinsiyyet;
            object deger = row.Cells["Cinsiyyet"].Value;
            if (deger != DBNull.Value)
            {
                cinsiyyet =Convert.ToBoolean(deger);
                if (cinsiyyet)
                {
                    chkErkek.Checked = true;
                    chkKadin.Checked = false;
                }
                else
                {
                    chkKadin.Checked = true;
                    chkErkek.Checked = false;
                }
            }
            cmbIletisimID.SelectedValue = row.Cells["IletisimID"].Value;
        }

        private void chkErkek_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id=Convert.ToInt32(txtArama.Tag);

            Okuyucular o = EntityDoldur();

            bool sonuc =Operations<Okuyucular>.Guncelle(o, id);

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

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtArama.Tag);

            bool sonuc=Operations<Okuyucular>.Sil(id);
            if (sonuc)
            {
                MessageBox.Show("Kayit Silindi");
                Listele();
            }
            else
            {
                MessageBox.Show("Kayit Silinemedi...");
            }
        }

        private void yeniIletisimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IletisimlerForm i = new IletisimlerForm();
            i.Show();
        }
    }
}
