using System;
using System.Collections.Generic;
using System.Text;

namespace IUserInformation
{
    class Deductions : IDeductions
    {
        public bool Single { get; set; }

        public int NumOfDependants { get; set; }

        public bool Disabled { get; set; }

        public bool Over18 { get; set; }

        public bool HomeOwner { get; set; }

        public int PropCost { get; set; }

        public bool Donations { get; set; }

        public double DonationAmnt { get; set; }
    }
}
