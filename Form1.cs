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
            int c = 2 + 3;
            string res = Convert.ToString(c);
            MessageBox.Show(res);
        }
    }
}