using System;
using System.Collections.Generic;
using System.Text;

namespace IUserInformation
{
    public interface IDeductions
    {
        bool Single { get; }
        int NumOfDependants { get; }
        bool Disabled { get; }
        bool Over18 { get; }
        bool HomeOwner { get; }
        int PropCost { get; }
        bool Donations { get; }
        double DonationAmnt { get; }
    }
}
