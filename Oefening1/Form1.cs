namespace Oefening1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e) {
            String succesBoodschap = "De app is succesvol gesloten.";

            txtBegroeting.Text = succesBoodschap;
        }

        private void Form1_Load(object sender, EventArgs e) {
            String gebruiker = Environment.UserName;
            String tijd = DateTime.Now.ToShortTimeString();
            String datum = DateTime.Now.ToShortDateString();

            txtBegroeting.Text = "Hallo " + gebruiker + ", het is momenteel " + tijd + " op " + datum + ".";
        }
    }
}