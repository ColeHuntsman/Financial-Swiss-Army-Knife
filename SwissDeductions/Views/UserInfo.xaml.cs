using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SwissDeductions.Views
{
    public partial class UserInfo : ContentPage
    {
        public UserInfo()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            App.Current.ShowWelcomePage();
        }
    }
}
