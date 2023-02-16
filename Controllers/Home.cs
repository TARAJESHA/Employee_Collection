using FInalMVC.Models;
using FInalMVC.Servicess;
using FInalMVC.Servicess.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace FInalMVC.Controllers
{
    public class Home : Controller
    {
         private readonly Temporary _employeeService;
         private readonly IPermanent _employeeService1;
         public Home(Temporary employeeService, IPermanent employeeService1)
         {
             this._employeeService = employeeService;
            this._employeeService1 = employeeService1;
         }
        public ActionResult GetEmployee(int IdNumber)
        {
            int ID = IdNumber;
            Employee employee = _employeeService.GetEmployee(ID);

            return View(employee);

        }
        public ActionResult GetSalary(int IdNumber)
        {
            int ID = IdNumber;
            int salary = _employeeService.GetSalary(ID);
            ViewBag.Idnumber = ID;
            ViewBag.salary = salary; 
            return View(); 
        }
        public ActionResult AddEmployee(Employee employee)
        {
            if (employee.empyeeType == 1)
            {
                Employee employee1 = _employeeService.AddEmployee(employee);
                return View(employee1);
            }
            else
            {
                Employee employee1 = _employeeService1.AddEmployee(employee);
                return View(employee1);

            }
        }
        public ActionResult GetPhoneNumber(int IdNumber)
        {
            int ID = IdNumber;
            Employee employee = _employeeService.GetPhoneNumber(ID);
            return View(employee);
        }
    }
}