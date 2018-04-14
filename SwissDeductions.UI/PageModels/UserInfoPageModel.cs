using System;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Text;

namespace SwissDeductions.UI.PageModels
{
    class UserInfoPageModel : BasePageModel
    {
        public Command Next => new Command(() => App.Current.ShowWelcomePage());

        public string Name { get; set; }

        public bool IsFilingMarried { get; set; }

        public string State { get; set; }
    }
}
