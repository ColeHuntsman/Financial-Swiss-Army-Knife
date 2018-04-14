using System;

namespace SwissDeductions.core
{
    public abstract class State
    {
        string state;
        double incomeTax;
        double propTax;

        protected State(string name, double iTax)
        {
            state = name;
            incomeTax = iTax;
            
            
        }
        public virtual double taxIncome(double a)
        {

            double grossIncome = a;
            double answer = grossIncome - (a * incomeTax);

            return (answer);
        }

        

    }
}
