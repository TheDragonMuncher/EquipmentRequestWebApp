using System.ComponentModel.DataAnnotations;

namespace Assignment1.Models
{
    public class EquipmentRequestModel
    {
        // static id counter
        private static int idCounter = 0;

        // model variables with validation
        public int id = 0;

        [Required(ErrorMessage = "Please enter your name.")]
        public string? name { get; set; }

        [Required(ErrorMessage = "Please enter a valid email address.")]
        [EmailAddress]
        public string? email { get; set; }

        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$", ErrorMessage = "Please enter a valid phone number.")]

        public string? phoneNumber { get; set; }
        [Required(ErrorMessage = "Please select a role.")]
        public string? role { get; set; }

        [Required(ErrorMessage = "Please select an equipment type.")]
        public string? equipmentType { get; set; }

        [Required(ErrorMessage = "Please describe the reason for your request.")]
        public string? details { get; set; }

        [Required(ErrorMessage = "Please enter a positive duration for the request.")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a positive duration for the request.")]
        public int? duration { get; set; }


        // model method to assign ids to objects
        public void GiveId()
        {
            idCounter++;
            id = idCounter;
        }
    }
}