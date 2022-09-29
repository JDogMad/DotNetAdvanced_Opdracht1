namespace Opdracht2 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

            txtRes1.Text = (int.Parse(txtVar1.Text) * int.Parse(txtVar2.Text)).ToString();
            txtRes2.Text = (int.Parse(txtVar3.Text) * int.Parse(txtVar4.Text)).ToString();

            txtFinalRes.Text = (int.Parse(txtRes1.Text) > int.Parse(txtRes2.Text)).ToString();

        }
    }
}