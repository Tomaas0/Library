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
        private DBManager dbman = new DBManager();

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
            if (knygosDataSet1.Table[tableDataGridView.CurrentCell.RowIndex][4].Equals(DBNull.Value)) { label1.Text = ""; }
            else
            {
                DateTime grazinimoData = (DateTime)knygosDataSet1.Table[tableDataGridView.CurrentCell.RowIndex][4];
                label1.Text = "Mokama suma: " + dbman.baudosDydis(grazinimoData).ToString() + " €";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            dbman.remove(knygosDataSet1, tableDataGridView.CurrentCell.RowIndex);
            updateTable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                dbman.extend(knygosDataSet1, tableDataGridView.CurrentCell.RowIndex);
            }catch(Exception exc)
            {
                label1.Text = exc.Message;
            }
             updateTable();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String autorius = textBoxAutorius.Text;
            String pavadinimas = textBoxPavadinimas.Text;
            dbman.add(knygosDataSet1, autorius, pavadinimas);
            updateTable();
        }

        private void updateTable()
        {
            this.tableTableAdapter.Update(knygosDataSet1);
            this.tableTableAdapter.Fill(this.knygosDataSet1.Table);
        }
    }
}
