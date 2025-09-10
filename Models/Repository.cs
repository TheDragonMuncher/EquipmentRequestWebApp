namespace Assignment1.models
{
    public static class Repository
    {
        private static List<EquipmentRequestModel> requests = new();
        public static IEnumerable<EquipmentRequestModel> Requests => requests;

        public static void AddRequest(EquipmentRequestModel request)
        {
            Console.WriteLine(request);
            requests.Add(request);
        }
    }
}