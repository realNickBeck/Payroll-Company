using Microsoft.EntityFrameworkCore;

namespace PayrollCompany.Models
{
    public class PayrollContext : DbContext
    {
        public PayrollContext(DbContextOptions<PayrollContext> options) : base(options)
        { }

        public DbSet<Employee> Employee { get; set; }

        public DbSet<Department> Department { get; set; }

        public DbSet<Project> Project { get; set; }

        public DbSet<EmployeeProject> EmployeeProject { get; set; }
        public DbSet<Payroll> Payroll { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) // Configure entity classes
                                                                           // Configure the database tables created from the entity classes
        {
            // Apply the configuration classes and seed initial data
            modelBuilder.ApplyConfiguration(new EmployeeConfig());
            modelBuilder.ApplyConfiguration(new DepartmentConfig());
            modelBuilder.ApplyConfiguration(new ProjectConfig());
            modelBuilder.ApplyConfiguration(new EmployeeProjectConfig());
            modelBuilder.ApplyConfiguration(new PayrollConfig());
        }
    }
}


