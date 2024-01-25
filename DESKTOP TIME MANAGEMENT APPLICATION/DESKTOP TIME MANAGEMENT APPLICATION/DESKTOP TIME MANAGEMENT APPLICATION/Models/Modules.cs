using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POE.Models
{
    public class Modules
    {

        public string Code { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Credit { get; set; }
        public int ClassPerHour { get; set; }
        public int Weeks { get; set; }
        public int Used_hours { get; set; }
        public int Self_study { get; set; }
        public int Remaining_Hours { get; set; }
    }
}