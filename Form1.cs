namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int c = 2 + 3;
            string res = Convert.ToString(c);
            MessageBox.Show(res);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int c = 2 - 3;
            string res = Convert.ToString(c);
            MessageBox.Show(res);
        }

        private void button_Sin_Click(object sender, EventArgs e)
        {
            int a = 2;
            double resSin = Math.Sin(a);
            MessageBox.Show(Convert.ToString(resSin));
        }


        private void button_plusPlus_Click(object sender, EventArgs e)
        {
            int a = 9;
            a++;
            MessageBox.Show(Convert.ToString(a));
        }

        private void button_minMin_Click(object sender, EventArgs e)
        {
            int a = 9;
            a--;
            MessageBox.Show(Convert.ToString(a));
        }
    }
}