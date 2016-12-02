using _01_DataAccessLayer.Mapping;
using _01_DataAccessLayer.Migrations;
using _01_Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DataAccessLayer
{
    public class TaskManagementContext : DbContext
    {
        public TaskManagementContext() :base("name = TaskManagement")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<TaskManagementContext, Configuration>());
        }
        internal DbSet<Customer> Customers { get; set; }
        internal DbSet<CustomerRequest> CustomerRequests { get; set; }
        internal DbSet<Employee> Employees { get; set; }
        internal DbSet<EmployeeType> EmployeeTypes { get; set; }
        internal DbSet<Project> Projects { get; set; }
        internal DbSet<Status> Statuses { get; set; }
        internal DbSet<Tasks> Taskss { get; set; }
        internal DbSet<ProjectEmployees> ProjectEmployees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new CustomerRequestMap());
            modelBuilder.Configurations.Add(new EmployeeMap());
            modelBuilder.Configurations.Add(new EmployeeTypeMap());
            modelBuilder.Configurations.Add(new ProjectMap());
            modelBuilder.Configurations.Add(new StatusMap());
            modelBuilder.Configurations.Add(new TasksMap());
            modelBuilder.Configurations.Add(new ProjectEmplooyesMap());

            base.OnModelCreating(modelBuilder);
        }

        public void EntityleriBosaCikar()
        {
            foreach (var item in ChangeTracker.Entries().ToList())
            {
                item.State = EntityState.Detached;
            }
        }
    }
}
