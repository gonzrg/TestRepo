using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ApiEmployeeController : ApiController
    {
        // GET: api/ApiEmployee
        public List<DTOEmployee> Get()
        {
            return BusinessLogic.GetDTOEmployees();
        }

        // GET: api/ApiEmployee/5
        public List<DTOEmployee> Get(int id)
        {
            return BusinessLogic.GetDTOEmployee(id);
        }
        
    }
}
