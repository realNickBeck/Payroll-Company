using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace PayrollCompany.Models
{
    public class EmployeeConfig : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> entity)
        {
            entity.HasData(
                new Employee { EmployeeID = 1, DepartmentID = 1, FirstName = "John", LastName = "Doe", Title = "Lead Payroll Associate", Username = "jdoe38", Password = "1111", Address = "29 Olney St", City = "Philadelphia", State = "PA", ZipCode = "19191" },
                new Employee { EmployeeID = 2, DepartmentID = 2, FirstName = "Mike", LastName = "Smith", Title = "Lead Manager", Username = "msmisth22", Password = "1234", Address = "300 Hatboro Rd", City = "Horsham", State = "PA", ZipCode = "19091" },
                new Employee { EmployeeID = 3, DepartmentID = 5, FirstName = "Robert", LastName = "Jones", Title = "Finance Associate", Username = "rjones12", Password = "5678", Address = "29 Russell Rd", City = "Willow Grove", State = "PA", ZipCode = "19090" },
                new Employee { EmployeeID = 4, DepartmentID = 3, FirstName = "Colin", LastName = "Johson", Title = "Human Resources Associate", Username = "cjohnson33", Password = "7890", Address = "1836 Olney Rd", City = "Philadelphia", State = "PA", ZipCode = "19199" },
                new Employee { EmployeeID = 5, DepartmentID = 4, FirstName = "Mary", LastName = "Williams", Title = "Lead Operations Associate", Username = "mwilliams44", Password = "8080", Address = "900 Spruce St", City = "Philadelphia", State = "PA", ZipCode = "19186" },
                new Employee { EmployeeID = 6, DepartmentID = 6, FirstName = "Linda", LastName = "Davis", Title = "Lead Sales Associate", Username = "ldavis45", Password = "5789", Address = "100 Cascade Dr", City = "Allentown", State = "PA", ZipCode = "18109" },
                new Employee { EmployeeID = 7, DepartmentID = 1, FirstName = "Maria", LastName = "Wilson", Title = "Payroll Associate", Username = "mwilson78", Password = "1243", Address = "2500 Knights Rd", City = "Bensalem", State = "PA", ZipCode = "19020" },
                new Employee { EmployeeID = 8, DepartmentID = 5, FirstName = "Taylor", LastName = "Jackson", Title = "Lead Finance Associate", Username = "tjackson11", Password = "1111", Address = "5 Hamilton Dr", City = "Perry Hall", State = "MD", ZipCode = "21128" },
                new Employee { EmployeeID = 9, DepartmentID = 3, FirstName = "Jackson", LastName = "Martin", Title = "Lead Human Resources Associate", Username = "jmartin23", Password = "2222", Address = "3949 Rainbow Dr", City = "Canton", State = "OH", ZipCode = "44702" },
                new Employee { EmployeeID = 10, DepartmentID = 4, FirstName = "Madison", LastName = "Lane", Title = "Operations Associate", Username = "mlane67", Password = "3333", Address = "4819 Princeton Ave", City = "Philadelphia", State = "PA", ZipCode = "19135" },
                new Employee { EmployeeID = 11, DepartmentID = 6, FirstName = "Jordan", LastName = "Lee", Title = "Sales Associate", Username = "jlee99", Password = "4444", Address = "401 W Walnut Ln", City = "Philadelphia", State = "PA", ZipCode = "19144" },
                new Employee { EmployeeID = 12, DepartmentID = 1, FirstName = "Joshua", LastName = "Moore", Title = "Payroll Associate", Username = "jmoore11", Password = "4545", Address = "112 Finntown Rd", City = "Nanty Glo", State = "PA", ZipCode = "15943" },
                new Employee { EmployeeID = 13, DepartmentID = 5, FirstName = "Lisa", LastName = "Miles", Title = "Finance Associate", Username = "lmiles34", Password = "5656", Address = "11701 Route 6", City = "Corry", State = "PA", ZipCode = "16407" },
                new Employee { EmployeeID = 14, DepartmentID = 3, FirstName = "Patrick", LastName = "Samuel", Title = "Human Resources Associate", Username = "psamuel90", Password = "1290", Address = "2 Tulip Ln", City = "Pottstown", State = "PA", ZipCode = "17901" },
                new Employee { EmployeeID = 15, DepartmentID = 4, FirstName = "Keira", LastName = "Hill", Title = "Operations Associate", Username = "khill48", Password = "3489", Address = "1929 N Main Ave", City = "Scranton", State = "PA", ZipCode = "18508" },
                new Employee { EmployeeID = 16, DepartmentID = 6, FirstName = "Stephanie", LastName = "Adams", Title = "Sales Associate", Username = "sadams12", Password = "6666", Address = "401 N 17th St", City = "Allentown", State = "PA", ZipCode = "18104" }
            );

        }
    }
}
