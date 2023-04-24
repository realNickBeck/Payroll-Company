using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace PayrollCompany.Models
{
    public class PayrollConfig : IEntityTypeConfiguration<Payroll>
    {
        public void Configure(EntityTypeBuilder<Payroll> entity)
        {
            entity.HasData(
                new Payroll { PayrollID = 1, EmployeeID = 1, serverance = 9038.46, NetPay = 46301.00, TaxPercentWidthdrawal = 699.00, GrossPay = 47000.00 },
                new Payroll { PayrollID = 2, EmployeeID = 2, serverance = 34230.77, NetPay = 88201.00, TaxPercentWidthdrawal = 799.00, GrossPay = 89000.00 },
                new Payroll { PayrollID = 3, EmployeeID = 3, serverance = 5192.31, NetPay = 44500.00, TaxPercentWidthdrawal = 500.00, GrossPay = 45000.00 },
                new Payroll { PayrollID = 4, EmployeeID = 4, serverance = 2461.54, NetPay = 31500.02, TaxPercentWidthdrawal = 499.98, GrossPay = 32000.00 },
                new Payroll { PayrollID = 5, EmployeeID = 5, serverance = 21000.00, NetPay = 77301.00, TaxPercentWidthdrawal = 699.00, GrossPay = 78000.00 },
                new Payroll { PayrollID = 6, EmployeeID = 6, serverance = 6000.00, NetPay = 38549.01, TaxPercentWidthdrawal = 450.99, GrossPay = 39000.00 },
                new Payroll { PayrollID = 7, EmployeeID = 7, serverance = 14153.85, NetPay = 45500.00, TaxPercentWidthdrawal = 500.00, GrossPay = 46000.00 },
                new Payroll { PayrollID = 8, EmployeeID = 8, serverance = 17307.69, NetPay = 49432.01, TaxPercentWidthdrawal = 567.99, GrossPay = 50000.00 },
                new Payroll { PayrollID = 9, EmployeeID = 9, serverance = 8076.92, NetPay = 41489.02, TaxPercentWidthdrawal = 510.98, GrossPay = 42000.00 },
                new Payroll { PayrollID = 10, EmployeeID = 10, serverance = 12884.62, NetPay = 66410.01, TaxPercentWidthdrawal = 589.99, GrossPay = 67000.00 },
                new Payroll { PayrollID = 11, EmployeeID = 11, serverance = 3923.08, NetPay = 33559.01, TaxPercentWidthdrawal = 440.99, GrossPay = 34000.00 },
                new Payroll { PayrollID = 12, EmployeeID = 12, serverance = 9923.08, NetPay = 42500.01, TaxPercentWidthdrawal = 499.99, GrossPay = 43000.00 },
                new Payroll { PayrollID = 13, EmployeeID = 13, serverance = 6923.08, NetPay = 44498.01, TaxPercentWidthdrawal = 501.99, GrossPay = 45000.00 },
                new Payroll { PayrollID = 14, EmployeeID = 14, serverance = 1153.85, NetPay = 29540.01, TaxPercentWidthdrawal = 459.99, GrossPay = 30000.00 },
                new Payroll { PayrollID = 15, EmployeeID = 15, serverance = 24579.92, NetPay = 70400.00, TaxPercentWidthdrawal = 600.00, GrossPay = 71000.00 },
                new Payroll { PayrollID = 16, EmployeeID = 16, serverance = 4500.00, NetPay = 38542.01, TaxPercentWidthdrawal = 457.99, GrossPay = 39000.00 }
            );
        }
    }
}
