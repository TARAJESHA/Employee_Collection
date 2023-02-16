using FInalMVC.Models;
using FInalMVC.Servicess.Abstract_Class;
using FInalMVC.Servicess.Interface;

namespace FInalMVC.Servicess
{  
    public class EmployeeService : AEmployee, IPermanent, Temporary
    { 
         
        public override int CalculateSalary(int baseSalary, int employeeType)
        {
            Console.WriteLine("............en inside ................");
            if (employeeType == 1)
            {
                Console.WriteLine("............0.3................" + baseSalary + " " + employeeType);
                return (int)(baseSalary + baseSalary * 0.3);
            }
            else if (employeeType == 0)
            {
                Console.WriteLine("............0.1................" + baseSalary + " " + employeeType);
                return (int)(baseSalary + baseSalary * 0.1);
            }
            else
            {
                return -1;
            }
        }



        static List<Employee> Employees = new List<Employee>();

         
        public Employee GetEmployee(int IdNumber)
        {
            Employee employee1 = Employees.Find(employee => employee.IdNumber == IdNumber);     
            return employee1;
        }

        public Employee AddEmployee(Employee employee)
        {
            Console.WriteLine(".......adding new Employee..........");
            Employees.Add(employee);
            Console.WriteLine(".......added..........");
            Employee employee1 = Employees.Find(emp => emp.IdNumber == employee.IdNumber);
            Console.WriteLine(".......getting..........");
            Console.WriteLine(Employees.Capacity);
            Console.WriteLine(employee1);
            return employee1;
        }

        public int GetSalary(int iD)
        {
            Employee employee1 = Employees.Find(employee => employee.IdNumber == iD);
             int baseSalary = CalculateSalary(employee1.baseSalary, employee1.empyeeType);    
            return baseSalary;

        }
 
        public Employee GetPhoneNumber(int iD)
        {
            Employee employee = Employees.FirstOrDefault(e => e.IdNumber == iD);
            return employee;
        }

        
    }

}



