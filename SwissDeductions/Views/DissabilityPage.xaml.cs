using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SwissDeductions.Views
{
    public partial class DissabilityPage : ContentPage
    {
        public DissabilityPage()
        {
            InitializeComponent();
        }

        public void Handle_Clicked(object sender, EventArgs e)
        {
            App.Current.ShowHomeOwnerPage();
        }
    }
}
