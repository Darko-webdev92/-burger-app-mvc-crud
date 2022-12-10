using BurgerApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BurgerApp.Data.SeedData
{
    internal class SeedLocation : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> entity)
        {
            entity.HasData(
                new Location
                {
                    LocationId = 1,
                    LocationName = "Karpos",
                    OpensAt = new DateTime().AddHours(9),
                    ClosesAt = new DateTime().AddHours(23),
                }
            );
        }
    }
}
