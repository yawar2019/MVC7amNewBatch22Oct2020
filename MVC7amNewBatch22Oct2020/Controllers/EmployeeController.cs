using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC7amNewBatch22Oct2020.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public int GetEmpid () {

            return 1;
        }
        public string GetEmployeeid(int? id)
        {

            return "My EMpId "+id;
        }

        public ViewResult GetView() {

            return View("GetView1");
        }

        public ViewResult GetView123()
        {

            return View("~/Views/Department/GetDepartment.cshtml");
        }
    }
}