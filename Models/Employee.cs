using System.ComponentModel.DataAnnotations;

namespace FInalMVC.Models
{
    public class Employee
    {
        [Key]
        public int IdNumber { get; set; }
        [Required]
        public int empyeeType { get; set; }

        [Required]
        public string? firstName { get; set; }
        [Required]
        public string? lastName { get; set; }
        [Required]
        public string? phoneNumber { get; set; }
        [Required]
        public string? emailAddress { get; set; }
        [Required]
        public string? mailingAddress { get; set; }
        [Required]
        public int baseSalary { get; set; }



    }
    /*------------------------------------Step 1: Create an abstract class with a constructor that takes employee details may be first name and last name, and one abstract method CalculateSalary()---------------*/
    /* public abstract class AEmployee
     {

         *//* public void EmpDetails(string firstName, string lastName);*//*
         public abstract int CalculateSalary(int baseSalary, int employeeType);

     } 

*/
}
