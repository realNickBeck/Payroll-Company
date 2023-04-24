using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace PayrollCompany.Models
{
    public class ProjectConfig : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> entity)
        {
            entity.HasData(
                new Project { ProjectID = 1, ProjectName = "Project Payroll", ProjectTimespan = "1 week" },
                new Project { ProjectID = 2, ProjectName = "Project Z", ProjectTimespan = "1 week" },
                new Project { ProjectID = 3, ProjectName = "Project Point", ProjectTimespan = "2 weeks" },
                new Project { ProjectID = 4, ProjectName = "Project X", ProjectTimespan = "4 weeks" },
                new Project { ProjectID = 5, ProjectName = "Project Y", ProjectTimespan = "8 weeks" },
                new Project { ProjectID = 6, ProjectName = "Project United", ProjectTimespan = "2 weeks" },
                new Project { ProjectID = 7, ProjectName = "Project Breeze", ProjectTimespan = "1 week" },
                new Project { ProjectID = 8, ProjectName = "Project AB", ProjectTimespan = "3 weeks" }
            );
        }
    }
}
