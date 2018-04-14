using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SwissDeductions.UI.Pages
{
    public partial class IncomePage : ContentPage
    {
        public IncomePage()
        {
            InitializeComponent();
        }

        public void Handle_Clicked(object sender, EventArgs e)
        {
            App.Current.ShowDependantPage();
        }
    }
}
