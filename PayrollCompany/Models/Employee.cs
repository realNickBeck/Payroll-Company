using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace PayrollCompany.Models
{
    public class Employee
    {

        public int EmployeeID { get; set; }

        [Required(ErrorMessage = "Please enter the first name of the employee")]

        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter the last name of the employee")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter the title of the employee")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter the username of the employee")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter the password of the employee")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please enter the address of the employee")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter the city of the employee")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter the state of the employee")]
        public string State { get; set; }

        [Required(ErrorMessage = "Please enter the zip code of the employee")]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "Please enter the department of the employee")]
        public int DepartmentID { get; set; } //foreign key property
        public Department Department { get; set; }


        public List<EmployeeProject> EmployeeProjects { get; set; }

        public string Slug
        {
            get
            {
                if (FirstName == null)
                    return "";
                else
                    return FirstName.Replace(' ', '-');
            }
        }
    }
}
