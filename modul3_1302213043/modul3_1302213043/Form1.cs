using System.Xml;

namespace modul3_1302213043
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = "";
        }

        int num,sum; 

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "1";

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

            label2.Text = label2.Text + "2";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            label2.Text = label2.Text + "3";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "6";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "9";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            num = int.Parse(label2.Text);
            sum += num;
            label2.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            num = int.Parse(label2.Text);
            sum += num;
            label2.Text = sum.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}