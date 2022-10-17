namespace Opdracht2 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

            txtRes1.Text = (int.Parse(lblEen.Text) * int.Parse(lblTwee.Text)).ToString();
            txtRes2.Text = (int.Parse(label10.Text) * int.Parse(label11.Text)).ToString();

            txtFinalRes.Text = (int.Parse(txtRes1.Text) > int.Parse(txtRes2.Text)).ToString();

        }

        private void txtRes1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}