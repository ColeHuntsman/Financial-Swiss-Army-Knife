using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SwissDeductions.UI.Pages
{
    public partial class UserInfoPage : ContentPage
    {
        public UserInfoPage()
        {
            InitializeComponent();
        }

        public void Handle_Clicked(object sender, EventArgs e)
        {
            App.Current.ShowWelcomePage();
        }
    }
}
