using Microsoft.Maui.Controls;

namespace MoustaphaSyNotes
{
    public partial class MainPage : ContentPage
    {
        string fileName = Path.Combine(FileSystem.AppDataDirectory, "notes.txt");
        Label notesHeading;

        public MainPage()
        {
            

            InitializeComponent();

            if (File.Exists(fileName))
            {
                editor.Text = File.ReadAllText(fileName);
            }
            var buttonsGrid = new Grid() { HeightRequest = 40.0 };
            buttonsGrid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1.0, GridUnitType.Auto) });
            buttonsGrid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(30.0, GridUnitType.Absolute) });
            buttonsGrid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1.0, GridUnitType.Auto) });

            var saveButton = new Button() { WidthRequest = 100, Text = "Save" };
            saveButton.Clicked += OnSaveButtonClicked;
            Grid.SetColumn(saveButton, 0);
            buttonsGrid.Children.Add(saveButton);

            var deleteButton = new Button() { WidthRequest = 100, Text = "Delete" };
            deleteButton.Clicked += OnDeleteButtonClicked;
            Grid.SetColumn(deleteButton, 2);
            buttonsGrid.Children.Add(deleteButton);

            var stackLayout = new VerticalStackLayout
            {
                Padding = new Thickness(30, 60, 30, 30),
                Children = { notesHeading, editor, buttonsGrid }
            };

            this.Content = stackLayout;
        }

        private void OnSaveButtonClicked(object sender, EventArgs e)
        {
            // Implémentation de la logique de sauvegarde ici
            File.WriteAllText(fileName, editor.Text);
        }

        private void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            // Implémentation de la logique de suppression ici
            File.Delete(fileName);
            editor.Text = string.Empty; // Effacer le contenu de l'éditeur après la suppression
        }

        private Thickness GetStackLayoutPadding()
        {
            if (DeviceInfo.Platform == DevicePlatform.iOS)
            {
                return new Thickness(30, 60, 30, 30); // Shift down by 60 points on iOS only
            }
            else
            {
                return new Thickness(30); // Set the default margin to be 30 points
            }
        }
    }

}