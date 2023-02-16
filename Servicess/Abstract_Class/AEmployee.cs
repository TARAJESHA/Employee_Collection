using FInalMVC.Servicess.Interface;
namespace FInalMVC.Servicess.Abstract_Class
{
    public abstract class AEmployee  
    { 
        
        public void EmpDetails(string firstName, string lastName)
        {
            Console.WriteLine(firstName + " " + lastName);
        } 
        public abstract int CalculateSalary(int baseSalary, int employeeType);

    }

}
