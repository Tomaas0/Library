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
    public partial class DarbuotojoLangas : Form
    {
        public DarbuotojoLangas()
        {
            InitializeComponent();
        }

        private void DarbuotojoLangas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'knygosDataSet1.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.knygosDataSet1.Table);

        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.tableBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.knygosDataSet1);
            }
            catch (Exception ex)
            {
                label1.Text = ex.ToString();
            }
        }

        private void tableDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.tableTableAdapter.Insert(1005, "Nauja", "Knyga", null, null);
                this.tableTableAdapter.Fill(this.knygosDataSet1.Table);
                this.Validate();
                this.tableBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.knygosDataSet1);
            }
            catch (Exception ex)
            {
                label1.Text = ex.ToString();
            }
        }
    }
}
