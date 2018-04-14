using System;
using System.Collections.Generic;
using System.Text;

namespace SwissDeductions.core
{
    public class Person : IPerson
    {
        public string Name { get; set; }

        public DateTime Birthday { get; set; }

        public string SocialSecurityNumber { get; set; }
                                                                                  
        public double GrossIncome { get; set; }
                                                                                                                                                       
        public int Year { get; set; }
                                                                                  
      
    }
}
