namespace CommandeFastFoodCafe
{
    public partial class FrmCommande : Form
    {
        private decimal ObtenirPrix(string produit)
        {
            switch (produit)
            {
                case "Café":
                    return 10.00m;
                case "Thé":
                    return 8.00m;
                case "Jus":
                    return 12.00m;
                case "Sandwich":
                    return 25.00m;
                case "Pizza":
                    return 50.00m;
                case "Tacos":
                    return 30.00m;
                default:
                    return 0.00m;
            }
        }

        private void MettreAJourTotal()
        {
            decimal total = 0;
            
            foreach(DataGridViewRow ligne in dgvCommande.Rows)
            {
                total += Convert.ToDecimal(ligne.Cells["colSousTotal"].Value);
            }
            lblTotal.Text = total.ToString("0.00") + " DH";
        }
        public FrmCommande()
        {
            InitializeComponent();
        }

        private void FrmCommande_Load(object sender, EventArgs e)
        {
            cmbProduit.Items.Add("Café");
            cmbProduit.Items.Add("Thé");
            cmbProduit.Items.Add("Jus");
            cmbProduit.Items.Add("Sandwich");
            cmbProduit.Items.Add("Pizza");
            cmbProduit.Items.Add("Tacos");

            cmbProduit.SelectedIndex = 0;
            
            dgvCommande.Columns.Clear();

            dgvCommande.Columns.Add("ColProduit", "Produit");
            dgvCommande.Columns.Add("ColPrix", "Prix");
            dgvCommande.Columns.Add("ColQuantite", "Quantité");
            dgvCommande.Columns.Add("ColSousTotal", "Sous-Total");

            lblTotal.Text = "0,00 DH";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string produit = cmbProduit.SelectedItem.ToString();
            decimal prix = ObtenirPrix(produit);
            int quantite = (int)numQuantite.Value;
            decimal sousTotal = prix * quantite;

            dgvCommande.Rows.Add(produit, prix, quantite, sousTotal);
            MettreAJourTotal();
        }
    }
}
