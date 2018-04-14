using System;
using System.Collections.Generic;
using System.Text;

namespace SwissDeductions.core
{
    public class Return
    {
        public Person Filer { get; set; }
        public Utah ReturnState { get; set; }
        public Deductions Deductions { get; set; }
        public string AnualIncome { get; set; }
        public string GrossIncome { get; set; }


        public Return()
        {
            Filer = new Person();

        }
    }
}
