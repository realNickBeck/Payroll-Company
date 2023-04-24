using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace PayrollCompany.Models
{
    public class EmployeeProjectConfig : IEntityTypeConfiguration<EmployeeProject>
    {
        public void Configure(EntityTypeBuilder<EmployeeProject> entity)
        {
            // Assignment: set primary key
            entity.HasKey(ma => new { ma.EmployeeProjectID });

            // Assignment: set foreign keys
            entity.HasOne(ma => ma.Employee)
                .WithMany(m => m.EmployeeProjects)
                .HasForeignKey(ma => ma.EmployeeID);
            entity.HasOne(ma => ma.Project)
                .WithMany(a => a.EmployeeProjects)
                .HasForeignKey(ma => ma.ProjectID);

            entity.HasData(
                new EmployeeProject { EmployeeProjectID = 1, EmployeeID = 1, ProjectID = 1 },
                new EmployeeProject { EmployeeProjectID = 2, EmployeeID = 3, ProjectID = 2 },
                new EmployeeProject { EmployeeProjectID = 3, EmployeeID = 4, ProjectID = 6 },
                new EmployeeProject { EmployeeProjectID = 4, EmployeeID = 5, ProjectID = 4 },
                new EmployeeProject { EmployeeProjectID = 5, EmployeeID = 6, ProjectID = 3 },
                new EmployeeProject { EmployeeProjectID = 6, EmployeeID = 7, ProjectID = 1 },
                new EmployeeProject { EmployeeProjectID = 7, EmployeeID = 8, ProjectID = 2 },
                new EmployeeProject { EmployeeProjectID = 8, EmployeeID = 9, ProjectID = 6 },
                new EmployeeProject { EmployeeProjectID = 9, EmployeeID = 10, ProjectID = 5 },
                new EmployeeProject { EmployeeProjectID = 10, EmployeeID = 11, ProjectID = 3 },
                new EmployeeProject { EmployeeProjectID = 11, EmployeeID = 12, ProjectID = 7 },
                new EmployeeProject { EmployeeProjectID = 12, EmployeeID = 13, ProjectID = 7 },
                new EmployeeProject { EmployeeProjectID = 13, EmployeeID = 14, ProjectID = 6 },
                new EmployeeProject { EmployeeProjectID = 14, EmployeeID = 15, ProjectID = 8 },
                new EmployeeProject { EmployeeProjectID = 15, EmployeeID = 16, ProjectID = 8 }
            );
        }
    }
}
