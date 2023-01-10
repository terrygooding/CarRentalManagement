using CarRentalManagement.Server.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace CarRentalManagement.Server.Configuration.Entities
{
    public class IdentityUserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "37ccb19d-b273-4634-88eb-c692e0f0f4b8",
                    UserId = "5839dff5-2d5d-499a-b12b-0efae987dd25"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "44031f2e-904e-414c-adb1-c0a4d391ddab",
                    UserId = "f86bb2cd-776d-4551-8ef4-21cf956f2ea1"
                }
            );
        }
    }
}
