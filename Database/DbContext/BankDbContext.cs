using Database.Model;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Database.Context
{
    public class BankDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=DESKTOP-POOH2AD\SQLEXPRESS;Database=CarParking;Trusted_Connection=True;TrustServerCertificate=True;ConnectRetryCount=0");
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-OEII1PR\MSSQLSERVER01;Database=Bank;Trusted_Connection=True;TrustServerCertificate=True;ConnectRetryCount=0");
        }

        // DbSets for Tables
        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Loan> Loans { get; set; }

        // Optional: If you're using Roles or UserRoles for auth
        //public DbSet<Role> Roles { get; set; }
        //public DbSet<UserRole> UserRoles { get; set; }
    }
}
