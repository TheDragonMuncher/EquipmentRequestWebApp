using Microsoft.EntityFrameworkCore;

namespace FastEquipment.Models.DataHandling
{
    public class EFEquipmentRequestRepository : IEquipmentRequestRepository
    {
        private FastEquipmentDbContext context;
        public EFEquipmentRequestRepository(FastEquipmentDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<EquipmentRequest> GetAll()
        {
            return context.Requests;
        }
        public IQueryable<EquipmentRequest> GetPending()
        {
            return context.Requests.Where(r => r.RequestStatus == StatusEnum.Pending);
        }
        public void Add(EquipmentRequest r)
        {
            context.Requests.Add(r);
        }
        public void UpdateStatus(int Id, StatusEnum status)
        {
            var request = context.Requests.Where(r => r.EquipmentRequestId == Id).ToList();
            request[0].RequestStatus = status;
            context.Requests.Update(request[0]);
        }
        public void Update()
        {
            context.SaveChanges();
        }
    }
}