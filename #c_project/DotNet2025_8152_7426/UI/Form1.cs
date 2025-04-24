namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            management management = new management();
            management.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoginUser l = new LoginUser();
            l.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
