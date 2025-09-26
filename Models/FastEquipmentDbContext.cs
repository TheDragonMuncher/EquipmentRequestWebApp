using Microsoft.EntityFrameworkCore;

namespace FastEquipment.Models
{
    public class FastEquipmentDbContext : DbContext
    {
        public FastEquipmentDbContext(DbContextOptions<FastEquipmentDbContext> options) : base(options) { }

        public DbSet<EquipmentModel> Equipment => Set<EquipmentModel>();
        public DbSet<EquipmentRequestModel> Requests => Set<EquipmentRequestModel>();
    }
}