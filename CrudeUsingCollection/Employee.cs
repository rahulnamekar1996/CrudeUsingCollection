using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudeUsingCollection
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double sallary { get; set; }
    }

    public class EmployeeCrude
    {
        private List<Employee> employees;

        public EmployeeCrude()
        {
            employees = new List<Employee>();

        }

        public void AddEmployee(Employee employ)
        {
            employees.Add(employ);
        }
        public List<Employee> GetEmployees()
        {
            return employees;
        }


        public void UpdateEmployee(Employee employ)
        {
            foreach (Employee e in employees)
            {
                if (e.Id == employ.Id)
                {
                    e.Name = employ.Name;
                    e.sallary = employ.sallary;
                    break;
                }
            }
        }
        public void DeleteEmolyee(int id)
        {
            foreach (Employee e in employees)
            {
                if (e.Id == id)
                {
                    employees.Remove(e);
                    break;
                }
            }

        }
    }
    
}
