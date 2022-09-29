namespace Opdracht6{
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) {
        }

        private void btnCalculate_Click(object sender, EventArgs e) {
            txtSubTotal1.Text = (double.Parse(qty1.Text) * double.Parse(txtPrice1.Text)).ToString();
            txtSubTotal2.Text = (double.Parse(qty2.Text) * double.Parse(txtPrice2.Text)).ToString();
            txtSubTotal3.Text = (double.Parse(qty3.Text) * double.Parse(txtPrice3.Text)).ToString();
            txtSubTotal4.Text = (double.Parse(qty4.Text) * double.Parse(txtPrice4.Text)).ToString();

            txtSubTotaal.Text = (double.Parse(txtSubTotal1.Text) + double.Parse(txtSubTotal2.Text) + double.Parse(txtSubTotal3.Text) + double.Parse(txtSubTotal4.Text)).ToString();

            if (double.Parse(txtSubTotaal.Text) < 20)
            {
                txtGrandTotal.Text = (double.Parse(txtSubTotaal.Text) + double.Parse(txtSalesTax.Text) + 5).ToString();
            }
            else if (double.Parse(txtSubTotaal.Text) < 50)
            {
                txtGrandTotal.Text = (double.Parse(txtSubTotaal.Text) + double.Parse(txtSalesTax.Text) + 7.5).ToString();
            }
            else if (double.Parse(txtSubTotaal.Text) < 75)
            {
                txtGrandTotal.Text = (double.Parse(txtSubTotaal.Text) + double.Parse(txtSalesTax.Text) + 10).ToString();
            }
            else if (double.Parse(txtSubTotaal.Text) >= 75)
            {
                txtGrandTotal.Text = (double.Parse(txtSubTotaal.Text) + double.Parse(txtSalesTax.Text)).ToString();
            }
        }
    }
}