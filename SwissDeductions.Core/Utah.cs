using System;
using System.Collections.Generic;
using System.Text;

namespace IUserInformation
{
    class Utah:State
    {
        protected Utah() : base("Utah", 5.0, .75)
        {

        }

        public override double taxIncome(double a, double b)
        {
            return base.taxIncome(a, b);
        }

        public override double taxProp(double a, double b)
        {
            return base.taxProp(a, b);
        }
    }

    class NewMexico:State
    {
        protected NewMexico() : base("New Mexico", 5.90, .66)
        {
          
        }
    }

    class Nebraska : State
    {
        protected Nebraska() :base("Nebraska", 7.81, 1.65)
        {

        }
    }

    class Oklahoma : State
    {
        protected Oklahoma() : base("Oklahoma", 6.00, .85)
        {

        }
    }


}
