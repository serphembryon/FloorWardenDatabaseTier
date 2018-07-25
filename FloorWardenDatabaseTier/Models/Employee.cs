using System;
using System.Collections.Generic;

namespace FloorWardenDatabaseTier.Models
{
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Email { get; set; }
        public string Building { get; set; }
        public int Floor { get; set; }
        public string Room { get; set; }
        public string Phone { get; set; }
        public int WardenInd { get; set; }
        public int ActiveInd { get; set; }
    }
}
