﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using api_login_excercise.Model;

namespace api_login_excercise.Migrations
{
    [DbContext(typeof(EmployeeContext))]
    [Migration("20200719235435_Added-SeedData")]
    partial class AddedSeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6");

            modelBuilder.Entity("api_login_excercise.Model.Login", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Login");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Password = "admin@123",
                            UserName = "Admin"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
