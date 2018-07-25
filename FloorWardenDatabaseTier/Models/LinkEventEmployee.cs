using System;
using System.Collections.Generic;

namespace FloorWardenDatabaseTier.Models
{
    public partial class LinkEventEmployee
    {
        public int LnkEventEmpId { get; set; }
        public int EventId { get; set; }
        public int EmployeeId { get; set; }
        public int EmployeeStatusId { get; set; }
        public DateTime DateCreated { get; set; }
        public int ActiveInd { get; set; }
    }
}
