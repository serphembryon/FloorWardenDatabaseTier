using System;
using System.Collections.Generic;

namespace FloorWardenDatabaseTier.Models
{
    public partial class RefEventType
    {
        public int EventTypeId { get; set; }
        public string EmergencyType { get; set; }
        public string Description { get; set; }
        public int ActiveInd { get; set; }
    }
}
