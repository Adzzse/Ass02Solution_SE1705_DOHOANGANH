using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class FUCarRentingManagementContext : DbContext
    {
        public DbSet<CarInformation> CarInformations { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<RentingDetail> RentingDetails { get; set; }
        public DbSet<RentingTransaction> RentingTransactions { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configure the database connection
            optionsBuilder.UseSqlServer("Server=HOANGANHDO\\SQLEXPRESS;Database=FUCarRentingManagement;Uid=sa;Pwd=123456789;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure the relationship between CarInformation and Manufacturer
            modelBuilder.Entity<CarInformation>()
    .HasOne<CarInformation>()  // CarInformation has one related entity
    .WithOne()
    .HasForeignKey<CarInformation>(c => c.ManufacturerID);


            // Configure the relationship between CarInformation and Supplier
            modelBuilder.Entity<CarInformation>()
            .HasOne<Supplier>()
            .WithMany()
            .HasForeignKey(c => c.SupplierID);
        }
    }
}
