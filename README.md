# Payroll-Company

# Description
.NET programming website that uses spaces and a local SQL database to provide a company portal for employees.

Designed the website using HTML and Bootstrap 

# Features
Has employee and admin functions 

Employee can:
- View Account
- View Timesheet
- Access Payroll
- View Time Off
- Logout

Admin can:
- Register New Employee
- View Employee Information
- Add New Project
- View Project Information
- Assign New Project
- Add New Payroll
- View Payroll Information
- Logout 

# Getting Started
This uses local data base so you need to install the following pluggins 
- Microsoft.EntityFrameworkCore.SqlSever 3.1.0
- Microsoft.EntityFrameworkCore.Tools 3.1.0
- Microsoft.VisualStudio.Web.CodeGeneration.Design 3.1.5

Once the plugins are installed you need to make a connection to the local database by going into the appSetting.json and add or make sure the following line of code is there 
- "PayrollContext": "Server=(localdb)\\mssqllocaldb;Database=NewPayroll;Trusted_Connection=True;MultipleActiveResultSets=true"

After that you should be able configure and Run the project

# SQL Database Visual
![image](https://user-images.githubusercontent.com/101303615/234126492-424d7ea0-b766-497f-9d89-1aecdfcf8c5c.png)
