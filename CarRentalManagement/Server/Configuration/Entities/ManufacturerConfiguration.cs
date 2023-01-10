using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using CarRentalManagement.Shared.Models;

namespace CarRentalManagement.Server.Configuration.Entities
{
    public class ManufacturerConfiguration : IEntityTypeConfiguration<Manufacturer>
    {
        public void Configure(EntityTypeBuilder<Manufacturer> builder)
        {
            builder.HasData(
                new Manufacturer
                {
                    Id = 1,
                    Name = "Porshe",
                    CreatedBy = "System",
                    DateCreated = DateTime.Now,
                    UpdatedBy = "System",
                    DateUpdated = DateTime.Now
                },
                new Manufacturer
                {
                    Id = 2,
                    Name = "Lamborghini",
                    CreatedBy = "System",
                    DateCreated = DateTime.Now,
                    UpdatedBy = "System",
                    DateUpdated = DateTime.Now
                },
                new Manufacturer
                {
                    Id = 3,
                    Name = "Ferrari",
                    CreatedBy = "System",
                    DateCreated = DateTime.Now,
                    UpdatedBy = "System",
                    DateUpdated = DateTime.Now
                },
                new Manufacturer
                {
                    Id = 4,
                    Name = "Maserati",
                    CreatedBy = "System",
                    DateCreated = DateTime.Now,
                    UpdatedBy = "System",
                    DateUpdated = DateTime.Now
                }
            );
        }
    }
}
