namespace SinemaBüfeUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int mısır = Convert.ToInt32(textBox1.Text);
            int su = Convert.ToInt32(textBox2.Text);
            int cay = Convert.ToInt32(textBox3.Text);
            int bilet = Convert.ToInt32(textBox4.Text);
            int ucret;
            
            ucret = mısır * 40 + su * 10 + cay * 20 + bilet * 100;
            kasatutar = ucret + kasatutar;
            label11.Text = ucret.ToString() + " TL";
            label13.Text = kasatutar.ToString()+ " TL";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            char a = ' ';
            textBox1.Text = a.ToString();
            textBox2.Text = a.ToString();
            textBox3.Text = a.ToString();
            textBox4.Text = a.ToString();
            label11.Text = "...TL";

        }
    }
}
