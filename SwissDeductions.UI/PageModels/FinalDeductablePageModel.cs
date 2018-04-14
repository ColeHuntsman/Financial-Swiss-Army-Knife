using SwissDeductions.core;
using SwissDeductions.UI.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwissDeductions.UI.PageModels
{
    class FinalDeductablePageModel : BasePageModel
    {
        ILocalSettings settings;
        Return currentReturn;

        public FinalDeductablePageModel(ILocalSettings localSettings)
        {
            settings = localSettings;
            currentReturn = localSettings.CurrentReturn;
        }
        protected override void ViewIsDisappearing(object sender, EventArgs e)
        {
            base.ViewIsDisappearing(sender, e);
            settings.CurrentReturn = currentReturn;
        }

        public string Deductable
        {
           get => currentReturn.ReturnState.taxIncome(Convert.ToDouble(currentReturn.AnualIncome)).ToString();
        }

    }
}
