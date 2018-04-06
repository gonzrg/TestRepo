using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Authorize]
    public class EmployeesController : Controller
    {
        // GET: Employees
        public ActionResult Index()
        {
            DTOSearch result = new DTOSearch
            {
                DTOEmployeesTable = new ApiEmployeeController().Get()
            };
            return View(result);
        }

        [HttpPost]
        public ActionResult Index(DTOSearch Obj)
        {
            DTOSearch result;

            if (Obj.SearchField == null)
            {
               result = new DTOSearch
                {
                    DTOEmployeesTable = new ApiEmployeeController().Get()
                };
            }
            else
            {

                int id = 0; 
                bool isInteger = Int32.TryParse(Obj.SearchField,out id);
                if (isInteger)
                {
                    result = new DTOSearch
                    {
                        DTOEmployeesTable = new ApiEmployeeController().Get(id),
                        SearchField = Obj.SearchField

                    };
                }
                else {
                    result = new DTOSearch{
                        DTOEmployeesTable = new ApiEmployeeController().Get(),
                    };
                }
                
            }    

            return View(result);
        }       

    }
}
