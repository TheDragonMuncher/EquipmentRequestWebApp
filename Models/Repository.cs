namespace FastEquipment.Models
{
    public static class Repository
    {
        // list and IEnumerable for equipment requests
        private static List<EquipmentRequest> requests = new();
        public static IEnumerable<EquipmentRequest> Requests => requests;

        // predefined list and IEnumerable for equipment
        private static List<Equipment> equipmentList = [
            new Equipment {
                EquipmentId = 1,
                Type = "Laptop",
                Description = "Portable Workspace",
                Available = true
            },
            new Equipment {
                EquipmentId = 2,
                Type = "Laptop",
                Description = "Portable Workspace",
                Available = false
            },
            new Equipment {
                EquipmentId = 3,
                Type = "Laptop",
                Description = "Portable Workspace",
                Available = false
            },
            new Equipment {
                EquipmentId = 4,
                Type = "Phone",
                Description = "For Work Calls",
                Available = true
            },
            new Equipment {
                EquipmentId = 5,
                Type = "Phone",
                Description = "For Work Calls",
                Available = false
            },
            new Equipment {
                EquipmentId = 6,
                Type = "Phone",
                Description = "For Work Calls",
                Available = true
            },
            new Equipment {
                EquipmentId = 7,
                Type = "Tablet",
                Description = "For The Kid(s)",
                Available = false
            },
            new Equipment {
                EquipmentId = 8,
                Type = "Tablet",
                Description = "For The Kid(s)",
                Available = false
            },
            new Equipment {
                EquipmentId = 9,
                Type = "Tablet",
                Description = "For The Kid(s)",
                Available = false
            }
        ];
        public static IEnumerable<Equipment> Equipment => equipmentList;


        // method for adding requests to stored list
        public static void AddRequest(EquipmentRequest request)
        {
            Console.WriteLine(request);
            requests.Add(request);
        }
    }
}