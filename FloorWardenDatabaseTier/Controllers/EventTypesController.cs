using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FloorWardenDatabaseTier.Models;

namespace FloorWardenDatabaseTier.Controllers
{
    [Produces("application/json")]
    [Route("api/EventTypes")]
    public class EventTypesController : Controller
    {
        // GET: api/EventTypes
        [HttpGet]
        public JsonResult Get()
        {
            List<RefEventType> result = new List<RefEventType>();
            using (var context = new Ruby_EmergencyContext())
            {

                foreach (RefEventType item in context.RefEventType)
                {
                    result.Add(item);
                }
            }
            return Json(result);
        }
        
        // POST: api/EventTypes
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/EventTypes/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
