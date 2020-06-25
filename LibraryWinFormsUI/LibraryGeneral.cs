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
using DataAccessLayer.Tools;

namespace LibraryWinFormsUI
{
    public partial class LibraryGeneral : Form
    {
        public LibraryGeneral()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            IstifadeciGirisi ig = new IstifadeciGirisi();
            ig.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            IstifadeciGirisi ig = new IstifadeciGirisi();
            ig.Show();
        }

        private void LibraryGeneral_Load(object sender, EventArgs e)
        {
            string id=IstifadeciGirisi.Id;
            string rol = IstifadeciGirisi.Rol.Trim().ToUpper();

            label2.Text="Islem Yapiyorsunuz "+User.AdGetir(id);
            if (rol!="ADMIN")
            {
                btnAdmin.Visible = false;
            }
        }

        private void btnKitablar_Click(object sender, EventArgs e)
        {
            KitablarForm kf = new KitablarForm();
            kf.Show();
            this.Close();
        }

        private void btnOkuyucular_Click(object sender, EventArgs e)
        {
            OkuyucularForm of = new OkuyucularForm();
            of.Show();
            this.Close();
        }

        private void btnEmanetler_Click(object sender, EventArgs e)
        {
            OduncAlVerForm of = new OduncAlVerForm();
            of.Show();
            this.Close();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminForm a = new AdminForm();
            a.Show();
            this.Close();
        }
    }
}
