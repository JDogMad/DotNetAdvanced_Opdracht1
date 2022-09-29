namespace Opdracht1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            string userName = Environment.UserName;
            string time = DateTime.Now.ToShortTimeString();
            string date = DateTime.Now.ToShortDateString();

            txtBegroeting.Text = "Hallo, " + userName + " , het is " + time + " op " + date + ".";  
        }

        private void txtBegroeting_Click(object sender, EventArgs e)
        {

        }
    }
}