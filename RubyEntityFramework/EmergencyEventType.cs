using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyEntityFramework
{
    public class EmergencyEventType
    {
        public List<string> GetAll()
        {
            List<string> results = new List<string>();
            using (var context = new RubyContext ()) 
            {     
                foreach (EmergencyEventType item in context.EmergencyEventTypes)
                {
                    results.Add(item.ToString());
                }
            }
            return results;
        }
    }
}
