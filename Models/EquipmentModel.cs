namespace FastEquipment.Models
{
    public class EquipmentModel
    {
        // Model variables
        public int id { get; set; }
        public string? type { get; set; }
        public string? description { get; set; }
        public bool available { get; set; }
    }
}