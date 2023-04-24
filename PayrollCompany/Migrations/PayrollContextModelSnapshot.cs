﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PayrollCompany.Models;

namespace PayrollCompany.Migrations
{
    [DbContext(typeof(PayrollContext))]
    partial class PayrollContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PayrollCompany.Models.Department", b =>
                {
                    b.Property<int>("DepartmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DepartmentName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmentID");

                    b.ToTable("Department");

                    b.HasData(
                        new
                        {
                            DepartmentID = 1,
                            DepartmentName = "Payroll"
                        },
                        new
                        {
                            DepartmentID = 2,
                            DepartmentName = "Executives"
                        },
                        new
                        {
                            DepartmentID = 3,
                            DepartmentName = "Human Resources"
                        },
                        new
                        {
                            DepartmentID = 4,
                            DepartmentName = "Operations"
                        },
                        new
                        {
                            DepartmentID = 5,
                            DepartmentName = "Finance"
                        },
                        new
                        {
                            DepartmentID = 6,
                            DepartmentName = "Sales"
                        });
                });

            modelBuilder.Entity("PayrollCompany.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DepartmentID")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeID");

                    b.HasIndex("DepartmentID");

                    b.ToTable("Employee");

                    b.HasData(
                        new
                        {
                            EmployeeID = 1,
                            Address = "29 Olney St",
                            City = "Philadelphia",
                            DepartmentID = 1,
                            FirstName = "John",
                            LastName = "Doe",
                            Password = "1111",
                            State = "PA",
                            Title = "Lead Payroll Associate",
                            Username = "jdoe38",
                            ZipCode = "19191"
                        },
                        new
                        {
                            EmployeeID = 2,
                            Address = "300 Hatboro Rd",
                            City = "Horsham",
                            DepartmentID = 2,
                            FirstName = "Mike",
                            LastName = "Smith",
                            Password = "1234",
                            State = "PA",
                            Title = "Lead Manager",
                            Username = "msmisth22",
                            ZipCode = "19091"
                        },
                        new
                        {
                            EmployeeID = 3,
                            Address = "29 Russell Rd",
                            City = "Willow Grove",
                            DepartmentID = 5,
                            FirstName = "Robert",
                            LastName = "Jones",
                            Password = "5678",
                            State = "PA",
                            Title = "Finance Associate",
                            Username = "rjones12",
                            ZipCode = "19090"
                        },
                        new
                        {
                            EmployeeID = 4,
                            Address = "1836 Olney Rd",
                            City = "Philadelphia",
                            DepartmentID = 3,
                            FirstName = "Colin",
                            LastName = "Johson",
                            Password = "7890",
                            State = "PA",
                            Title = "Human Resources Associate",
                            Username = "cjohnson33",
                            ZipCode = "19199"
                        },
                        new
                        {
                            EmployeeID = 5,
                            Address = "900 Spruce St",
                            City = "Philadelphia",
                            DepartmentID = 4,
                            FirstName = "Mary",
                            LastName = "Williams",
                            Password = "8080",
                            State = "PA",
                            Title = "Lead Operations Associate",
                            Username = "mwilliams44",
                            ZipCode = "19186"
                        },
                        new
                        {
                            EmployeeID = 6,
                            Address = "100 Cascade Dr",
                            City = "Allentown",
                            DepartmentID = 6,
                            FirstName = "Linda",
                            LastName = "Davis",
                            Password = "5789",
                            State = "PA",
                            Title = "Lead Sales Associate",
                            Username = "ldavis45",
                            ZipCode = "18109"
                        },
                        new
                        {
                            EmployeeID = 7,
                            Address = "2500 Knights Rd",
                            City = "Bensalem",
                            DepartmentID = 1,
                            FirstName = "Maria",
                            LastName = "Wilson",
                            Password = "1243",
                            State = "PA",
                            Title = "Payroll Associate",
                            Username = "mwilson78",
                            ZipCode = "19020"
                        },
                        new
                        {
                            EmployeeID = 8,
                            Address = "5 Hamilton Dr",
                            City = "Perry Hall",
                            DepartmentID = 5,
                            FirstName = "Taylor",
                            LastName = "Jackson",
                            Password = "1111",
                            State = "MD",
                            Title = "Lead Finance Associate",
                            Username = "tjackson11",
                            ZipCode = "21128"
                        },
                        new
                        {
                            EmployeeID = 9,
                            Address = "3949 Rainbow Dr",
                            City = "Canton",
                            DepartmentID = 3,
                            FirstName = "Jackson",
                            LastName = "Martin",
                            Password = "2222",
                            State = "OH",
                            Title = "Lead Human Resources Associate",
                            Username = "jmartin23",
                            ZipCode = "44702"
                        },
                        new
                        {
                            EmployeeID = 10,
                            Address = "4819 Princeton Ave",
                            City = "Philadelphia",
                            DepartmentID = 4,
                            FirstName = "Madison",
                            LastName = "Lane",
                            Password = "3333",
                            State = "PA",
                            Title = "Operations Associate",
                            Username = "mlane67",
                            ZipCode = "19135"
                        },
                        new
                        {
                            EmployeeID = 11,
                            Address = "401 W Walnut Ln",
                            City = "Philadelphia",
                            DepartmentID = 6,
                            FirstName = "Jordan",
                            LastName = "Lee",
                            Password = "4444",
                            State = "PA",
                            Title = "Sales Associate",
                            Username = "jlee99",
                            ZipCode = "19144"
                        },
                        new
                        {
                            EmployeeID = 12,
                            Address = "112 Finntown Rd",
                            City = "Nanty Glo",
                            DepartmentID = 1,
                            FirstName = "Joshua",
                            LastName = "Moore",
                            Password = "4545",
                            State = "PA",
                            Title = "Payroll Associate",
                            Username = "jmoore11",
                            ZipCode = "15943"
                        },
                        new
                        {
                            EmployeeID = 13,
                            Address = "11701 Route 6",
                            City = "Corry",
                            DepartmentID = 5,
                            FirstName = "Lisa",
                            LastName = "Miles",
                            Password = "5656",
                            State = "PA",
                            Title = "Finance Associate",
                            Username = "lmiles34",
                            ZipCode = "16407"
                        },
                        new
                        {
                            EmployeeID = 14,
                            Address = "2 Tulip Ln",
                            City = "Pottstown",
                            DepartmentID = 3,
                            FirstName = "Patrick",
                            LastName = "Samuel",
                            Password = "1290",
                            State = "PA",
                            Title = "Human Resources Associate",
                            Username = "psamuel90",
                            ZipCode = "17901"
                        },
                        new
                        {
                            EmployeeID = 15,
                            Address = "1929 N Main Ave",
                            City = "Scranton",
                            DepartmentID = 4,
                            FirstName = "Keira",
                            LastName = "Hill",
                            Password = "3489",
                            State = "PA",
                            Title = "Operations Associate",
                            Username = "khill48",
                            ZipCode = "18508"
                        },
                        new
                        {
                            EmployeeID = 16,
                            Address = "401 N 17th St",
                            City = "Allentown",
                            DepartmentID = 6,
                            FirstName = "Stephanie",
                            LastName = "Adams",
                            Password = "6666",
                            State = "PA",
                            Title = "Sales Associate",
                            Username = "sadams12",
                            ZipCode = "18104"
                        });
                });

            modelBuilder.Entity("PayrollCompany.Models.EmployeeProject", b =>
                {
                    b.Property<int>("EmployeeProjectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<int>("ProjectID")
                        .HasColumnType("int");

                    b.HasKey("EmployeeProjectID");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("ProjectID");

                    b.ToTable("EmployeeProject");

                    b.HasData(
                        new
                        {
                            EmployeeProjectID = 1,
                            EmployeeID = 1,
                            ProjectID = 1
                        },
                        new
                        {
                            EmployeeProjectID = 2,
                            EmployeeID = 3,
                            ProjectID = 2
                        },
                        new
                        {
                            EmployeeProjectID = 3,
                            EmployeeID = 4,
                            ProjectID = 6
                        },
                        new
                        {
                            EmployeeProjectID = 4,
                            EmployeeID = 5,
                            ProjectID = 4
                        },
                        new
                        {
                            EmployeeProjectID = 5,
                            EmployeeID = 6,
                            ProjectID = 3
                        },
                        new
                        {
                            EmployeeProjectID = 6,
                            EmployeeID = 7,
                            ProjectID = 1
                        },
                        new
                        {
                            EmployeeProjectID = 7,
                            EmployeeID = 8,
                            ProjectID = 2
                        },
                        new
                        {
                            EmployeeProjectID = 8,
                            EmployeeID = 9,
                            ProjectID = 6
                        },
                        new
                        {
                            EmployeeProjectID = 9,
                            EmployeeID = 10,
                            ProjectID = 5
                        },
                        new
                        {
                            EmployeeProjectID = 10,
                            EmployeeID = 11,
                            ProjectID = 3
                        },
                        new
                        {
                            EmployeeProjectID = 11,
                            EmployeeID = 12,
                            ProjectID = 7
                        },
                        new
                        {
                            EmployeeProjectID = 12,
                            EmployeeID = 13,
                            ProjectID = 7
                        },
                        new
                        {
                            EmployeeProjectID = 13,
                            EmployeeID = 14,
                            ProjectID = 6
                        },
                        new
                        {
                            EmployeeProjectID = 14,
                            EmployeeID = 15,
                            ProjectID = 8
                        },
                        new
                        {
                            EmployeeProjectID = 15,
                            EmployeeID = 16,
                            ProjectID = 8
                        });
                });

            modelBuilder.Entity("PayrollCompany.Models.Payroll", b =>
                {
                    b.Property<int>("PayrollID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<double>("GrossPay")
                        .HasColumnType("float");

                    b.Property<double>("NetPay")
                        .HasColumnType("float");

                    b.Property<double>("TaxPercentWidthdrawal")
                        .HasColumnType("float");

                    b.Property<double>("serverance")
                        .HasColumnType("float");

                    b.HasKey("PayrollID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("Payroll");

                    b.HasData(
                        new
                        {
                            PayrollID = 1,
                            EmployeeID = 1,
                            GrossPay = 47000.0,
                            NetPay = 46301.0,
                            TaxPercentWidthdrawal = 699.0,
                            serverance = 9038.4599999999991
                        },
                        new
                        {
                            PayrollID = 2,
                            EmployeeID = 2,
                            GrossPay = 89000.0,
                            NetPay = 88201.0,
                            TaxPercentWidthdrawal = 799.0,
                            serverance = 34230.769999999997
                        },
                        new
                        {
                            PayrollID = 3,
                            EmployeeID = 3,
                            GrossPay = 45000.0,
                            NetPay = 44500.0,
                            TaxPercentWidthdrawal = 500.0,
                            serverance = 5192.3100000000004
                        },
                        new
                        {
                            PayrollID = 4,
                            EmployeeID = 4,
                            GrossPay = 32000.0,
                            NetPay = 31500.02,
                            TaxPercentWidthdrawal = 499.98000000000002,
                            serverance = 2461.54
                        },
                        new
                        {
                            PayrollID = 5,
                            EmployeeID = 5,
                            GrossPay = 78000.0,
                            NetPay = 77301.0,
                            TaxPercentWidthdrawal = 699.0,
                            serverance = 21000.0
                        },
                        new
                        {
                            PayrollID = 6,
                            EmployeeID = 6,
                            GrossPay = 39000.0,
                            NetPay = 38549.010000000002,
                            TaxPercentWidthdrawal = 450.99000000000001,
                            serverance = 6000.0
                        },
                        new
                        {
                            PayrollID = 7,
                            EmployeeID = 7,
                            GrossPay = 46000.0,
                            NetPay = 45500.0,
                            TaxPercentWidthdrawal = 500.0,
                            serverance = 14153.85
                        },
                        new
                        {
                            PayrollID = 8,
                            EmployeeID = 8,
                            GrossPay = 50000.0,
                            NetPay = 49432.010000000002,
                            TaxPercentWidthdrawal = 567.99000000000001,
                            serverance = 17307.689999999999
                        },
                        new
                        {
                            PayrollID = 9,
                            EmployeeID = 9,
                            GrossPay = 42000.0,
                            NetPay = 41489.019999999997,
                            TaxPercentWidthdrawal = 510.98000000000002,
                            serverance = 8076.9200000000001
                        },
                        new
                        {
                            PayrollID = 10,
                            EmployeeID = 10,
                            GrossPay = 67000.0,
                            NetPay = 66410.009999999995,
                            TaxPercentWidthdrawal = 589.99000000000001,
                            serverance = 12884.620000000001
                        },
                        new
                        {
                            PayrollID = 11,
                            EmployeeID = 11,
                            GrossPay = 34000.0,
                            NetPay = 33559.010000000002,
                            TaxPercentWidthdrawal = 440.99000000000001,
                            serverance = 3923.0799999999999
                        },
                        new
                        {
                            PayrollID = 12,
                            EmployeeID = 12,
                            GrossPay = 43000.0,
                            NetPay = 42500.010000000002,
                            TaxPercentWidthdrawal = 499.99000000000001,
                            serverance = 9923.0799999999999
                        },
                        new
                        {
                            PayrollID = 13,
                            EmployeeID = 13,
                            GrossPay = 45000.0,
                            NetPay = 44498.010000000002,
                            TaxPercentWidthdrawal = 501.99000000000001,
                            serverance = 6923.0799999999999
                        },
                        new
                        {
                            PayrollID = 14,
                            EmployeeID = 14,
                            GrossPay = 30000.0,
                            NetPay = 29540.009999999998,
                            TaxPercentWidthdrawal = 459.99000000000001,
                            serverance = 1153.8499999999999
                        },
                        new
                        {
                            PayrollID = 15,
                            EmployeeID = 15,
                            GrossPay = 71000.0,
                            NetPay = 70400.0,
                            TaxPercentWidthdrawal = 600.0,
                            serverance = 24579.919999999998
                        },
                        new
                        {
                            PayrollID = 16,
                            EmployeeID = 16,
                            GrossPay = 39000.0,
                            NetPay = 38542.010000000002,
                            TaxPercentWidthdrawal = 457.99000000000001,
                            serverance = 4500.0
                        });
                });

            modelBuilder.Entity("PayrollCompany.Models.Project", b =>
                {
                    b.Property<int>("ProjectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectTimespan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProjectID");

                    b.ToTable("Project");

                    b.HasData(
                        new
                        {
                            ProjectID = 1,
                            ProjectName = "Project Payroll",
                            ProjectTimespan = "1 week"
                        },
                        new
                        {
                            ProjectID = 2,
                            ProjectName = "Project Z",
                            ProjectTimespan = "1 week"
                        },
                        new
                        {
                            ProjectID = 3,
                            ProjectName = "Project Point",
                            ProjectTimespan = "2 weeks"
                        },
                        new
                        {
                            ProjectID = 4,
                            ProjectName = "Project X",
                            ProjectTimespan = "4 weeks"
                        },
                        new
                        {
                            ProjectID = 5,
                            ProjectName = "Project Y",
                            ProjectTimespan = "8 weeks"
                        },
                        new
                        {
                            ProjectID = 6,
                            ProjectName = "Project United",
                            ProjectTimespan = "2 weeks"
                        },
                        new
                        {
                            ProjectID = 7,
                            ProjectName = "Project Breeze",
                            ProjectTimespan = "1 week"
                        },
                        new
                        {
                            ProjectID = 8,
                            ProjectName = "Project AB",
                            ProjectTimespan = "3 weeks"
                        });
                });

            modelBuilder.Entity("PayrollCompany.Models.Employee", b =>
                {
                    b.HasOne("PayrollCompany.Models.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PayrollCompany.Models.EmployeeProject", b =>
                {
                    b.HasOne("PayrollCompany.Models.Employee", "Employee")
                        .WithMany("EmployeeProjects")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PayrollCompany.Models.Project", "Project")
                        .WithMany("EmployeeProjects")
                        .HasForeignKey("ProjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PayrollCompany.Models.Payroll", b =>
                {
                    b.HasOne("PayrollCompany.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}