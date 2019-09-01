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
            _employeeList = new List<Employee>(){
                new Employee() {Id = 1, Name = "Mary", Department = Dept.Sales, Email = "mary@dumbcompany.com"},
                new Employee() {Id = 2, Name = "John", Department = Dept.Marketing, Email = "john@dumbcompany.com"},
                new Employee() {Id = 3, Name = "Sam", Department = Dept.IT, Email = "sam@dumbcompany.com"},
            };
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }
    }
}
