namespace Q3TshirtOrderingCalculator
{
    public partial class Form1 : Form
    {
        const double SmallPrice = 125;
        const double MediumPrice = 175;
        const double LargePrice = 250;
        const double DiscountRate = 0.1;
        const double GstRate = 0.09;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!int.TryParse(textBox2.Text, out var quantity))
            {
                MessageBox.Show("Please enter a valid number for the quantity.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double totalPrice = 0;
            switch(comboBox1.SelectedItem.ToString())
            {
                case "Small":
                    totalPrice = SmallPrice * quantity;
                    break;
                case "Medium":
                    totalPrice = MediumPrice * quantity;
                    break;
                case "Large":
                    totalPrice = LargePrice * quantity;
                    break;
            }
            if(textBox1.Text == "TRUEBLUE")
            {
                totalPrice -= totalPrice * DiscountRate;
            }
            totalPrice += totalPrice * GstRate;
            label4.Text = "Final Price: Rs. " + totalPrice.ToString("0.00");
            
        }
    }
}
