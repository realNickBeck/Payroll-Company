using System.ComponentModel.DataAnnotations;

namespace PayrollCompany.Models
{
    public class Payroll
    {
        public int PayrollID { get; set; }

        [Required(ErrorMessage = "Please select an employee")]
        public int EmployeeID { get; set; } //foreign key
        public Employee Employee { get; set; }

        [Required(ErrorMessage = "Please enter the severance of the employee")]
        public double serverance { get; set; }

        [Required(ErrorMessage = "Please enter the net pay of the employee")]
        public double NetPay { get; set; }

        [Required(ErrorMessage = "Please enter the gross pay of the employee")]
        public double GrossPay { get; set; }

        [Required(ErrorMessage = "Please enter the tax percent withdrawal of the employee")]
        public double TaxPercentWidthdrawal { get; set; }

    }
}
