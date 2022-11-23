﻿namespace SimplePayrollApp.Models
{
    public class Employee
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string  Department { get; set; }
        public int  Level { get; set; }
        public decimal  Salary { get; set; }
        public bool  IsDeleted { get; set; }
    }
}
