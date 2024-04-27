namespace ThreadingDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcess1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ýþlem1 çalýþtý");
        }

        private void btnProcess2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ýþlem2 çalýþtý");
        }
    }
}
