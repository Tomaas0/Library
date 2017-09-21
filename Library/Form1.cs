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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SkaitytojoLangas Skaitytojas = new SkaitytojoLangas();
            Skaitytojas.ShowDialog();
            this.Close();
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            DarbuotojoLangas Darbuotojas = new DarbuotojoLangas();
            Darbuotojas.ShowDialog();
            this.Close();
        }
    }
}
