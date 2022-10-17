namespace Opdracht5 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

            // °F = °C * 9/5 + 32
            // °C = (°F -32) * 5/9


        }

        private void btnConvertCF_Click(object sender, EventArgs e) {
            double fahrenheit =  double.Parse(txtCelsius.Text);
            txtFahrenheit.Text = (fahrenheit * 9 / 5 + 32).ToString();
        }

        private void btnConvertFC_Click(object sender, EventArgs e) {
            double celsius = double.Parse(txtFahrenheit.Text);
            txtCelsius.Text = ((celsius - 32 )* 5 / 9).ToString();
        }
    }
}