using CarRentalManagement.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalManagement.Server.Configuration.Entities
{
    public class BookingConfiguration : IEntityTypeConfiguration<Booking>
    {
        public void Configure(EntityTypeBuilder<Booking> builder)
        {
            builder.HasData(
                new Booking
                {
                    Id = 1,
                    VehicleId = 1,
                    CustomerId = 1,
                    DateOut = new DateTime(2023, 1, 1),
                    DateIn = new DateTime(2023, 1, 4),
                    CreatedBy = "System",
                    DateCreated = DateTime.Now,
                    UpdatedBy = "System",
                    DateUpdated = DateTime.Now
                }
            );
        }
    }
}
