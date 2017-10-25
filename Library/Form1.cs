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

        public int Vartotojas { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Username = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Password = textBox2.Text;
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            if (checkBox2.Checked)
            {
                Vartotojas = 1;
            }
            if (checkBox1.Checked)
            {
                Vartotojas = 0;
            }

            if (login.CheckData(Username,Password,Vartotojas))
            {
                if (Vartotojas == 1)
                {
                    SkaitytojoLangas Skaitytojas = new SkaitytojoLangas();
                    Skaitytojas.ShowDialog();
                }
                else
                {
                    DarbuotojoLangas Darbuotojas = new DarbuotojoLangas();
                    Darbuotojas.ShowDialog();
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {         
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();

            //kad lentelej atskirtum kur darbuotojas kur skaitytojas, tai darbuotojas = 0, skaitytojas = 1
            if (checkBox2.Checked)
            {
                Vartotojas = 1;
            }
            if(checkBox1.Checked)
            {
                Vartotojas = 0;
            }

            if(login.CheckData(Username, Password, Vartotojas))
            {
                ShowDialogs();
            }
            else
            {
                DialogResult rezult = MessageBox.Show("Tokio Vartotojo nėra, ar norite užziregistruoti?", "Caption",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(rezult == DialogResult.Yes)
                {
                    login.FillData(Username, Password, Vartotojas);               
                    MessageBox.Show("Sekimgai įrašyta");
                    ShowDialogs();
                }
               else
                {
                    return;
                }

            }
                    
        }

        public void ShowDialogs()
        {

             if(Vartotojas == 1)
                {
                SkaitytojoLangas Skaitytojas = new SkaitytojoLangas();
                Skaitytojas.ShowDialog();
            }
                else
                {
                DarbuotojoLangas Darbuotojas = new DarbuotojoLangas();
                Darbuotojas.ShowDialog();
            }
        }
    }
}
