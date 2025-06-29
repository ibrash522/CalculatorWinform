namespace calculatorform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int num1) && int.TryParse(textBox2.Text, out int num2))
            {
                int sum = num1 + num2;
                MessageBox.Show("Result: " + sum.ToString());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int num1) && int.TryParse(textBox2.Text, out int num2))
            {
                int sum = num1 - num2;
                MessageBox.Show("Result: " + sum.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int num1) && int.TryParse(textBox2.Text, out int num2))
            {
                int sum = num1 * num2;
                MessageBox.Show("Result: " + sum.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int num1) && int.TryParse(textBox2.Text, out int num2))
            {
                if (num2 != 0)
                {
                    int sum = num1 / num2;
                    MessageBox.Show("Result: " + sum.ToString());
                }
                else
                {
                    MessageBox.Show("Math Error!");
                }
            }
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Clicked");
        }
    }
}
