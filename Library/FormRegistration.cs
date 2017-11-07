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
    public partial class FormRegistration : Form
    {
        User user = new User();

        Login login = new Login();
        public FormRegistration()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                user.Vartotojas = 1;
            }
            if (checkBox2.Checked)
            {
                user.Vartotojas = 0;
            }
           user.Username= textBox1.Text;
           user.Password= textBox2.Text;
           login.FillData(user.Username, user.Password, user.Vartotojas);
            MessageBox.Show("Sekimgai įrašyta");
            ShowDialogs();
            
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }
        public void ShowDialogs()
        {

            if (user.Vartotojas == 1)
            {
                user.ID = Login.GetID(user.Username);
                SkaitytojoLangas Skaitytojas = new SkaitytojoLangas(user);
                this.Close();
                Skaitytojas.ShowDialog();
                this.Show();
            }
            else
            {
                user.ID = Login.GetID(user.Username);
                DarbuotojoLangas Darbuotojas = new DarbuotojoLangas(user);
                this.Close();
                Darbuotojas.ShowDialog();
                this.Show();
            }
        }
    }
}
