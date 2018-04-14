using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SwissDeductions.Views
{
    public partial class HomeOwner : ContentPage
    {
        public HomeOwner()
        {
            InitializeComponent();
        }

        public void Handle_Clicked(object sender, EventArgs e)
        {
            App.Current.ShowDonationsPage();
        }
    }
}
