using static System.Net.Mime.MediaTypeNames;

namespace Opdracht4 {
    public partial class TaxRateCalculator : Form {
        public TaxRateCalculator() {
            InitializeComponent();
        }

//bereken en toon Ext.Price(quantity* price Each)
//bereken en toon Subtotal
//bereken en toon Sales Tax(subtotal* tax rate)
//bereken en toon Grand Total(subtotal + sales sax + shipping)

        private void btnCalculate_Click(object sender, EventArgs e) {
            txtRes1.Text = (double.Parse(qty1.Value.ToString()) * double.Parse(txtPrice1.Text)).ToString();
            txtRes2.Text = (double.Parse(qty2.Value.ToString()) * double.Parse(txtPrice2.Text)).ToString();
            txtRes3.Text = (double.Parse(qty3.Value.ToString()) * double.Parse(txtPrice3.Text)).ToString();
            txtRes4.Text = (double.Parse(qty4.Value.ToString()) * double.Parse(txtPrice4.Text)).ToString();

            txtSubTotaal.Text = (double.Parse(txtRes1.Text) + double.Parse(txtRes2.Text) + double.Parse(txtRes3.Text) + double.Parse(txtRes4.Text)).ToString();

            txtSalesTax.Text = (double.Parse(txtTaxRate.Text) * double.Parse(txtSubTotaal.Text)).ToString();

            txtGrandTotal.Text = (double.Parse(txtSubTotaal.Text) + double.Parse(txtSalesTax.Text) + double.Parse(txtShipping.Text)).ToString();
        }

        private void txtRes1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}