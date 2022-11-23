using Microsoft.AspNetCore.Mvc;
using SimplePayrollApp.Interface.Service;

namespace SimplePayrollApp.Controllers
{
    public class EmployeeController:Controller
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public IActionResult Index()
        {
           var result=_employeeService.GetEmployees();
            return View(result.Employees);
        }
    }
}
