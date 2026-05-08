using LeGarage.Core.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LeGarage.Infra.Persistence.Data
{
    public class LeGarageContext : IdentityDbContext<Employee, EmployeeRole, int>
    {
        public LeGarageContext(DbContextOptions<LeGarageContext> options) : base(options)
        {
        }
        public DbSet<Bridge> Bridges { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<ExternalService> ExternalServices { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<PauseRecord> PauseRecords { get; set; }
        public DbSet<ProvidedService> ProvidedServices { get; set; }
        public DbSet<ProvidedServiceCategory> ProvidedServiceCategories { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<SparePart> SpareParts { get; set; }
        public DbSet<SparePartCategory> SparePartCategories { get; set; }
        public DbSet<StockReplenishment> StockReplenishments { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<TaskExternalServiceUsage> TaskExternalServiceUsages { get; set; }
        public DbSet<TaskPartUsage> TaskPartUsages { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<WarehouseStock> WarehouseStocks { get; set; }
        public DbSet<WorkOrder> WorkOrders { get; set; }
        public DbSet<WorkShop> WorkShops { get; set; }

    }
}
