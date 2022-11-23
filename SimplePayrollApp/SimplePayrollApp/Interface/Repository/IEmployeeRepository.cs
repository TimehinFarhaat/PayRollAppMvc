using SimplePayrollApp.Models;

namespace SimplePayrollApp.Interface.Repository
{
    public interface IEmployeeRepository
    {
        public IList<Employee> GetAllEmployees();
    }
}
