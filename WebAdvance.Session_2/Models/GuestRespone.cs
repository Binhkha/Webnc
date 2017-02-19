using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAdvance.Session_2.Models
{
    public class GuestRespone
    {


        public string Name { get; set; }
        public string Email { get; set; }

        public string Phone { get; set; }

        public bool? willAttend { get; set; }
    }
}