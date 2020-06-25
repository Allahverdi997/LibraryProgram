using BusinessLogicalLayer;
using DataAccessLayer;
using DataAccessLayer.AdoNet;
using DataAccessLayer.Tools;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryWinFormsUI
{
    public partial class KitablarForm : Form
    {
        public KitablarForm()
        {
            InitializeComponent();
        }

        private void KitablarForm_Load(object sender, EventArgs e)
        {
            Listele();

            foreach (DataGridViewColumn dgc in dataGridView1.Columns)
            {
                if (dgc.DataPropertyName.Contains("ID") || dgc.DataPropertyName.Contains("Sonlan"))
                {
                    dgc.Visible = false;
                }
            }
        }

        private void Listele()
        {
            cmbKategoriID.DataSource = Operations<Kategoriler>.SelectAll();
            cmbKategoriID.DisplayMember = "KategoriAdi";
            cmbKategoriID.ValueMember = AditionTools<Kategoriler>.PKGetir();

            cmbYazarID.DataSource = Operations<Yazarlar>.SelectAll();
            cmbYazarID.DisplayMember = "YazarAdi";
            cmbYazarID.ValueMember = AditionTools<Yazarlar>.PKGetir();

            cmbFerdiAdTedarikciID.DataSource = Operations<FerdiTedarikci>.SelectAll();
            cmbFerdiAdTedarikciID.DisplayMember = "Adi";
            cmbFerdiAdTedarikciID.ValueMember = "TedarikciID";

            cmbSirketTedarikciID.DataSource = Operations<SirketTedarikci>.SelectAll();
            cmbSirketTedarikciID.DisplayMember = "SirketAdi";
            cmbSirketTedarikciID.ValueMember = "TedarikciID";

            lblIsci.Text = "Islem Yapiyorsunuz " + User.AdGetir(IstifadeciGirisi.Id) + " Gozlemleniyorsunuz...";
            dataGridView1.DataSource = Operations<Kitablar>.SelectAll();

            PropertyInfo[] props = typeof(Kitablar).GetProperties();

            foreach (PropertyInfo pi in props)
            {
                string tipname = pi.Name;
                if ((tipname.Contains("ID") == false) && (tipname.Contains("Tarih") == false) && (tipname.Contains("Resim") == false) && (tipname.Contains("Sonlandi") == false))
                {
                    cmbArama.Items.Add(tipname);
                }
            }
            cmbArama.SelectedIndex = 1;

            string id = IstifadeciGirisi.Id;
            string rol = IstifadeciGirisi.Rol.Trim().ToUpper();

            lblIsci.Text = "Islem Yapiyorsunuz " + User.AdGetir(id);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LibraryGeneral lgf = new LibraryGeneral();
            lgf.Show();
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string tur = cmbArama.SelectedItem.ToString();
            string aranan = txtArama.Text;

            dataGridView1.DataSource = Operations<Kitablar>.Select(tur,aranan);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IstifadeciGirisi i = new IstifadeciGirisi();
            i.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Operations<Kitablar>.SelectAll();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Kitablar k = EntityDoldur();


            int ekle = Operations<Kitablar>.EkleneniYoxla(AditionTools<Kitablar>.YoxlananGetir(), k.BarkodNo);
            if (ekle==0)
            {
                bool sonuc = Operations<Kitablar>.Ekle(k);
                if (sonuc == true)
                {
                    MessageBox.Show("Kayit Basariyla Eklendi");
                    Listele();
                }
                else
                {
                    MessageBox.Show("Kayit Eklenemedi...");
                }
            }
            else
            {
                MessageBox.Show("Eklemek istediginiz kitap zaten eklidir. Lutfen baska kitab ekleyiniz...");
            }
            
        }

        private Kitablar EntityDoldur()
        {
            Kitablar k = new Kitablar();

            if (cmbFerdiAdTedarikciID.Text != "")
            {
                return Operations<Kitablar>.EntityDoldur(k, cmbYazarID.SelectedValue, cmbKategoriID.SelectedValue,cmbFerdiAdTedarikciID.SelectedValue,mtxBarkodNo.Text, txtKitabAdi.Text, txtKitabAciklamasi.Text, nudVereqSayi.Value, nudFiyati.Value, nudMiktar.Value, txtYayinEvi.Text);
            }
            else
            {
                return Operations<Kitablar>.EntityDoldur(k, cmbYazarID.SelectedValue, cmbKategoriID.SelectedValue, cmbSirketTedarikciID.SelectedValue, mtxBarkodNo.Text, txtKitabAdi.Text, txtKitabAciklamasi.Text, nudVereqSayi.Value, nudFiyati.Value, nudMiktar.Value, txtYayinEvi.Text);
            }
        }

        private void cmbFerdiAdTedarikciID_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSirketTedarikciID.SelectedIndex = -1;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row=dataGridView1.CurrentRow;

            string id = row.Cells["Id"].Value.ToString();
            txtKitabAdi.Tag = id;

            foreach (Control con in groupBox2.Controls)
            {
                if (con is NumericUpDown || con is TextBox || con is MaskedTextBox)
                {
                    string control = con.Name.Remove(0,3);
                    con.Text = row.Cells[control].Value.ToString();
                }
            }

               cmbKategoriID.SelectedIndex=Convert.ToInt32(row.Cells["KategoriID"].Value.ToString())-1;
               cmbYazarID.SelectedIndex = Convert.ToInt32(row.Cells["YazarID"].Value.ToString())-1;

               int index = Convert.ToInt32(row.Cells["TedarikciID"].Value.ToString());

               SelectIDGetir<FerdiTedarikci>(index.ToString(), "Adi", cmbFerdiAdTedarikciID);
               SelectIDGetir<SirketTedarikci>(index.ToString(), "SirketAdi", cmbSirketTedarikciID);

        }

        public static void SelectIDGetir<ET>(string deger,string showkolon, ComboBox con) where ET:class
        {
            System.Data.DataTable dt = Operations<ET>.Select("TedarikciID", deger);
            foreach (DataRow dr in dt.Rows)
            {
                string item = dr[showkolon].ToString();
                con.SelectedIndex = con.FindString(item);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Kitablar k=EntityDoldur();
            int id=Convert.ToInt32(txtKitabAdi.Tag.ToString());

            bool sonuc = Operations<Kitablar>.Guncelle(k, id);

            if(sonuc==true)
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
            int id = Convert.ToInt32(txtKitabAdi.Tag);
            bool sonuc=Operations<Kitablar>.Sil(id);

            if (sonuc)
            {
                MessageBox.Show("Kayit Silindi");
            }
            else
            {
                MessageBox.Show("Kayit Silinemedi...");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }
    }
}
