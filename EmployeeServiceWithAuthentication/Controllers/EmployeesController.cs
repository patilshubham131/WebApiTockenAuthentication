using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeeServiceWithAuthentication.Controllers
{
    public class EmployeesController : ApiController
    {
        [Authorize]
        public IEnumerable<employee> Get()
        {
            using(EmployeeDBEntities entity = new EmployeeDBEntities())
            {
                return entity.employees.ToList();
            }
        }
    }
}
