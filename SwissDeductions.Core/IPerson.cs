using System;
using System.Collections.Generic;
using System.Text;

namespace SwissDeductions.core
{
    public interface IPerson
    {
        string Name { get; set; }
        DateTime Birthday { get; }
        string SocialSecurityNumber { get; }
        double GrossIncome { get; }
        //string UserName { get; }
        //string Password { get; }
        int Year { get; }
        

    }
}
