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
            this.tableTableAdapter.FillByZmogus(this.knygosDataSet1.Table);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(int.Parse(textBox1.Text));
            DateTime Data = DateTime.Today;
            Data = Data.AddMonths(1);

            knygosDataSet1.Table[dataGridView1.CurrentCell.RowIndex].Zmogus = ID;
            knygosDataSet1.Table[dataGridView1.CurrentCell.RowIndex][4] = Data;

            this.tableTableAdapter.Update(knygosDataSet1);
            this.tableTableAdapter.FillByZmogus(this.knygosDataSet1.Table);
            //this.Validate();
            //this.tableBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.knygosDataSet1);
        }



    }
}
