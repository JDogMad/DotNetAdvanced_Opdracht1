namespace Opdracht7 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e) {
            int number = int.Parse(txtNumber.Text);
            int answer = 0;

            for (int i = number; i > 0; i--) {
                answer = answer + i;
            }

            txtAnswer.Text = answer.ToString();
        }
    }
}