using BurgerApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BurgerApp.Data.SeedData
{
    internal class SeedBurgers : IEntityTypeConfiguration<Burger>
    {
        public void Configure(EntityTypeBuilder<Burger> entity)
        {
            entity.HasData(
                new Burger
                {
                    BurgerId = 1,
                    Name =  "Hamburer",
                    Price = 100,
                    IsVegetarian = true,
                    IsVegan = false,
                    HasFries = true,
                }
            );
        }
    }
}
