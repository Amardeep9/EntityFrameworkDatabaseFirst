
namespace EntityFrameworkDatabaseFirst
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Address { get; set; }
        public Nullable<decimal> Salary { get; set; }
        public string Email { get; set; }
    }
}
