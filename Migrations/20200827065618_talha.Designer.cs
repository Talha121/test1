﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using test1.Data;

namespace test1.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200827065618_talha")]
    partial class talha
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("test1.Data.Employee", b =>
                {
                    b.Property<int>("Employeeid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Employeename")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Employyephone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Employeeid");

                    b.ToTable("employees");
                });
#pragma warning restore 612, 618
        }
    }
}
