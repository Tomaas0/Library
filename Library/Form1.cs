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

        private User user = new User();


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            user.Username = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
            user.Password = textBox2.Text;
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            if (checkBox2.Checked)
            {
                user.Vartotojas = 1;
            }
            if (checkBox1.Checked)
            {
                user.Vartotojas = 0;
            }

            if (login.CheckData(user.Username, user.Password, user.Vartotojas))
            {
                if (user.Vartotojas == 1)
                {
                    user.ID = Login.GetID(user.Username);
                    SkaitytojoLangas Skaitytojas = new SkaitytojoLangas(user);
                    Skaitytojas.ShowDialog();
                }
                else
                {
                    user.ID = Login.GetID(user.Username);
                    DarbuotojoLangas Darbuotojas = new DarbuotojoLangas(user);
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
                user.Vartotojas = 1;
            }
            if(checkBox1.Checked)
            {
                user.Vartotojas = 0;
            }

            if(login.CheckData(user.Username, user.Password, user.Vartotojas))
            {
                ShowDialogs();
            }
            else
            {
                DialogResult rezult = MessageBox.Show("Tokio Vartotojo nėra, ar norite užziregistruoti?", "Caption",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(rezult == DialogResult.Yes)
                {
                    FormRegistration form = new FormRegistration();
                    form.ShowDialog();     
                               
                }
               else
                {
                    return;
                }

            }
                    
        }

        public void ShowDialogs()
        {

             if(user.Vartotojas == 1)
                {
                user.ID = Login.GetID(user.Username);
                SkaitytojoLangas Skaitytojas = new SkaitytojoLangas(user);
                this.Hide();
                Skaitytojas.ShowDialog();
                this.Show();
            }
                else
            {
                user.ID = Login.GetID(user.Username);
                DarbuotojoLangas Darbuotojas = new DarbuotojoLangas(user);
                this.Hide();
                Darbuotojas.ShowDialog();
                this.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
