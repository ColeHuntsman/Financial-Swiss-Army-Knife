using System;
using SwissDeductions.UI.Pages;
using FreshMvvm;
using Xamarin.Forms;
using SwissDeductions.UI.PageModels;

namespace SwissDeductions.UI
{
    public partial class App : Application
    {

        public new static App Current => (App)Xamarin.Forms.Application.Current;

        public App()
        {
            InitializeComponent();

            // if (Device.RuntimePlatform == Device.iOS)
            ShowLoginPage();
            //else
            //    MainPage = new NavigationPage(new MainPage());
        }
        public void ShowLoginPage()
        {
            var loginRoot = FreshPageModelResolver.ResolvePageModel<LoginPageModel>();
            SetMainPage(loginRoot);
        }
        public void ShowUserInfoPage()
        {
            var Page = FreshPageModelResolver.ResolvePageModel<UserInfoPageModel>();
            SetMainPage(Page);
        }

        public void ShowWelcomePage()
        {
            var Page = FreshPageModelResolver.ResolvePageModel<WelcomePageModel>();
            SetMainPage(Page);
        }

        public void ShowIncomePage()
        {
            var Page = FreshPageModelResolver.ResolvePageModel<IncomePageModel>();
            SetMainPage(Page);
        }

        public void ShowDependantPage()
        {
            var Page = FreshPageModelResolver.ResolvePageModel<DependantPageModel>();
            SetMainPage(Page); 
        }

        public void ShowDissabilityPage()
        {
            var Page = FreshPageModelResolver.ResolvePageModel<DissabilityPageModel>();
            SetMainPage(Page);
        }

        public void ShowHomeOwnerPage()
        {
            var Page = FreshPageModelResolver.ResolvePageModel<HomeOwnerPageModel>();
            SetMainPage(Page);
        }

        public void ShowDonationsPage()
        {
            var Page = FreshPageModelResolver.ResolvePageModel<DonationsPageModel>();
            SetMainPage(Page);
        }

        public void ShowLastStepPage()
        {
            var Page = FreshPageModelResolver.ResolvePageModel<LastStepPageModel>();
            SetMainPage(Page);
        }

        public void ShowFinalDeductablePage()
        {
            var Page = FreshPageModelResolver.ResolvePageModel<FinalDeductablePageModel>();
            SetMainPage(Page);
        }
        void SetMainPage (Page homePage)
        {
            MainPage = new FreshNavigationContainer(homePage)
            {

            };
        }
    }
}
