using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class BusinessLogic
    {
        internal static List<DTOEmployee> GetDTOEmployees()
        {
            List<DTOEmployee> DTOList = new List<DTOEmployee>();
            DALEmployee dal = new DALEmployee();
            List<Employee> Employee = dal.getEmployees();
            EmployeeFactory EF = new EmployeeFactory();
            foreach(Employee item  in Employee)
            {
                 DTOList.Add(EF.CreateEmployee(item));

            }
            return DTOList;
        }

        internal static List<DTOEmployee> GetDTOEmployee(int id)
        {
            List<DTOEmployee> DTOList = new List<DTOEmployee>();
            DALEmployee dal = new DALEmployee();
            List<Employee> Employee = dal.getEmployees(id);
            EmployeeFactory EF = new EmployeeFactory();
           
                foreach (Employee item in Employee)
                {
                    DTOList.Add(EF.CreateEmployee(item));

                }
                      
            return DTOList;
        }
    }
}