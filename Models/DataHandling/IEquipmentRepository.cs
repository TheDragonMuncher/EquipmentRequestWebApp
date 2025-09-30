namespace FastEquipment.Models.DataHandling
{
    public interface IEquipmentRepository
    {
        public abstract IQueryable<Equipment> GetAll();
        public abstract IQueryable<Equipment> GetAvailable();
        public abstract IQueryable<Equipment> FindById(int Id);
        public abstract void Add(Equipment e);
        public abstract void Update();
    }
}