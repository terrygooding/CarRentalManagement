using System.ComponentModel.DataAnnotations;

namespace CarRentalManagement.Shared.Models
{
    public class Customer : BaseModel
    {
        [Required]
        public string TaxId { get; set; }
        public string Address { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string ContactNumber { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string EmailAddress { get; set; }

        public virtual List<Booking>? Bookings { get; set; }
    }
}