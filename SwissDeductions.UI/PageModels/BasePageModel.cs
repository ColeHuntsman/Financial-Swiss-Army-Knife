using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using FreshMvvm;
using Xamarin.Forms;

namespace SwissDeductions
{
    public class BasePageModel : FreshBasePageModel
    {

        bool isBusy = false;
        public bool IsBusy { get; set; }

        public string Title { get; set; }
        
    }
}
