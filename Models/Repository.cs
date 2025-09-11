namespace Assignment1.models
{
    public static class Repository
    {
        private static List<EquipmentRequestModel> requests = new();
        public static IEnumerable<EquipmentRequestModel> Requests => requests;

        private static List<EquipmentModel> equipmentList = new();
        public static IEnumerable<EquipmentModel> Equipment => equipmentList;


        public static void AddRequest(EquipmentRequestModel request)
        {
            Console.WriteLine(request);
            requests.Add(request);
        }

        public static void AddEquipment(EquipmentModel equipment)
        {
            equipmentList.Add(equipment);
        }
    }
}