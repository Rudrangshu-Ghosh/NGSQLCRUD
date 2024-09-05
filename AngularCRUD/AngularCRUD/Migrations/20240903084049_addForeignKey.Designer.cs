﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AngularCRUD.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240903084049_addForeignKey")]
    partial class addForeignKey
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AngularCRUD.Models.Customer", b =>
                {
                    b.Property<int>("Cid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Cid"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Deptid")
                        .HasColumnType("int");

                    b.Property<DateTime>("Doj")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Sal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Cid");

                    b.HasIndex("Deptid");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("AngularCRUD.Models.Department", b =>
                {
                    b.Property<int>("Did")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Did"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Did");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("AngularCRUD.Models.Employee", b =>
                {
                    b.Property<int>("Eid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Eid"));

                    b.Property<int?>("Deptid")
                        .HasColumnType("int");

                    b.Property<DateTime>("Doj")
                        .HasColumnType("datetime2");

                    b.Property<string>("Ename")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Eid");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("AngularCRUD.Models.Skill", b =>
                {
                    b.Property<int>("SkillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SkillId"));

                    b.Property<int?>("EmployeeEid")
                        .HasColumnType("int");

                    b.Property<string>("SkillDesc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkillName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SkillId");

                    b.HasIndex("EmployeeEid");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("AngularCRUD.Models.Customer", b =>
                {
                    b.HasOne("AngularCRUD.Models.Department", "Dept")
                        .WithMany()
                        .HasForeignKey("Deptid");

                    b.Navigation("Dept");
                });

            modelBuilder.Entity("AngularCRUD.Models.Skill", b =>
                {
                    b.HasOne("AngularCRUD.Models.Employee", null)
                        .WithMany("Skills")
                        .HasForeignKey("EmployeeEid");
                });

            modelBuilder.Entity("AngularCRUD.Models.Employee", b =>
                {
                    b.Navigation("Skills");
                });
#pragma warning restore 612, 618
        }
    }
}
