using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using CarRentalManagement.Shared.Models;

namespace CarRentalManagement.Server.Configuration.Entities
{
    public class VehicleConfiguration : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.HasData(
                new Vehicle
                {
                    Id = 1,
                    Year = 2020,
                    ManufacturerId = 2,
                    ModelId = 3,
                    ColourId = 2,
                    Vin = "ABC-123",
                    LicencePlateNumber = "ABC-123",
                    RentalRate = 750.00,
                    CreatedBy = "SYSTEM",
                    DateCreated = DateTime.Now,
                    UpdatedBy = "SYSTEM",
                    DateUpdated = DateTime.Now
                },
                new Vehicle
                {
                    Id = 2,
                    Year = 2022,
                    ManufacturerId = 3,
                    ModelId = 5,
                    ColourId = 1,
                    Vin = "EFG-123",
                    LicencePlateNumber = "EFG-123",
                    RentalRate = 850.00,
                    CreatedBy = "SYSTEM",
                    DateCreated = DateTime.Now,
                    UpdatedBy = "SYSTEM",
                    DateUpdated = DateTime.Now
                }
            );
        }
    }
}
