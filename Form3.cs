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
    public partial class Form3 : Form
    {
        double monitorCena;
        Form1 parent;
        public Form3(Form1 stare_okno)
        {
            InitializeComponent();
            parent = stare_okno;
            textBox1.ReadOnly = true;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                foreach (ListViewItem selectedItem in listView1.SelectedItems)
                {
                    if (selectedItem.Text == "Monitor CRD")
                        monitorCena = 560;
                    if (selectedItem.Text == "Monitor LCD/LED")
                        monitorCena = 600;
                    if (selectedItem.Text == "Monitor OLED")
                        monitorCena = 760;
                }
                textBox1.Text = monitorCena.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.monitorCena = monitorCena;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
