using Microsoft.EntityFrameworkCore;

namespace FastEquipment.Models.DataHandling
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            FastEquipmentDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider
                .GetRequiredService<FastEquipmentDbContext>();

            context.Database.Migrate();

            if (!context.Equipment.Any())
            {
                context.Equipment.AddRange(
                    new Equipment
                    {
                        EquipmentId = 1,
                        Type = "Laptop",
                        Description = "Portable Workspace",
                        Available = true
                    },
                    new Equipment
                    {
                        EquipmentId = 2,
                        Type = "Laptop",
                        Description = "Portable Workspace",
                        Available = false
                    },
                    new Equipment
                    {
                        EquipmentId = 3,
                        Type = "Laptop",
                        Description = "Portable Workspace",
                        Available = false
                    },
                    new Equipment
                    {
                        EquipmentId = 4,
                        Type = "Phone",
                        Description = "For Work Calls",
                        Available = true
                    },
                    new Equipment
                    {
                        EquipmentId = 5,
                        Type = "Phone",
                        Description = "For Work Calls",
                        Available = false
                    },
                    new Equipment
                    {
                        EquipmentId = 6,
                        Type = "Phone",
                        Description = "For Work Calls",
                        Available = true
                    },
                    new Equipment
                    {
                        EquipmentId = 7,
                        Type = "Tablet",
                        Description = "For The Kid(s)",
                        Available = false
                    },
                    new Equipment
                    {
                        EquipmentId = 8,
                        Type = "Tablet",
                        Description = "For The Kid(s)",
                        Available = false
                    },
                    new Equipment
                    {
                        EquipmentId = 9,
                        Type = "Tablet",
                        Description = "For The Kid(s)",
                        Available = false
                    }
                );
                context.SaveChanges();
            }
        }
    }
}