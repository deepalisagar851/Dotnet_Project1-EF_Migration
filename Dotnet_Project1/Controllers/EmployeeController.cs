using Dotnet_Project1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;


namespace Dotnet_Project1.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee

        ApplicationDBContext application = new ApplicationDBContext();



        public ActionResult Index()
        {
            List<Employee> employees = application.Employees.ToList();

            return View(employees);
        }
    }
}