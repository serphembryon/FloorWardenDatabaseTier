using System;
using System.Collections.Generic;

namespace FloorWardenDatabaseTier.Models
{
    public class JSONEmployee
    {
        public int EmployeeId { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public string email { get; set; }
        public string building { get; set; }
        public int floor { get; set; }
        public string room { get; set; }
        public string phone { get; set; }
    }
}