using System;
using SwissDeductions.UI.Pages;
using Xamarin.Forms;

namespace SwissDeductions.UI
{
    public partial class App : Application
    {
        public static bool UseMockDataStore = true;
        public static string BackendUrl = "https://localhost:5000";

        public new static App Current => (App)Xamarin.Forms.Application.Current;

        public App()
        {
            InitializeComponent();

            // if (Device.RuntimePlatform == Device.iOS)
            MainPage = new LoginPage();
            //else
            //    MainPage = new NavigationPage(new MainPage());
        }

        public void ShowUserInfoPage()
        {
            MainPage = new UserInfo();

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
    }
}
