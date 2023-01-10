namespace CarRentalManagement.Shared.Models
{
    public class Booking : BaseModel
    {
        public int VehicleId { get; set; }
        public int CustomerId { get; set; }
        public DateTime DateOut { get; set; }
        public DateTime DateIn { get; set; }

        public virtual Vehicle Vehicle { get; set; }
        public virtual Customer Customer { get; set; }
    }
}