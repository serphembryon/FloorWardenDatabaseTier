using System;
using System.Collections.Generic;

namespace FloorWardenDatabaseTier.Models
{
    public partial class RefEmployeeStatus
    {
        public int EmployeeStatusId { get; set; }
        public string Status { get; set; }
        public int? ActiveInd { get; set; }
    }
}
