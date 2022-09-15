namespace Panel_Elements
{
    public partial class Form1 : Form
    {
        double a, b;
        int count;
        bool znak = true;


    private void calculate()
        {
            switch (count)
            {
                case 1:
                    b = a + float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 2:
                    b = a - float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 4:
                    b = a / float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 5:
                    b = Math.Sqrt(a);
                    textBox1.Text= b.ToString();
                    break;

                default:
                    break;
            }

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Num0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void Num1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;

        }

        private void Num2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }
        private void Num3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void Num4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void Num5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void Num6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void Num7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void Num8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void Num9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }

        private void del_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }

        private void op_plus_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            count = 1;
            label1.Text = "+";
            znak = true; 
        }

        private void op_minus_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            count = 2;
            label1.Text = "-";
            znak = true;
        }

        private void op_multi_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            count = 3;
            label1.Text = "X";
            znak = true;
        }

        private void op_div_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            count = 4;
            label1.Text = "/";
            znak = true;
        }

        private void squaring_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            count = 5;
            znak = true;

            calculate();
            label1.Text = " ";
        }

        private void op_equals_Click(object sender, EventArgs e)
        {
            calculate();
            label1.Text = " ";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void sign(object sender, EventArgs e)
        {
            if (znak == true)
            {
                textBox1.Text = "-" + textBox1.Text;
                znak = false;
            }
            else if (znak == false)
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                znak = true;
            }
        }

        private void decimal_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }
    }
}