namespace Assignment1.Models
{
    public class EquipmentModel
    {
        private static int idCounter = 0;

        public int id { get; set; }
        public string? type { get; set; }
        public string? description { get; set; }
        public bool available { get; set; }

        public void GiveId()
        {
            idCounter++;
            id = idCounter;
        }
    }
}