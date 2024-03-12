using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace asia_app
{
    public partial class Form1 : Form
    {
        public double komputerCena = 0;
        public double monitorCena = 0;
        public Form1()
        {
            InitializeComponent();
            textBox1.ReadOnly = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 nowe_okno = new Form2(this);
            nowe_okno.ShowDialog();
            textBox1.Text = (monitorCena + komputerCena).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 nowe_okno1 = new Form3(this);
            nowe_okno1.ShowDialog();
            textBox1.Text = (monitorCena + komputerCena).ToString();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
