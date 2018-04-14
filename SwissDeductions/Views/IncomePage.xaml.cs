using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SwissDeductions.Views
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
