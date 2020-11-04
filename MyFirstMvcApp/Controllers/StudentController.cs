using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyFirstMvcApp.Models;
using System.Collections;

namespace MyFirstMvcApp.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public string Index(int? Eid)
        {
          
            return "Employee Id "+ Eid;
        }
        [NonAction]
        public void Add()
        {

        }

        public string GetFullName(string Name,string Designation)
        {

            return "Employee Name " + Name+" And Designation is "+Designation;
        }

        public string GetFullName2()
        {

            return "Employee Name " + Request.QueryString["Name"] + " And Designation is " + Request.QueryString["Designation"];
        }

        public ActionResult SendData() {

         

            List<EmployeeModel> listobj = new List<EmployeeModel>();
          
           
            EmployeeModel obj = new Models.EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "Hari";
            obj.EmpSalary = 29000;

            EmployeeModel obj1 = new Models.EmployeeModel();
            obj1.EmpId = 2;
            obj1.EmpName = "Chandra";
            obj1.EmpSalary = 39000;

            EmployeeModel obj2 = new Models.EmployeeModel();
            obj2.EmpId = 3;
            obj2.EmpName = "Poorni";
            obj2.EmpSalary = 49000;

            listobj.Add(obj);
            listobj.Add(obj1);
            listobj.Add(obj2);

            ViewBag.info = listobj;
          

            return View();
        }


        public ActionResult GetEmployee()
        {
            EmployeeModel obj = new Models.EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "Hari";
            obj.EmpSalary = 29000;


           
            return View(obj);
        }


        public ActionResult GetAllEmployees()
        {
            List<EmployeeModel> listobj = new List<EmployeeModel>();


            EmployeeModel obj = new Models.EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "Hari";
            obj.EmpSalary = 29000;

            EmployeeModel obj1 = new Models.EmployeeModel();
            obj1.EmpId = 2;
            obj1.EmpName = "Chandra";
            obj1.EmpSalary = 39000;

            EmployeeModel obj2 = new Models.EmployeeModel();
            obj2.EmpId = 3;
            obj2.EmpName = "Poorni";
            obj2.EmpSalary = 49000;

            listobj.Add(obj);
            listobj.Add(obj1);
            listobj.Add(obj2);



            return View(listobj);
        }
    }
}