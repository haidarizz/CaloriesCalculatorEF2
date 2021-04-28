using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriesCalculatorEF2.Entities
{
    class Body
    {
        [Key]
        public int BodyID { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
    }
}
