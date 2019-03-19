﻿// <auto-generated />
using System;
using EmployeesMapping.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EmployeesMapping.Data.Migrations
{
    [DbContext(typeof(EmployeesMappingContext))]
    partial class EmployeesMappingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EmployeesMapping.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<DateTime?>("BirthDay");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<decimal>("Salary");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Georgi",
                            LastName = "Georgiev",
                            Salary = 12131.44m
                        },
                        new
                        {
                            Id = 2,
                            Address = "Neznam",
                            BirthDay = new DateTime(2019, 3, 4, 16, 6, 30, 351, DateTimeKind.Local).AddTicks(1308),
                            FirstName = "Maria",
                            LastName = "Marieva",
                            Salary = 999.10m
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Alisia",
                            LastName = "Alisieva",
                            Salary = 11111.11m
                        },
                        new
                        {
                            Id = 4,
                            Address = "Neznam2",
                            FirstName = "Pesho",
                            LastName = "Peshov",
                            Salary = 431.44m
                        },
                        new
                        {
                            Id = 5,
                            BirthDay = new DateTime(2018, 3, 19, 16, 6, 30, 353, DateTimeKind.Local).AddTicks(4074),
                            FirstName = "Vyara",
                            LastName = "Marinova",
                            Salary = 2000.44m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
