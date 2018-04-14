using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Text;

namespace SwissDeductions.UI.PageModels
{
    class WelcomePageModel : BasePageModel
    {
        public Command LoginCommand => new Command(() => App.Current.ShowIncomePage());




    }
}
