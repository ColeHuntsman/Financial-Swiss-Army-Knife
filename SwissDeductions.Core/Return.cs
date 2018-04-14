using System;
using System.Collections.Generic;
using System.Text;

namespace SwissDeductions.core
{
    public class Return
    {
        public IPerson Filer { get; set; }
        public State ReturnState { get; set; }
        public IDeductions Deductions { get; set; }

        public Return()
        {
            Filer = new Person();
        }
    }
}
