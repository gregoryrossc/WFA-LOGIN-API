using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace api_login_excercise.Model
{
    public class EmployeeContext : DbContext
    {
        //inject the connections
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {

        }
        public EmployeeContext()
        {

        }
        public DbSet<Login> Login { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(ConfigurationManager.ConnectionStrings["EmsDatabase"].ConnectionString);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Login>().HasData(
                new Login
                {
                    Id = 1,
                    UserName = "Admin",
                    Password = "admin@123"


                }
                );      
                
        }
    }

}
