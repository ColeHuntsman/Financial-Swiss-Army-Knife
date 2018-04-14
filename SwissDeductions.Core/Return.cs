using System;
using System.Collections.Generic;
using System.Text;

namespace IUserInformation
{
    public class Return
    {
        public IPerson Filer { get; }
        public State ReturnState { get; set; }
        public IDeductions Deductions { get; set; }

        public Return(IPerson filer)
        {
            Filer = filer;            
        }
        
    }
}
