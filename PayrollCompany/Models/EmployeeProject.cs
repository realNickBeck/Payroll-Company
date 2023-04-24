using System.ComponentModel.DataAnnotations;

namespace PayrollCompany.Models
{
    public class EmployeeProject
    {
        public int EmployeeProjectID { get; set; }

        [Required(ErrorMessage = "Please enter the project ID")]
        public int EmployeeID { get; set; }

        [Required(ErrorMessage = "Please enter the employee ID")]
        public int ProjectID { get; set; }

        public Employee Employee { get; set; }
        public Project Project { get; set; }
    }
}
