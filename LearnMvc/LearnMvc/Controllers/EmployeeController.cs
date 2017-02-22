using LearnMvc.LearnMvcBLL;
using LearnMvc.Models;
using LearnMvc.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearnMvc.Controllers
{

    public class EmployeeController : Controller
    {

        public ActionResult Index()
        {
            EmployeeListViewModel employeeListViewModel = new EmployeeListViewModel();

            EmployeeBLL empBal = new EmployeeBLL();
            List<Cliente> employees = empBal.GetEmployees();

            List<EmployeeViewModel> empViewModels = new List<EmployeeViewModel>();

            foreach (Cliente emp in employees)
            {
                EmployeeViewModel empViewModel = new EmployeeViewModel();
                empViewModel.Nombre = emp.Nombre;
                empViewModel.Email = emp.Email;
                empViewModel.Password = emp.Password;
                empViewModels.Add(empViewModel);
            }
            employeeListViewModel.Employees = empViewModels;
            //employeeListViewModel.UserName = "Admin";
            return View("Index", employeeListViewModel);
        }

        public ActionResult AddNew()
        {
            return View("CreateEmployee");
        }

        public ActionResult SaveEmployee(Cliente e, String BtnSubmit)
        {
            switch (BtnSubmit)
            {
                case "Save Employee":
                    if (ModelState.IsValid)
                    {
                        EmployeeBLL empBal = new EmployeeBLL();
                        empBal.SaveEmployee(e);
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        return View("CreateEmployee");
                    }
                case "Cancel":
                    return RedirectToAction("Index");
            }
            return new EmptyResult();
        }

        //Otra opcion: (binding más automático)
        //public string SaveEmployee(Employee e)
        //{
        //  return e.FirstName + "|" + e.LastName + "|" e.Salary;
        //}
    }
}