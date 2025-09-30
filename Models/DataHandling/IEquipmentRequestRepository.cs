namespace FastEquipment.Models.DataHandling
{
    public interface IEquipmentRequestRepository
    {
        public abstract IQueryable<EquipmentRequest> GetAll();
        public abstract IQueryable<EquipmentRequest> GetPending();
        public abstract void Add(EquipmentRequest r);
        public abstract void UpdateStatus(int Id, StatusEnum status);
        public abstract void Update();
    }
}