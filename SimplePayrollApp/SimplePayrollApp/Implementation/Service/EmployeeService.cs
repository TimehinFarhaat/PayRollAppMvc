using SimplePayrollApp.Dto;
using SimplePayrollApp.Interface.Repository;
using SimplePayrollApp.Interface.Service;

namespace SimplePayrollApp.Implementation.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly ITaxCalculatorService _taxCalculatorService;

        public EmployeeService(IEmployeeRepository employeeRepository, ITaxCalculatorService taxCalculatorService)
        {
            _employeeRepository = employeeRepository;
            _taxCalculatorService = taxCalculatorService;
        }

        public ListEmployeeDtos GetEmployees()
        {
            var employees=_employeeRepository.GetAllEmployees();

            return new ListEmployeeDtos
            {
                Employees = employees.Select(e => new EmployeesDto
                {
                    FirstName = e.FirstName,
                    LastName = e.LastName,
                    IsDeleted = e.IsDeleted,
                    MonthlyTax=  string.Format("{0:C}", _taxCalculatorService.GetMonthlyTax(e.Salary)),
                    Salary=  string.Format("{0:C}" ,e.Salary),
                    Pension=  string.Format("{0:C}" ,_taxCalculatorService.CalculatePension(e.Salary*12)),
                    TaxableIncome=  string.Format("{0:C}", _taxCalculatorService.CalculateTaxableIncome(e.Salary)),
                    YearlyTax= string.Format("{0:C}" ,_taxCalculatorService.CalculateTaxableIncome(_taxCalculatorService.CalculateTaxableIncome(e.Salary)))
                }).ToList()

            };
        }
    }
}
