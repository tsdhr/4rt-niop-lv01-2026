namespace PlayerCards {
    public partial class FormPlayers : Form {
        public FormPlayers() {
            InitializeComponent();
        }

        private void btnAddPlayer_Click(object sender, EventArgs e) {
            try {
                var number = int.Parse(tbPlayerNumber.Text);
                // Instanciraj objekt igrača prema podacima u texboxovima
                Player player = new Player(tbPlayerFirstName.Text, tbPlayerLastName.Text, number);
                // Unos u listu se vrši pomoću Items kolekcije i metode Add
                lbPlayers.Items.Add(player);
            }
            catch (Exception ex) {
                MessageBox.Show($"Greška prilikom unosa igrača:\n{ex.Message}");
            }
        }
    }
}
