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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void iscileriGosterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsciForm i=new IsciForm();
            i.MdiParent = this;
            i.Show();
        }

        private void iscilerinMelumatlariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsciMelumatlariForm ism = new IsciMelumatlariForm();
            ism.MdiParent = this;
            ism.Show();
        }

        private void kargolarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KargolarForm kf = new KargolarForm();
            kf.Show();
            kf.MdiParent = this;
        }

        private void odunclerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OdunclerForm of = new OdunclerForm();
            of.Show();
            of.MdiParent = this;
        }

        private void satislarCiroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SatisDetayForm sdf = new SatisDetayForm();
            sdf.Show();
            sdf.MdiParent=this;
        }

        private void satislarGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SatislarForm sf = new SatislarForm();
            sf.Show();
            sf.MdiParent = this;
        }

        private void oduncRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void satisRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SatisRaporuForm srf = new SatisRaporuForm();
            srf.Show();
            srf.MdiParent = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LibraryGeneral lg = new LibraryGeneral();
            lg.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LibraryGeneral lg = new LibraryGeneral();
            lg.Show();
            this.Close();
        }

        private void kATEGORIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KategoriForm kf = new KategoriForm();
            kf.Show();
            kf.MdiParent = this;
        }

        private void tedarikciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TedarikciEkleForm tef = new TedarikciEkleForm();
            tef.Show();
            tef.MdiParent = this;
        }

        private void yazarlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YaziciForm yf = new YaziciForm();
            yf.Show();
            yf.MdiParent = this;
        }

        private void musteriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusteriForm mf = new MusteriForm();
            mf.Show();
            mf.MdiParent = this;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }
    }
}
