namespace Assignment1.models
{
    public class Repository
    {
        private static List<EquipmentRequestModel> requests = new();
        private static IEnumerable<EquipmentRequestModel> Requests => requests;

        public static void AddRequest(EquipmentRequestModel request)
        {
            Console.WriteLine(request);
            requests.Add(request);
        }
    }
}