using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriesCalculatorEF2
{
    public interface IShow
    {
        void ShowActivity(string name);
        void ShowRecommendation(double CaloriesBurned);
    }
}
