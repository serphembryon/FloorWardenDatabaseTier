using System;
using System.Collections.Generic;

namespace FloorWardenDatabaseTier.Models
{
    public partial class LinkWardenEmployee
    {
        public int LnkWardenEmpId { get; set; }
        public int WardenId { get; set; }
        public int EmployeeId { get; set; }
        public int ActiveInd { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
