using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee(){Id = 1, Name = "Jyotirmoy", Department = "IT" , Email = "jyotirmoy.personal@gmail.com" },
                new Employee(){Id = 2, Name = "Coder2", Department = "CD2" , Email = "coder2@coder2.com" },
                new Employee(){Id = 3, Name = "Coder3", Department = "CD3" , Email = "cd3@coder3.com" }

            };
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }
    }
}
