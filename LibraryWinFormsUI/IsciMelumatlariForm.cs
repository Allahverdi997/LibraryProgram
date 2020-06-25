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
    public partial class IsciMelumatlariForm : Form
    {
        public IsciMelumatlariForm()
        {
            InitializeComponent();
        }

        private void IsciMelumatlariForm_Load(object sender, EventArgs e)
        {
           cmbIsciID.DataSource=Operations<Iskiler>.SelectAll();
           cmbIsciID.ValueMember = "IsciId";
           cmbIsciID.DisplayMember = "IsciAdi";

           cmbRol.DataSource = Operations<IsciSistemMelumat>.SelectAll();
           cmbRol.ValueMember = "Rol";
           cmbRol.DisplayMember = "Rol";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            IsciSistemMelumat ism = new IsciSistemMelumat();
            ism = Operations<IsciSistemMelumat>.EntityDoldur(ism, cmbIsciID.SelectedValue, txtUsername.Text, txtPassword.Text, cmbRol.SelectedValue, dtpQeydiyyatTarixi.Value);
            bool sonuc=Operations<IsciSistemMelumat>.Ekle(ism);

            if (sonuc)
            {
                MessageBox.Show("Kayit Eklendi");
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
