using System;
using System.Collections.Generic;
using System.Text;

namespace IUserInformation
{
    public interface IPerson
    {
        string Name { get; }
        DateTime Birthday { get; }
        string SocialSecurityNumber { get; }
        double GrossIncome { get; }
        //string UserName { get; }
        //string Password { get; }
        int Year { get; }
        

    }
}
