namespace FastEquipment.Models
{
    public class Equipment
    {
        // Model variables
        public int EquipmentId { get; set; }
        public string? Type { get; set; }
        public string? Description { get; set; }
        public bool Available { get; set; }
    }
}