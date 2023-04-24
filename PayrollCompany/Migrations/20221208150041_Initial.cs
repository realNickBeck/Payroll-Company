using Microsoft.EntityFrameworkCore.Migrations;

namespace PayrollCompany.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    DepartmentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.DepartmentID);
                });

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    ProjectID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectName = table.Column<string>(nullable: false),
                    ProjectTimespan = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.ProjectID);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Username = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    State = table.Column<string>(nullable: false),
                    ZipCode = table.Column<string>(nullable: false),
                    DepartmentID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeID);
                    table.ForeignKey(
                        name: "FK_Employee_Department_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "Department",
                        principalColumn: "DepartmentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeProject",
                columns: table => new
                {
                    EmployeeProjectID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeID = table.Column<int>(nullable: false),
                    ProjectID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeProject", x => x.EmployeeProjectID);
                    table.ForeignKey(
                        name: "FK_EmployeeProject_Employee_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employee",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeProject_Project_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Project",
                        principalColumn: "ProjectID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payroll",
                columns: table => new
                {
                    PayrollID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeID = table.Column<int>(nullable: false),
                    serverance = table.Column<double>(nullable: false),
                    NetPay = table.Column<double>(nullable: false),
                    GrossPay = table.Column<double>(nullable: false),
                    TaxPercentWidthdrawal = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payroll", x => x.PayrollID);
                    table.ForeignKey(
                        name: "FK_Payroll_Employee_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employee",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "DepartmentID", "DepartmentName" },
                values: new object[,]
                {
                    { 1, "Payroll" },
                    { 2, "Executives" },
                    { 3, "Human Resources" },
                    { 4, "Operations" },
                    { 5, "Finance" },
                    { 6, "Sales" }
                });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "ProjectID", "ProjectName", "ProjectTimespan" },
                values: new object[,]
                {
                    { 1, "Project Payroll", "1 week" },
                    { 2, "Project Z", "1 week" },
                    { 3, "Project Point", "2 weeks" },
                    { 4, "Project X", "4 weeks" },
                    { 5, "Project Y", "8 weeks" },
                    { 6, "Project United", "2 weeks" },
                    { 7, "Project Breeze", "1 week" },
                    { 8, "Project AB", "3 weeks" }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "EmployeeID", "Address", "City", "DepartmentID", "FirstName", "LastName", "Password", "State", "Title", "Username", "ZipCode" },
                values: new object[,]
                {
                    { 1, "29 Olney St", "Philadelphia", 1, "John", "Doe", "1111", "PA", "Lead Payroll Associate", "jdoe38", "19191" },
                    { 7, "2500 Knights Rd", "Bensalem", 1, "Maria", "Wilson", "1243", "PA", "Payroll Associate", "mwilson78", "19020" },
                    { 12, "112 Finntown Rd", "Nanty Glo", 1, "Joshua", "Moore", "4545", "PA", "Payroll Associate", "jmoore11", "15943" },
                    { 2, "300 Hatboro Rd", "Horsham", 2, "Mike", "Smith", "1234", "PA", "Lead Manager", "msmisth22", "19091" },
                    { 4, "1836 Olney Rd", "Philadelphia", 3, "Colin", "Johson", "7890", "PA", "Human Resources Associate", "cjohnson33", "19199" },
                    { 9, "3949 Rainbow Dr", "Canton", 3, "Jackson", "Martin", "2222", "OH", "Lead Human Resources Associate", "jmartin23", "44702" },
                    { 14, "2 Tulip Ln", "Pottstown", 3, "Patrick", "Samuel", "1290", "PA", "Human Resources Associate", "psamuel90", "17901" },
                    { 5, "900 Spruce St", "Philadelphia", 4, "Mary", "Williams", "8080", "PA", "Lead Operations Associate", "mwilliams44", "19186" },
                    { 10, "4819 Princeton Ave", "Philadelphia", 4, "Madison", "Lane", "3333", "PA", "Operations Associate", "mlane67", "19135" },
                    { 15, "1929 N Main Ave", "Scranton", 4, "Keira", "Hill", "3489", "PA", "Operations Associate", "khill48", "18508" },
                    { 3, "29 Russell Rd", "Willow Grove", 5, "Robert", "Jones", "5678", "PA", "Finance Associate", "rjones12", "19090" },
                    { 8, "5 Hamilton Dr", "Perry Hall", 5, "Taylor", "Jackson", "1111", "MD", "Lead Finance Associate", "tjackson11", "21128" },
                    { 13, "11701 Route 6", "Corry", 5, "Lisa", "Miles", "5656", "PA", "Finance Associate", "lmiles34", "16407" },
                    { 6, "100 Cascade Dr", "Allentown", 6, "Linda", "Davis", "5789", "PA", "Lead Sales Associate", "ldavis45", "18109" },
                    { 11, "401 W Walnut Ln", "Philadelphia", 6, "Jordan", "Lee", "4444", "PA", "Sales Associate", "jlee99", "19144" },
                    { 16, "401 N 17th St", "Allentown", 6, "Stephanie", "Adams", "6666", "PA", "Sales Associate", "sadams12", "18104" }
                });

            migrationBuilder.InsertData(
                table: "EmployeeProject",
                columns: new[] { "EmployeeProjectID", "EmployeeID", "ProjectID" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 10, 11, 3 },
                    { 5, 6, 3 },
                    { 12, 13, 7 },
                    { 7, 8, 2 },
                    { 2, 3, 2 },
                    { 14, 15, 8 },
                    { 15, 16, 8 },
                    { 4, 5, 4 },
                    { 13, 14, 6 },
                    { 9, 10, 5 },
                    { 8, 9, 6 },
                    { 3, 4, 6 },
                    { 6, 7, 1 },
                    { 11, 12, 7 }
                });

            migrationBuilder.InsertData(
                table: "Payroll",
                columns: new[] { "PayrollID", "EmployeeID", "GrossPay", "NetPay", "TaxPercentWidthdrawal", "serverance" },
                values: new object[,]
                {
                    { 11, 11, 34000.0, 33559.010000000002, 440.99000000000001, 3923.0799999999999 },
                    { 1, 1, 47000.0, 46301.0, 699.0, 9038.4599999999991 },
                    { 6, 6, 39000.0, 38549.010000000002, 450.99000000000001, 6000.0 },
                    { 13, 13, 45000.0, 44498.010000000002, 501.99000000000001, 6923.0799999999999 },
                    { 7, 7, 46000.0, 45500.0, 500.0, 14153.85 },
                    { 8, 8, 50000.0, 49432.010000000002, 567.99000000000001, 17307.689999999999 },
                    { 3, 3, 45000.0, 44500.0, 500.0, 5192.3100000000004 },
                    { 12, 12, 43000.0, 42500.010000000002, 499.99000000000001, 9923.0799999999999 },
                    { 15, 15, 71000.0, 70400.0, 600.0, 24579.919999999998 },
                    { 2, 2, 89000.0, 88201.0, 799.0, 34230.769999999997 },
                    { 10, 10, 67000.0, 66410.009999999995, 589.99000000000001, 12884.620000000001 },
                    { 5, 5, 78000.0, 77301.0, 699.0, 21000.0 },
                    { 4, 4, 32000.0, 31500.02, 499.98000000000002, 2461.54 },
                    { 14, 14, 30000.0, 29540.009999999998, 459.99000000000001, 1153.8499999999999 },
                    { 9, 9, 42000.0, 41489.019999999997, 510.98000000000002, 8076.9200000000001 },
                    { 16, 16, 39000.0, 38542.010000000002, 457.99000000000001, 4500.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_DepartmentID",
                table: "Employee",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeProject_EmployeeID",
                table: "EmployeeProject",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeProject_ProjectID",
                table: "EmployeeProject",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_Payroll_EmployeeID",
                table: "Payroll",
                column: "EmployeeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeProject");

            migrationBuilder.DropTable(
                name: "Payroll");

            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Department");
        }
    }
}
