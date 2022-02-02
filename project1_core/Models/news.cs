using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project1_core.Models
{
    public class news
    {
        public int id { get; set; }
        public string title { get; set; }
        public DateTime Date { get; set; }
        public string img { get; set; }
        public string topic { get; set; }


         
        public int catogriid { get; set; }
        public catogri catogri { get; set; }
    }
}
