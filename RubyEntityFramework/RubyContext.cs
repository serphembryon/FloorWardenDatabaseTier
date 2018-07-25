using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyEntityFramework
{
    public class RubyContext : DbContext
    {
        public DbSet<EmergencyEventType> EmergencyEventTypes { get; set; }
    }
}
