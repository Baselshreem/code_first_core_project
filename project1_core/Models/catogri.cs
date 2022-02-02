using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project1_core.Models
{
    public class catogri
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
         public List<news> News { get; set; }
        
    }
}
