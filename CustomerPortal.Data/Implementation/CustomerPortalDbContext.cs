using Microsoft.EntityFrameworkCore;
using CustomerPortal.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerPortal.Data.Implementation
{
    public class CustomerPortalDbContext : DbContext
    {

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<Employee>()
                .HasOne(p => p.Client)
                .WithMany(b => b.Employees);

            modelBuilder.Entity<EmployeeReviewAnswer>()
               .HasOne(p => p.Question)
               .WithMany(b => b.EmployeeReviewAnswers);

            modelBuilder.Entity<WorkflowItem>()
               .HasOne(p => p.Workflow)
               .WithMany(b => b.WorkflowItems);

            modelBuilder.Entity<EmployeeReview>()
               .HasOne(p => p.Employee)
               .WithMany(b => b.EmployeeReviews);

            modelBuilder.Entity<EmployeeReview>()
               .HasOne(p => p.WorkflowItem)
               .WithMany(b => b.EmployeeReviews);

            modelBuilder.Entity<EmployeeReviewAnswer>()
                .HasOne(p => p.EmployeeReview)
                .WithMany(b => b.EmployeeReviewAnswers);

            modelBuilder.Entity<UserRole>()
                .HasOne(p => p.Role)
                .WithMany(b => b.UserRoles);

            modelBuilder.Entity<UserRole>()
               .HasOne(p => p.User)
               .WithMany(b => b.UserRoles);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=HP; Database=CustomerPortalDb; Trusted_Connection=True; MultipleActiveResultSets=False;");
        }
        public CustomerPortalDbContext(DbContextOptions<CustomerPortalDbContext> options) : base(options)
        {
        }
        public virtual DbSet<Employee> Clients { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeReview> EmployeeReviews { get; set; }
        public virtual DbSet<EmployeeReviewAnswer> EmployeeReviewAnswers { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<Workflow> Workflows { get; set; }
        public virtual DbSet<WorkflowItem> WorkflowItems { get; set; }
    }
}
