using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class DTOSearch
    {
        public List<DTOEmployee> DTOEmployeesTable { get; set; }          
        [DisplayName("Search")]
        public string SearchField { get; set; }

    }
}