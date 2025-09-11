namespace Assignment1.Models
{
    public static class Repository
    {
        private static List<EquipmentRequestModel> requests = new();
        public static IEnumerable<EquipmentRequestModel> Requests => requests;

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
                available = true
            },
            new EquipmentModel {
                id = 3,
                type = "Laptop",
                description = "Portable Workspace",
                available = true
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
                available = true
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
                available = true
            },
            new EquipmentModel {
                id = 8,
                type = "Tablet",
                description = "For The Kid(s)",
                available = true
            },
            new EquipmentModel {
                id = 9,
                type = "Tablet",
                description = "For The Kid(s)",
                available = true
            }
        ];
        public static IEnumerable<EquipmentModel> Equipment => equipmentList;


        public static void AddRequest(EquipmentRequestModel request)
        {
            Console.WriteLine(request);
            requests.Add(request);
        }
    }
}