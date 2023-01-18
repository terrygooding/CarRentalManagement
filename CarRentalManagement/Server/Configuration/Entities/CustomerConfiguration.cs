using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using CarRentalManagement.Shared.Models;

namespace CarRentalManagement.Server.Configuration.Entities
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData(
                new Customer
                {
                    Id = 1,
                    FirstName = "Terry",
                    LastName = "Gooding",
                    EmailAddress = "terry@bluedepthcreative.com",
                    ContactNumber = "0123456789",
                    TaxId = "123-ABC",
                    Address = "Blundeston, Norwich, UK",
                    CreatedBy = "System",
                    DateCreated = DateTime.Now,
                    UpdatedBy = "System",
                    DateUpdated = DateTime.Now
                }
            );
        }
    }
}
