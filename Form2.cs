using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asia_app
{
    public partial class Form2 : Form
    {
        double procesorCena = 0;
        double dyskCena = 0;

        Form1 parent;
        public Form2(Form1 stare_okno)
        {
            InitializeComponent();
            parent = stare_okno;
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parent.komputerCena = procesorCena + dyskCena;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                if (comboBox1.SelectedItem.ToString() == "Intel i3")
                    procesorCena = 400;
                if (comboBox1.SelectedItem.ToString() == "Intel i5")
                    procesorCena = 831;
                if (comboBox1.SelectedItem.ToString() == "AMD Ryzen 5")
                    procesorCena = 1800;

                textBox1.Text = procesorCena.ToString();
            }
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            dyskCena = 1000;
            textBox2.Text = dyskCena.ToString();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dyskCena = 2000;
            textBox2.Text = dyskCena.ToString();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            dyskCena = 3000;
            textBox2.Text = dyskCena.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
