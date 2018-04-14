using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Text;

namespace SwissDeductions.UI.PageModels
{
    class IncomePageModel : BasePageModel
    {
        public Command Next => new Command(() => App.Current.ShowDependantPage());

    }
}
