using CarRentalManagement.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalManagement.Server.Configuration.Entities
{
    public class ColourConfiguration : IEntityTypeConfiguration<Colour>
    {
        public void Configure(EntityTypeBuilder<Colour> builder)
        {
            builder.HasData(
                new Colour
                {
                    Id = 1,
                    Name = "Black",
                    CreatedBy = "System",
                    DateCreated = DateTime.Now,
                    UpdatedBy = "System",
                    DateUpdated = DateTime.Now
                },
                new Colour
                {
                    Id = 2,
                    Name = "Red",
                    CreatedBy = "System",
                    DateCreated = DateTime.Now,
                    UpdatedBy = "System",
                    DateUpdated = DateTime.Now
                },
                new Colour
                {
                    Id = 3,
                    Name = "White",
                    CreatedBy = "System",
                    DateCreated = DateTime.Now,
                    UpdatedBy = "System",
                    DateUpdated = DateTime.Now
                },
                new Colour
                {
                    Id = 4,
                    Name = "Blue",
                    CreatedBy = "System",
                    DateCreated = DateTime.Now,
                    UpdatedBy = "System",
                    DateUpdated = DateTime.Now
                }
            );
        }
    }
}
