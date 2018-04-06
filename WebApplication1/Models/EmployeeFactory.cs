using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class EmployeeFactory
    {

        public DTOEmployee CreateEmployee(Employee Employee)
        {

            DTOEmployee NewEmployee = new DTOEmployee
            {
                Id = Employee.Id,
                Name = Employee.Name,
                ContractTypeName = Employee.ContractTypeName,
                RoleId = Employee.RoleId,
                RoleName = Employee.RoleName,
                RoleDescription = Employee.RoleDescription,
                HourlySalary = Employee.HourlySalary,
                MonthlySalary = Employee.MonthlySalary                

            };


            if (NewEmployee.ContractTypeName == "HourlySalaryEmployee") {
                NewEmployee.calculatedAnnualSalary = 120 * NewEmployee.HourlySalary * 12;
            }

            else {
                NewEmployee.calculatedAnnualSalary = NewEmployee.MonthlySalary * 12;
            }



            return NewEmployee;
            
        }
        



    }
}