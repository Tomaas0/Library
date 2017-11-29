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
        private DBManager dbman = new DBManager();
        User user = new User();

        public SkaitytojoLangas(User user)
        {
            InitializeComponent();
            this.user = user;
            label1.Text = "Prisijungta kaip: " + user.Username;
            label2.Text = "Skaitytojo ID: " + user.ID;
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
            dbman.take(knygosDataSet1, dataGridView1.CurrentCell.RowIndex, user.ID);
            updateTable();
        }

        private void updateTable()
        {
            this.tableTableAdapter.Update(knygosDataSet1);
            this.tableTableAdapter.FillByZmogus(this.knygosDataSet1.Table);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.tableTableAdapter.FillByPavadinimas(this.knygosDataSet1.Table, "%" + textBox2.Text + "%");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            KurjerioForma Kurjeris = new KurjerioForma();
            Kurjeris.ShowDialog();
            dbman.take(knygosDataSet1, dataGridView1.CurrentCell.RowIndex, user.ID);
            updateTable();
        }
    }
}
