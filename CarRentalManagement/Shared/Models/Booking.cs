using System.ComponentModel.DataAnnotations;

namespace CarRentalManagement.Shared.Models
{
    public class Booking : BaseModel, IValidatableObject
    {
        public int VehicleId { get; set; }
        public int CustomerId { get; set; }
        public DateTime DateOut { get; set; }
        public DateTime DateIn { get; set; }

        public Vehicle? Vehicle { get; set; }
        public virtual Customer? Customer { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (DateIn <= DateOut)
            {
                yield return new ValidationResult("Date In must be geater than Date Out", new[] { "DateIn" });
            }
        }
    }
}