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
    public partial class SatisRaporuForm : Form
    {
        public SatisRaporuForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SatisRaporuForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource=Operations<Satislar>.SelectRapor();

            foreach (DataGridViewColumn dgc in dataGridView1.Columns)
            {
                if (dgc.DataPropertyName.Contains("ID") || dgc.DataPropertyName.Contains("Sonlandi"))
                {
                    dgc.Visible = false;
                }
            }
        }
    }
}
