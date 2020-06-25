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
    public partial class TedarikciEkleForm : Form
    {
        public TedarikciEkleForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TedarikciEkleForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            cmbIletisim.DataSource = Operations<Iletisimler>.SelectAll();
            cmbIletisim.ValueMember = "Id";
            cmbIletisim.DisplayMember = "Adresi";
            cmbIletisim.SelectedIndex = -1;
        }

        private void btnIletisim_Click(object sender, EventArgs e)
        {
            IletisimlerForm i = new IletisimlerForm();
            i.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cmbIletisim.SelectedIndex!=-1)
            {
                Tedarikciler t = new Tedarikciler();
                t = Operations<Tedarikciler>.EntityDoldur(t, cmbIletisim.SelectedValue);

                bool sonuc = Operations<Tedarikciler>.Ekle(t);
                if (sonuc)
                {
                    TedarikciForm tf = new TedarikciForm();
                    tf.MdiParent = this.MdiParent;
                    tf.Show();
                    this.Close();
                }
                else
                {
                  MessageBox.Show("Kayit EKlenemedi...");
                }
            }
            else
            {
                TedarikciForm tf = new TedarikciForm();
                tf.MdiParent = this.MdiParent;
                tf.Show();
                
            }
            
        }

        private void yeniIletisimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IletisimlerForm i = new IletisimlerForm();
            i.Show();
        }
    }
}
