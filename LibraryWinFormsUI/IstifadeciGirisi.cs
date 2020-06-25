
using BusinessLogicalLayer;
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
    public partial class IstifadeciGirisi : Form
    {
        public IstifadeciGirisi()
        {
            InitializeComponent();
        }

        public static string Rol { get; set; }
        public static string Id { get; set; }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnParolaniUnuttun_MouseHover(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IstifadeciGirisi_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            txtUsername.Text = "";
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            txtPassword.Text = "";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            string[] stringer = new string[2];
            
            bool sonuc=User.Yoxla(username, password);

            if (sonuc==true)
            {
                stringer = User.IdRolGetir(username, password);
                Id =stringer[0];
                Rol = stringer[1];
                LibraryGeneral lgf = new LibraryGeneral();
                lgf.Show();
            }
            else
            {
                MessageBox.Show("Kullanici Ismi ve ya Parola yanlistir!!!","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
    }
}
