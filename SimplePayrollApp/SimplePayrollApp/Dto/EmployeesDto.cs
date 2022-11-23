namespace SimplePayrollApp.Dto
{
    public class EmployeesDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string  Pension { get; set; }
        public string TaxableIncome { get; set; }
        public string YearlyTax { get; set; }
        public string MonthlyTax { get; set; }
        public string Salary { get; set; }
        public bool IsDeleted { get; set; }
    }

    public class ListEmployeeDtos
    {
        public IList<EmployeesDto> Employees { get; set; }
    }



    public class BaseResponse
    {
        public bool Status { get; set; }
        public string Message { get; set; }
    }
}
