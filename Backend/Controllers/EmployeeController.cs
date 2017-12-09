using Domain.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Backend.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ViewAll()
        {
            return View(GetEmployee());
        }
        IEnumerable<Employee> GetEmployee()
        {
            using (var db = new BDModel())
            {
                return db.Employees.ToList<Employee>();
            }
        }

    }

}