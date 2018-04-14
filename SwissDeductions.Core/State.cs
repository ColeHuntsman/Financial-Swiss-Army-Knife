using System;

namespace IUserInformation
{
    public abstract class State
    {
        string state;
        double incomeTax;
        double propTax;

        protected State(string name, double iTax, double pTax)
        {
            state = name;
            incomeTax = iTax;
            propTax = pTax;
            
        }
        public virtual double taxIncome(double a, double b)
        {

            double grossIncome = a;
            double answer = grossIncome - (a * b);

            return (answer);
        }

        public virtual double taxProp(double a, double b)
        {

            double grossIncome = a;
            double answer = grossIncome - (a * b);

            return (answer);
        }

    }
}
