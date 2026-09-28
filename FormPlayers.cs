namespace PlayerCards {
    public partial class FormPlayers : Form {
        public FormPlayers() {
            InitializeComponent();
        }

        private void btnAddPlayer_Click(object sender, EventArgs e) {
            // Instanciraj objekt igrača prema podacima u texboxovima
            // i dodaj u listu igrača

            // Svojstvo tbPlayerFirstName.Text sadrži ime igrača

            // Unos u listu se vrši pomoću Items kolekcije i metode Add
            
            // Mi unosimo objekte u listu, ne stringove kao u sljedećem primjeru:
            lbPlayers.Items.Add("Luka Paljetko - 12");
        }
    }
}
