using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelListingAPI.Configurations.Entities
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                 new IdentityRole
                 {
                     Name = "User",
                     NormalizedName = "USER"
                 },
                 new IdentityRole
                 {
                     Name = "System Administrator",
                     NormalizedName = "SYSTEMADMIN"
                 },
                 new IdentityRole
                 {
                     Name = "Project Administrator",
                     NormalizedName = "PROJECTADMIN"
                 },
                 new IdentityRole
                 {
                     Name = "Tech Lead",
                     NormalizedName = "TECHLEAD"
                 },
                 new IdentityRole
                 {
                     Name = "Developer",
                     NormalizedName = "DEVELOPER"
                 }
             );
        }
    }
}
