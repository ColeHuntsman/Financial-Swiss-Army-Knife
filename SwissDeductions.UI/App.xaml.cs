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
            var userPage = FreshPageModelResolver.ResolvePageModel<UserInfoPageModel>();
            SetMainPage(userPage);
        }

        public void ShowWelcomePage()
        {
            MainPage = new WelcomePage();
        }

        public void ShowIncomePage()
        {
            MainPage = new IncomePage();
        }

        public void ShowDependantPage()
        {
            MainPage = new DependantPage();
        }

        public void ShowDissabilityPage()
        {
            MainPage = new DissabilityPage();
        }

        public void ShowHomeOwnerPage()
        {
            MainPage = new HomeOwnerPage();
        }

        public void ShowDonationsPage()
        {
            MainPage = new DonationsPage();
        }

        public void ShowLastStepPage()
        {
            MainPage = new LastStepPage();
        }

        public void ShowFinalDeductablePage()
        {
            MainPage = new FinalDeductablePage();
        }
        void SetMainPage (Page homePage)
        {
            MainPage = new FreshNavigationContainer(homePage)
            {

            };
        }
    }
}
