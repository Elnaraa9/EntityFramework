using _26_04_2022.Models.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _26_04_2022.Models
{
    public class EmployeeController
    {
        private readonly AppDbContext _context;
        public EmployeeController()
        {
            _context = new AppDbContext();
        }

        public List<Employee> GetAllEmployees()
        {
            return _context.Employees.ToList();
        }

        public void AddEmployee(string fullname)
        {
            try
            {
                Employee emp = new Employee { Fullname = fullname };
                _context.Employees.Add(emp);
                _context.SaveChanges();
                Console.WriteLine("Name created");
            }
            catch (Exception)
            {

                Console.WriteLine("Some problem exit");
            }
        }
        public void GetEmployeeById(int id)
        {
            Employee empdb = _context.Employees.Find(id);
            if (empdb!=null)
            {
                Console.WriteLine(empdb.Fullname);
                return;
            }
            Console.WriteLine("Bele bir isci yoxdur");
        }
        public void DeleteEmployee(int id)
        {
            Employee empdb = _context.Employees.Find(id);
            if (empdb==null)
            {
                Console.WriteLine("Not Found");
                return;
            }
            _context.Employees.Remove(empdb);
            _context.SaveChanges();
            Console.WriteLine("Is Removed");
        }
        public void FilterByName(string search)
        {
            List<Employee> employee = _context.Employees.ToList();
            foreach (var item in employee)
            {
                if (item.Fullname.ToLower().Contains(search)|| item.Fullname.ToUpper().Contains(search))
                {
                    Console.WriteLine(item.Fullname);
                    return;
                }
            }
              Console.WriteLine("Uygun data yoxdur");
        }
    }
}
