using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FastEquipment.Models
{
    [PrimaryKey(nameof(EquipmentRequestId))]
    public class EquipmentRequest
    {

        // model variables with validation
        public int EquipmentRequestId { get; set; }

        [Required(ErrorMessage = "Please enter your name.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Please enter a valid email address.")]
        [EmailAddress]
        public string? Email { get; set; }

        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$", ErrorMessage = "Please enter a valid phone number.")]
        public string? PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please select a role.")]
        public string? Role { get; set; }

        [ForeignKey(nameof(EquipmentId))]
        public int EquipmentId { get; set; }

        [Required(ErrorMessage = "Please select an equipment type.")]
        public string? EquipmentType { get; set; }

        [Required(ErrorMessage = "Please describe the reason for your request.")]
        public string? Details { get; set; }

        [Required(ErrorMessage = "Please enter a positive duration for the request.")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a positive duration for the request.")]
        public int? Duration { get; set; }

        public StatusEnum RequestStatus { get; set; } = StatusEnum.Pending;

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}