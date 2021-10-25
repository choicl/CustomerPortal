﻿// <auto-generated />
using System;
using CustomerPortal.Data.Implementation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CustomerPortal.Data.Migrations
{
    [DbContext(typeof(CustomerPortalDbContext))]
    [Migration("20210715200947_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CustomerPortal.Data.Entity.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.HasKey("ClientId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("CustomerPortal.Data.Entity.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<string>("Resume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("EmployeeId");

                    b.HasIndex("ClientId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("CustomerPortal.Data.Entity.EmployeeReview", b =>
                {
                    b.Property<int>("EmployeeReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReviewDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("WorkflowItemId")
                        .HasColumnType("int");

                    b.HasKey("EmployeeReviewId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("WorkflowItemId");

                    b.ToTable("EmployeeReviews");
                });

            modelBuilder.Entity("CustomerPortal.Data.Entity.EmployeeReviewAnswer", b =>
                {
                    b.Property<int>("EmployeeReviewAnswerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmployeeReviewId")
                        .HasColumnType("int");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeReviewAnswerId");

                    b.HasIndex("EmployeeReviewId");

                    b.HasIndex("QuestionId");

                    b.ToTable("EmployeeReviewAnswers");
                });

            modelBuilder.Entity("CustomerPortal.Data.Entity.Question", b =>
                {
                    b.Property<int>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("QuestionId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("CustomerPortal.Data.Entity.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("CustomerPortal.Data.Entity.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CustomerPortal.Data.Entity.UserRole", b =>
                {
                    b.Property<int>("UserRoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("UserRoleId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("CustomerPortal.Data.Entity.Workflow", b =>
                {
                    b.Property<int>("WorkflowId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.HasKey("WorkflowId");

                    b.ToTable("Workflows");
                });

            modelBuilder.Entity("CustomerPortal.Data.Entity.WorkflowItem", b =>
                {
                    b.Property<int>("WorkflowItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AMApprovalDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("HRApprovalDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsApprovedByAM")
                        .HasColumnType("bit");

                    b.Property<bool>("IsApprovedByHR")
                        .HasColumnType("bit");

                    b.Property<int>("WorkflowId")
                        .HasColumnType("int");

                    b.HasKey("WorkflowItemId");

                    b.HasIndex("WorkflowId");

                    b.ToTable("WorkflowItems");
                });

            modelBuilder.Entity("CustomerPortal.Data.Entity.Employee", b =>
                {
                    b.HasOne("CustomerPortal.Data.Entity.Client", "Client")
                        .WithMany("Employees")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("CustomerPortal.Data.Entity.EmployeeReview", b =>
                {
                    b.HasOne("CustomerPortal.Data.Entity.Employee", "Employee")
                        .WithMany("EmployeeReviews")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CustomerPortal.Data.Entity.WorkflowItem", "WorkflowItem")
                        .WithMany("EmployeeReviews")
                        .HasForeignKey("WorkflowItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("WorkflowItem");
                });

            modelBuilder.Entity("CustomerPortal.Data.Entity.EmployeeReviewAnswer", b =>
                {
                    b.HasOne("CustomerPortal.Data.Entity.EmployeeReview", "EmployeeReview")
                        .WithMany("EmployeeReviewAnswers")
                        .HasForeignKey("EmployeeReviewId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CustomerPortal.Data.Entity.Question", "Question")
                        .WithMany("EmployeeReviewAnswers")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EmployeeReview");

                    b.Navigation("Question");
                });

            modelBuilder.Entity("CustomerPortal.Data.Entity.UserRole", b =>
                {
                    b.HasOne("CustomerPortal.Data.Entity.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CustomerPortal.Data.Entity.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CustomerPortal.Data.Entity.WorkflowItem", b =>
                {
                    b.HasOne("CustomerPortal.Data.Entity.Workflow", "Workflow")
                        .WithMany("WorkflowItems")
                        .HasForeignKey("WorkflowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Workflow");
                });

            modelBuilder.Entity("CustomerPortal.Data.Entity.Client", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("CustomerPortal.Data.Entity.Employee", b =>
                {
                    b.Navigation("EmployeeReviews");
                });

            modelBuilder.Entity("CustomerPortal.Data.Entity.EmployeeReview", b =>
                {
                    b.Navigation("EmployeeReviewAnswers");
                });

            modelBuilder.Entity("CustomerPortal.Data.Entity.Question", b =>
                {
                    b.Navigation("EmployeeReviewAnswers");
                });

            modelBuilder.Entity("CustomerPortal.Data.Entity.Role", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("CustomerPortal.Data.Entity.User", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("CustomerPortal.Data.Entity.Workflow", b =>
                {
                    b.Navigation("WorkflowItems");
                });

            modelBuilder.Entity("CustomerPortal.Data.Entity.WorkflowItem", b =>
                {
                    b.Navigation("EmployeeReviews");
                });
#pragma warning restore 612, 618
        }
    }
}