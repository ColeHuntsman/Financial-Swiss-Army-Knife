using System;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Text;
using SwissDeductions.UI.Helpers;
using SwissDeductions.core;

namespace SwissDeductions.UI.PageModels
{
    class UserInfoPageModel : BasePageModel
    {
        ILocalSettings settings;
        Return currentReturn;

        public Command Next => new Command(() => App.Current.ShowWelcomePage());

        public string Name {
            get => currentReturn.Filer.Name;
            set => currentReturn.Filer.Name = value;
        }

        public bool IsFilingMarried {
            get => !currentReturn.Deductions.Single;
            set => currentReturn.Deductions.Single = !value;
        }

        public string State { get; set; }

        public UserInfoPageModel(ILocalSettings localSettings)
        {
            settings = localSettings;
            currentReturn = settings.CurrentReturn;
            if (currentReturn.Filer == null)
                currentReturn.Filer = new Person();

            if (currentReturn.ReturnState == null)
                currentReturn.ReturnState = new Utah();

            if (currentReturn.Deductions == null)
                currentReturn.Deductions = new Deductions();
        }

        protected override void ViewIsDisappearing(object sender, EventArgs e)
        {
            base.ViewIsDisappearing(sender, e);
            settings.CurrentReturn = currentReturn;
        }
    }
}
