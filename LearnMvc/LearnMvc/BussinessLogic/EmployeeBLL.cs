using LearnMvc.DataAccess;
using LearnMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LearnMvc.LearnMvcBLL
{
    public class EmployeeBLL
    {
        public List<Cliente> GetEmployees()
        {
            SalesERPDAL salesDal = new SalesERPDAL();
            return salesDal.Employees.ToList();
            //Otra opcion:
            //List<Employee> employees = new SalesERPDAL().Employees.ToList();
            //return employees;
        }

        public Cliente SaveEmployee(Cliente e)
        {
            using (var context = new SalesERPDAL())
            {
                context.Employees.Add(e);
                context.SaveChanges();
                return e;
            }
        }
    }
}