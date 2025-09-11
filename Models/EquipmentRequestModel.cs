namespace Assignment1.models
{
    public class EquipmentRequestModel
    {
        private static int idCounter = 0;

        public int id = 0;
        public string? name { get; set; }
        public string? email { get; set; }
        public string? phoneNumber { get; set; }
        public string? role { get; set; }
        public string? equipmentType { get; set; }
        public string? details { get; set; }
        public int? duration { get; set; }

        public void GiveId()
        {
            idCounter++;
            id = idCounter;
        }
    }
}