using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PayrollCompany.Models
{
    public class Project
    {
        public int ProjectID { get; set; }

        [Required(ErrorMessage = "Please enter the name of the project")]
        public string ProjectName { get; set; }

        [Required(ErrorMessage = "Please enter the time span of the project")]
        public string ProjectTimespan { get; set; }


        public List<EmployeeProject> EmployeeProjects { get; set; }
    }
}
