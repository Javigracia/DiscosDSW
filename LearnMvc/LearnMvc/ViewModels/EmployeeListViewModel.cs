using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LearnMvc.ViewModels
{
    public class EmployeeListViewModel
    {
        public List<EmployeeViewModel> Employees { get; set; }
        public string Nombre { get; set; }
    }
}