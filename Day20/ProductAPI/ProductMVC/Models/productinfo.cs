using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductMVC.Models
{
    public class productinfo
    {
        public int prodid { get; set; }
        public string prodname { get; set; }
        public Nullable<int> quantity { get; set; }
        public string proddesc { get; set; }
    }
}