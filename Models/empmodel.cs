using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCURD.Models
{
    public class empmodel
    {
        public int id { get; set; }
        
        public string Name { get; set; }
        public string Phone { get; set; }
        public string email { get; set; }
        public Nullable<int> salary { get; set; }
    }
}