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
                     NormalizedName = "SYSTEM ADMIN"
                 },
                 new IdentityRole
                 {
                     Name = "Project Administrator",
                     NormalizedName = "PROJECT ADMIN"
                 },
                 new IdentityRole
                 {
                     Name = "Tech Lead",
                     NormalizedName = "TECH LEAD"
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
