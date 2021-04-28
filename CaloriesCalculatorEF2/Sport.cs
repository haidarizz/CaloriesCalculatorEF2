using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriesCalculatorEF2
{
    public abstract class Sport
    {
        protected string when;
        protected double time;

        public Sport(string when, double time)
        {
            this.when = when;
            this.time = time;
        }

        public abstract double CalculateCaloriesBurned(double weight, double time, double velocity);
    }
}
