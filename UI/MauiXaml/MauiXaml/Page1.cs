using System;
using System.Diagnostics;


namespace MoustaphaSyMauiXaml
{
    public partial class Page1 : ContentPage, IPageController
    {
        public Page1()
        {
            InitializeComponent();
        }

        void LoginButton_Clicked(object sender, EventArgs e)
        {
            Debug.WriteLine("Clicked !");
        }
    }
}
