using System;
using System.Collections.Generic;
using System.Text;

namespace SwissDeductions.core
{
    public interface IDeductions
    {
        bool Single { get; set; }
        int NumOfDependants { get; }
        bool Disabled { get; }
        bool Over18 { get; }
        bool HomeOwner { get; }
        int PropCost { get; }
        bool Donations { get; }
        double DonationAmnt { get; }
    }
}
