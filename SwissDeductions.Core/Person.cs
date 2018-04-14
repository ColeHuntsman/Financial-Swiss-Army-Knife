using System;
using System.Collections.Generic;
using System.Text;

namespace IUserInformation
{
    class Person : IPerson
    {
        public string Name { get; set; }

        public DateTime Birthday { get; set; }

        public string SocialSecurityNumber { get; set; }
                                                                                  
        public double GrossIncome { get; set; }
                                                                                                                                                       
        public int Year { get; set; }
                                                                                  
        public bool Single { get; set; }
                                                                                  
        public bool Dependants { get; set; }
                                                                                  
        public int NumOfDependants { get; set; }
                                                                                  
        public bool Disabled { get; set; }
                                                                                  
        public bool Over18 { get; set; }
                                                                                  
        public bool HomeOwner { get; set; }
                                                                                  
        public int PropCost { get; set; }
                                                                                  
        public bool Donations { get; set; }
                                                                                  
        public double DonationAmnt { get; set; }
    }
}
