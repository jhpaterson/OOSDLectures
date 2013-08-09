using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace PayrollModel
{
    public class PayrollContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // mappings for Employee
            modelBuilder.Entity<Employee>().ToTable("Employees");

            modelBuilder.Entity<Employee>().Property(e => e.EmployeeId).
             IsRequired().
             HasColumnName("employeeid");

            modelBuilder.Entity<Employee>().Property(e => e.Name).
             HasColumnName("employeename");

            modelBuilder.Entity<Employee>().Property(e => e.Username).
             HasColumnName("username");

            modelBuilder.Entity<Employee>().Property(e => e.PhoneNumber).
             HasColumnName("phonenumber");

            modelBuilder.Entity<Employee>().HasKey(e => e.EmployeeId);

            // mappings for Department
            modelBuilder.Entity<Department>().ToTable("Departments");

            modelBuilder.Entity<Department>().Property(d => d.Name).
             IsRequired().
             HasColumnName("departmentname");

            modelBuilder.Entity<Department>().HasKey(d => d.Name);

            // mapping for relationship (FK in Employees table is called department
            modelBuilder.Entity<Department>().
                HasMany(d => d.Employees).
                WithOptional().
                Map(m => m.MapKey("department"));

        }
    }
}
