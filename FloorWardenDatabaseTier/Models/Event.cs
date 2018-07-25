using System;
using System.Collections.Generic;

namespace FloorWardenDatabaseTier.Models
{
    public partial class Event
    {
        public int EventId { get; set; }
        public int EventTypeId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateEnded { get; set; }
        public int ActiveInd { get; set; }
    }
}
