using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAPIApp.Models
{
    public class Registration
    {
        public int id { get; set; }
        public string UserName { get; set; }
        public string Role { get; set; }
        public string Password { get; set; }
    }
}