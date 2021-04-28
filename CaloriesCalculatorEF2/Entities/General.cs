using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriesCalculatorEF2.Entities
{
    class General
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GeneralID { get; set; }
        public string Name { get; set; }
        public int Sex { get; set; }
        public int Age { get; set; }
    }
}
