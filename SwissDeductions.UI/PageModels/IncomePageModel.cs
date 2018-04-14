using System;
using System.Collections.Generic;
using SwissDeductions.UI.Helpers;
using Xamarin.Forms;
using SwissDeductions.core;
using System.Text;

namespace SwissDeductions.UI.PageModels
{
    class IncomePageModel : BasePageModel
    {
        ILocalSettings settings;
        Return currentReturn;

        public IncomePageModel(ILocalSettings localSettings)
        {
            settings = localSettings;
            currentReturn = localSettings.CurrentReturn;
        }
        protected override void ViewIsDisappearing(object sender, EventArgs e)
        {
            base.ViewIsDisappearing(sender, e);
            settings.CurrentReturn = currentReturn;
        }

        public string Gross
        {
            get => currentReturn.GrossIncome;

            set => currentReturn.GrossIncome = value;
        }
        public string Nti
        {
            get => currentReturn.AnualIncome;

            set => currentReturn.AnualIncome = value;
        }

        public Command Next => new Command(() => App.Current.ShowDependantPage());

    }
}
