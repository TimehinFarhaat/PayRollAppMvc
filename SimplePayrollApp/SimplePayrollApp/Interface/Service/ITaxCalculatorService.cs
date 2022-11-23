namespace SimplePayrollApp.Interface.Service
{
    public interface ITaxCalculatorService
    {
        public decimal CalculatePension(decimal GI);
        public decimal CalculateTaxableIncome(decimal salary);
        public decimal GetMonthlyTax(decimal salary);
        public decimal GetYearlyTax(decimal salary);

    }
}
