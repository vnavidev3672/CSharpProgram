namespace MyForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text.Trim();
            if (!string.IsNullOrEmpty(userName))
            {
                label2.Text = "Hello, " + userName + "!";
            }
            else
            {
                label1.Text = "Please enter your name.";
            }
        }
    }
}
