using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Reflection;

namespace MoustaphaSyMauiXaml
{
    public partial class MainPage : ContentPage
    {
        Button loginButton;
        VerticalStackLayout layout;
        Label CounterLabel; // Ajout du champ CounterLabel
        int count = 0;

        public MainPage()
        {
            
            this.BackgroundColor = Color.FromRgb(81, 43, 223); 

            layout = new VerticalStackLayout
            {
                Margin = new Thickness(15, 15, 15, 15),
                Padding = new Thickness(30, 60, 30, 30),
                Children =
                {
                    new Label { Text = "Please log in", FontSize = 30, TextColor = Color.FromRgb(255, 255, 100) },
                    new Label { Text = "Username", TextColor = Color.FromRgb(255, 255, 255) },
                    new Entry (),
                    new Label { Text = "Password", TextColor = Color.FromRgb(255, 255, 255) },
                    new Entry { IsPassword = true }
                }
            };

            CounterLabel = new Label(); // Initialisation du CounterLabel
            layout.Children.Add(CounterLabel); // Ajout du CounterLabel à la disposition

            loginButton = new Button { Text = "Login", BackgroundColor = Color.FromRgb(0, 148, 255) };
            layout.Children.Add(loginButton);

            Content = layout;

            loginButton.Clicked += (sender, e) =>
            {
                Debug.WriteLine("Clicked !");
                count++;
                CounterLabel.Text = $"Current count: {count}";
            };
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            
        }
    }
}
