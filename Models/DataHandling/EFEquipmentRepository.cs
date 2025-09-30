namespace FastEquipment.Models.DataHandling
{
    public class EFEquipmentRepository : IEquipmentRepository
    {
        private FastEquipmentDbContext context;
        public EFEquipmentRepository(FastEquipmentDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Equipment> GetAll()
        {
            return context.Equipment;
        }
        public IQueryable<Equipment> GetAvailable()
        {
            return context.Equipment.Where(e => e.Available == true);
        }
        public IQueryable<Equipment> FindById(int Id)
        {
            return context.Equipment.Where(e => e.EquipmentId == Id);
        }
        public void Add(Equipment e)
        {
            context.Equipment.Add(e);
        }
        public void Update()
        {
            context.SaveChanges();
        }
    }
}