using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SwissDeductions.UI.PageModels
{
    class LoginPageModel : BasePageModel
    {
        public Command LoginCommand => new Command(() => App.Current.ShowUserInfoPage());

        public string Email { get; set; }
        public string Password { get; set; }
    }
}
