using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class SkaitytojoLangas : Form
    {
        public SkaitytojoLangas()
        {
            InitializeComponent();
        }

        private void SkaitytojoLangas_Load(object sender, EventArgs e)
        {
            this.tableTableAdapter.Fill(this.knygosDataSet1.Table);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
