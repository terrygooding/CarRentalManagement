using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using CarRentalManagement.Shared.Models;

namespace CarRentalManagement.Server.Configuration.Entities
{
    public class ModelConfiguration : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            builder.HasData(
                new Model
                {
                    Id = 1,
                    Name = "Cayenne",
                    CreatedBy = "System",
                    DateCreated = DateTime.Now,
                    UpdatedBy = "System",
                    DateUpdated = DateTime.Now
                },
                new Model
                {
                    Id = 2,
                    Name = "Maca",
                    CreatedBy = "System",
                    DateCreated = DateTime.Now,
                    UpdatedBy = "System",
                    DateUpdated = DateTime.Now
                },
                new Model
                {
                    Id = 3,
                    Name = "Aventador",
                    CreatedBy = "System",
                    DateCreated = DateTime.Now,
                    UpdatedBy = "System",
                    DateUpdated = DateTime.Now
                },
                new Model
                {
                    Id = 4,
                    Name = "Huracan",
                    CreatedBy = "System",
                    DateCreated = DateTime.Now,
                    UpdatedBy = "System",
                    DateUpdated = DateTime.Now
                },
                new Model
                {
                    Id = 5,
                    Name = "Portofino",
                    CreatedBy = "System",
                    DateCreated = DateTime.Now,
                    UpdatedBy = "System",
                    DateUpdated = DateTime.Now
                },
                new Model
                {
                    Id = 6,
                    Name = "Roma",
                    CreatedBy = "System",
                    DateCreated = DateTime.Now,
                    UpdatedBy = "System",
                    DateUpdated = DateTime.Now
                },
                new Model
                {
                    Id = 7,
                    Name = "Ghibli",
                    CreatedBy = "System",
                    DateCreated = DateTime.Now,
                    UpdatedBy = "System",
                    DateUpdated = DateTime.Now
                },
                new Model
                {
                    Id = 8,
                    Name = "Levante",
                    CreatedBy = "System",
                    DateCreated = DateTime.Now,
                    UpdatedBy = "System",
                    DateUpdated = DateTime.Now
                }
            );
        }
    }
}
