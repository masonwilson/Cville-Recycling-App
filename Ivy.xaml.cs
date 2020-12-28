using System;
using System.Collections.Generic;
using System.Windows.Input;
using Rg.Plugins.Popup.Pages;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace App2
{
    // create popup page 
    public partial class Ivy : PopupPage
    {
        // sets up open browser if link is clicked 
        public ICommand TapCommand => new Command<string>(OpenBrowser);

        public Ivy()
        {
            // initialize page 
            InitializeComponent();
            BindingContext = this;
        }

        // method to open browser when link is pressed
        void OpenBrowser(string url)
        {
            Launcher.OpenAsync(new System.Uri(url));
        }
    }
}
