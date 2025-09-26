namespace FastEquipment.Models
{
    public static class Repository
    {
        // list and IEnumerable for equipment requests
        private static List<EquipmentRequestModel> requests = new();
        public static IEnumerable<EquipmentRequestModel> Requests => requests;

        // predefined list and IEnumerable for equipment
        private static List<EquipmentModel> equipmentList = [
            new EquipmentModel {
                id = 1,
                type = "Laptop",
                description = "Portable Workspace",
                available = true
            },
            new EquipmentModel {
                id = 2,
                type = "Laptop",
                description = "Portable Workspace",
                available = false
            },
            new EquipmentModel {
                id = 3,
                type = "Laptop",
                description = "Portable Workspace",
                available = false
            },
            new EquipmentModel {
                id = 4,
                type = "Phone",
                description = "For Work Calls",
                available = true
            },
            new EquipmentModel {
                id = 5,
                type = "Phone",
                description = "For Work Calls",
                available = false
            },
            new EquipmentModel {
                id = 6,
                type = "Phone",
                description = "For Work Calls",
                available = true
            },
            new EquipmentModel {
                id = 7,
                type = "Tablet",
                description = "For The Kid(s)",
                available = false
            },
            new EquipmentModel {
                id = 8,
                type = "Tablet",
                description = "For The Kid(s)",
                available = false
            },
            new EquipmentModel {
                id = 9,
                type = "Tablet",
                description = "For The Kid(s)",
                available = false
            }
        ];
        public static IEnumerable<EquipmentModel> Equipment => equipmentList;


        // method for adding requests to stored list
        public static void AddRequest(EquipmentRequestModel request)
        {
            Console.WriteLine(request);
            requests.Add(request);
        }
    }
}