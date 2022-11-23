using SimplePayrollApp.Context;
using SimplePayrollApp.Interface.Repository;
using SimplePayrollApp.Models;

namespace SimplePayrollApp.Implementation.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        protected ApplicationContext _context;
        public EmployeeRepository(ApplicationContext Context)
        {
            _context = Context;
        }

        public IList<Employee> GetAllEmployees()
        {
            var employees = _context.Employees.ToList();
            return employees;
        }
    }
}
