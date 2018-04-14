using System;
using SwissDeductions.Views;
using Xamarin.Forms;

namespace SwissDeductions
{
    public partial class App : Application
    {
        public static bool UseMockDataStore = true;
        public static string BackendUrl = "https://localhost:5000";

        public new static App Current => (App)Xamarin.Forms.Application.Current;

        public App()
        {
            InitializeComponent();

            if (UseMockDataStore)
                DependencyService.Register<MockDataStore>();
            else
                DependencyService.Register<CloudDataStore>();

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
            MainPage = new HomeOwner();
        }

        public void ShowDonationsPage()
        {
            MainPage = new DonationsPage();
        }
    }
}
