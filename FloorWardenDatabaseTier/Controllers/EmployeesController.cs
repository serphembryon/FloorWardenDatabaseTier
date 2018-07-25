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
    [Route("api/Employees")]
    public class EmployeesController : Controller
    {
        // GET: api/Employees
        [HttpGet]
        public JsonResult Get()
        {
            List<JSONEmployee> result = new List<JSONEmployee>();
            using (var context = new Ruby_EmergencyContext())
            {
                foreach (Employee person in context.Employee)
                {
                    JSONEmployee newEmployee = new JSONEmployee();
                    newEmployee.fname = person.Fname;
                    newEmployee.lname = person.Lname;
                    newEmployee.email = person.Email;
                    newEmployee.building = person.Building;
                    newEmployee.floor = person.Floor;
                    newEmployee.room = person.Room;
                    newEmployee.phone = person.Phone;
                    result.Add(newEmployee);
                }
            }
            return Json(result);
        }

        // GET: api/Employees/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Employees
        [HttpPost]
        public OkResult Add(JSONEmployee postedEmployee)
        {
            using (var context = new Ruby_EmergencyContext())
            {
                Employee newEmployee = new Employee();
                newEmployee.Fname = postedEmployee.fname;
                newEmployee.Lname = postedEmployee.lname;
                newEmployee.Email = postedEmployee.email;
                newEmployee.Building = postedEmployee.building;
                newEmployee.Floor = postedEmployee.floor;
                newEmployee.Room = postedEmployee.room;
                newEmployee.Phone = postedEmployee.phone;
                //status
                //warden?

                context.Add(newEmployee);
                context.SaveChangesAsync();
            }
            return Ok();
        }

        // PUT: api/Employees/5
        [HttpPost]
        public void Update(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpPost]
        public void Delete(int id)
        {
        }
    }
}
