using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAdvanced.Session_5.Models
{
    public class Staff
    {
        public int _staffID { get; set; }
        public string _staffName { get; set; }
        public DateTime _birthofDate { get; set; }
        public decimal _salary { get; set; }
        public string _staffImage { get; set; }
    }
}