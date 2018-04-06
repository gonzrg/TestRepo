using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace WebApplication1.Models
{
    public class DALEmployee
    {
        public string AllEmployeesUrl { get; set; }
       
        

        public DALEmployee()
        {
            AllEmployeesUrl = "http://masglobaltestapi.azurewebsites.net/api/Employees";
            
        }

        public List<Employee> getEmployees()
        {
            List<Employee> TransportEmployees;

            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString(AllEmployeesUrl);
                TransportEmployees = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Employee>>(json);
            }

            return TransportEmployees;

        }

        public List<Employee> getEmployees(int id)
        {
            List<Employee> TransportEmployees;

            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString(AllEmployeesUrl);
                TransportEmployees = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Employee>>(json);
            }
            List<Employee> Result ;            
            
            Employee EResult = (TransportEmployees.Find(x => x.Id == id));
            if(EResult is null)
            {
                Result = new List<Employee>();
            }
            else
            {
                Result = new List<Employee>();
                Result.Add(EResult);
            }
            return Result;

        }
    }
}