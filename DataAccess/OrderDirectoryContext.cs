using Entities;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OrderDirectoryContext : DbContext
    {
        public OrderDirectoryContext(DbContextOptions<OrderDirectoryContext> options)
            : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<OrderPayment> OrderPayments { get; set; }

        public override int SaveChanges()
        {
            AddAuditInfo();
            return base.SaveChanges();
        }

        public async Task<int> SaveChangesAsync()
        {
            AddAuditInfo();
            return await base.SaveChangesAsync();
        }

        private void AddAuditInfo()
        {
            var auditEntries = ChangeTracker.Entries()?.Where(x=>x.Entity is BaseAuditEntity && (x.State == EntityState.Added || x.State == EntityState.Modified));
            foreach(var entry in auditEntries)
            {
                if(entry.State == EntityState.Added)
                {
                    ((BaseAuditEntity)entry.Entity).CreatedDate = DateTime.UtcNow;
                }
                ((BaseAuditEntity)entry.Entity).LastUpdatedDate = DateTime.UtcNow;
            }
        }
    }
}
