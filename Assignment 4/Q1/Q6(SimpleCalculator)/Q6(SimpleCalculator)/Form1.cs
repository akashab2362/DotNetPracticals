namespace Q6_SimpleCalculator_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Parse input values
                double num1 = double.Parse(textBox1.Text);
                double num2 = double.Parse(textBox2.Text);

                // Perform calculation based on selected operation
                double result = 0;
                switch (comboBox1.SelectedItem.ToString())
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        result = num1 / num2;
                        break;
                    default:
                        MessageBox.Show("Please select a valid operation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                // Display the result
                label4.Text = "Result: " + result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Cannot divide by zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
