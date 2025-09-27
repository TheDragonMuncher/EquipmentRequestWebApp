using Microsoft.EntityFrameworkCore;

namespace FastEquipment.Models
{
    public class FastEquipmentDbContext : DbContext
    {
        public FastEquipmentDbContext(DbContextOptions<FastEquipmentDbContext> options) : base(options) { }

        public DbSet<Equipment> Equipment => Set<Equipment>();
        public DbSet<EquipmentRequest> Requests => Set<EquipmentRequest>();
    }
}