using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PayrollCompany.Models
{
    public class DepartmentConfig : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> entity)
        {
            entity.HasData(
                new Department { DepartmentID = 1, DepartmentName = "Payroll" },
                new Department { DepartmentID = 2, DepartmentName = "Executives" },
                new Department { DepartmentID = 3, DepartmentName = "Human Resources" },
                new Department { DepartmentID = 4, DepartmentName = "Operations" },
                new Department { DepartmentID = 5, DepartmentName = "Finance" },
                new Department { DepartmentID = 6, DepartmentName = "Sales" }
            );
        }
    }
}
