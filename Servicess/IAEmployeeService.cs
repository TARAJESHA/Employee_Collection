using FInalMVC.Servicess.Abstract_Class;
using FInalMVC.Servicess.Interface;

namespace FInalMVC.Servicess
{
    public class IAEmployeeService 
    {
       

        public  int CalculateSalary(int baseSalary, int employeeType)
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
    }
}