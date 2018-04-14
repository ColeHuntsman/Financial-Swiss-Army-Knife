using System;
using System.Collections.Generic;
using Acr.UserDialogs;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using FreshMvvm;
using Xamarin.Forms;

namespace SwissDeductions
{
    class BasePageModel : FreshBasePageModel
    {
        protected string PageName => GetType().Name.Replace("PageModel", " ");

        bool _isBusy;

        protected bool IsBusy
        {
            get => _isBusy;
            set
            {
                _isBusy = value;
                RaisePropertyChanged();

                if (value && IsVisible)
                    ShowLoadingIfNeeded();

                if (!value)
                    UserDialogs.Instance.HideLoading();
            }
        }

        public string Title { get; set; }
        public bool IsVisible { get; set; }

        void ShowLoadingIfNeeded ()
        {
            if (IsBusy && IsVisible)
                UserDialogs.Instance.ShowLoading();
        }

        protected override void ViewIsAppearing(object sender, EventArgs e)
        {
            base.ViewIsAppearing(sender, e);
            IsVisible = true;
            ShowLoadingIfNeeded();
        }

        protected override void ViewIsDisappearing(object sender, EventArgs e)
        {
            base.ViewIsDisappearing(sender, e);
            IsVisible = false;
        }
    }
}
