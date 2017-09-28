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
        private double bauda = 0.1;

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
                label1.Text = "Mokama suma: " + baudosDydis(grazinimoData).ToString() + " €";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                knygosDataSet1.Table[tableDataGridView.CurrentCell.RowIndex].Zmogus = 0;
                knygosDataSet1.Table[tableDataGridView.CurrentCell.RowIndex][4] = DBNull.Value;
                this.tableTableAdapter.Update(knygosDataSet1);
                this.tableTableAdapter.Fill(this.knygosDataSet1.Table);
                //this.Validate();
                //this.tableBindingSource.EndEdit();
                //this.tableAdapterManager.UpdateAll(this.knygosDataSet1);
            }
            catch (Exception ex)
            {
                label1.Text = ex.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime grazinimoData = (DateTime)knygosDataSet1.Table[tableDataGridView.CurrentCell.RowIndex][4];
            if(baudosDydis(grazinimoData) > 0)
            {
                label1.Text = "Negalima pratesti grazinimo datos. Bauda jau pradeta skaiciuoti.";
            }
            else
            {
            grazinimoData = grazinimoData.AddMonths(1);
            knygosDataSet1.Table[tableDataGridView.CurrentCell.RowIndex][4] = grazinimoData;
            this.tableTableAdapter.Update(knygosDataSet1);
            this.tableTableAdapter.Fill(this.knygosDataSet1.Table);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = generateId();
            String autorius = textBoxAutorius.Text;
            String pavadinimas = textBoxPavadinimas.Text;

            DataRow anyRow = knygosDataSet1.Table.NewRow();
            anyRow[0] = id;
            anyRow[1] = autorius;
            anyRow[2] = pavadinimas;
            anyRow[3] = 0;
            knygosDataSet1.Table.Rows.Add(anyRow);
            this.tableTableAdapter.Update(knygosDataSet1);
            this.tableTableAdapter.Fill(this.knygosDataSet1.Table);
        }

        private double baudosDydis(DateTime data)
        {
            DateTime today = DateTime.Today;
            double suma;
            suma = (today - data).Days * this.bauda;
            if (suma > 0) return suma;
            else return 0;
        }

        private int generateId()
        {
            int i;
            int id = 1000;
            for(i = 0; i < knygosDataSet1.Table.Count; i++)
            {
                if((int)knygosDataSet1.Table[i][0] == id)
                {
                    id++;
                }
                else
                {
                    return id;
                }
            }
            return id;
        }
    }
}
