using _26_04_2022.Models;
using System;

namespace _26_04_2022
{
    public class Program
    {
        static void Main(string[] args)
        {
            EmployeeController employee = new EmployeeController();

            //Console.WriteLine("Enter Employee Name:");
            //string fullname = Console.ReadLine();
            //Console.WriteLine("Enter Employee ID");
            //int id=int.Parse(Console.ReadLine());
            //employee.AddEmployee(fullname);

            employee.GetEmployeeById(4);

            //employee.FilterByName("F");

            //foreach (var item in employee.GetAllEmployees())
            //{
            //    Console.WriteLine(item.Fullname);
            //}
        }
    } 
}
