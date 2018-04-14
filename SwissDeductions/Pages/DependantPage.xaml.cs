using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SwissDeductions.Views
{
    public partial class DependantPage : ContentPage
    {
        public DependantPage()
        {
            InitializeComponent();
        }

        public void Handle_Clicked(object sender, EventArgs e)
        {
            App.Current.ShowDissabilityPage();
        }
    }
}
