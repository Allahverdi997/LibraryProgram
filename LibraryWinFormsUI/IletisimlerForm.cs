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
    public partial class IletisimlerForm : Form
    {
        public IletisimlerForm()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Iletisimler i = new Iletisimler();
             i= Operations<Iletisimler>.EntityDoldur(i, mtxTelefonNo.Text, txtAdress.Text, txtWebSitesi.Text, mtxPosta.Text);
            Operations<Iletisimler>.Ekle(i);
            this.Close();
        }
    }
}
