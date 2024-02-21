namespace TipCalculator
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private Color colorNavy = Colors.Navy;
        private Color colorSilver = Colors.Silver;

        private void OnNormalTip(object sender, EventArgs e)
        {
            // Code à exécuter lorsque le bouton "15%" est cliqué
            // Par exemple, vous pourriez mettre à jour les labels en conséquence.
            double billAmount = Convert.ToDouble(billInput.Text);
            double tipPercentage = 15; // Vous pouvez obtenir la valeur du pourcentage à partir du slider, si nécessaire.
            double tipAmount = (billAmount * tipPercentage) / 100;
            double totalAmount = billAmount + tipAmount;

            // Mettez à jour les labels
            tipOutput.Text = tipAmount.ToString("0.00");
            totalOutput.Text = totalAmount.ToString("0.00");
        }

        private void OnGenerousTip(object sender, EventArgs e)
        {
            // Code à exécuter lorsque le bouton "20%" est cliqué
            // Par exemple, vous pourriez mettre à jour les labels en conséquence.
            double billAmount = Convert.ToDouble(billInput.Text);
            double tipPercentage = 20; // Vous pouvez obtenir la valeur du pourcentage à partir du slider, si nécessaire.
            double tipAmount = (billAmount * tipPercentage) / 100;
            double totalAmount = billAmount + tipAmount;

            // Mettez à jour les labels
            tipOutput.Text = tipAmount.ToString("0.00");
            totalOutput.Text = totalAmount.ToString("0.00");
        }

        void OnLight(object sender, EventArgs e)
        {
            LayoutRoot.BackgroundColor = colorSilver;

            tipLabel.TextColor = colorNavy;
            billLabel.TextColor = colorNavy;
            totalLabel.TextColor = colorNavy;
            tipOutput.TextColor = colorNavy;
            totalOutput.TextColor = colorNavy;
            Resources["fgColor"] = colorNavy;
            Resources["bgColor"] = colorSilver;
        }

        void OnDark(object sender, EventArgs e)
        {
            LayoutRoot.BackgroundColor = colorNavy;

            tipLabel.TextColor = colorSilver;
            billLabel.TextColor = colorSilver;
            totalLabel.TextColor = colorSilver;
            tipOutput.TextColor = colorSilver;
            totalOutput.TextColor = colorSilver;
            Resources["fgColor"] = colorSilver;
            Resources["bgColor"] = colorNavy;
        }
    }

}
