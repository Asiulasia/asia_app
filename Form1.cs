namespace asia_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 nowe_okno = new Form2(this);
            nowe_okno.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 nowe_okno1 = new Form3(this);
            nowe_okno1.Show();
        }
    }
}
