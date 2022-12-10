using BurgerApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BurgerApp.Data.SeedData
{
    internal class SeedBurgerOrder : IEntityTypeConfiguration<BurgerOrder>
    {
        public void Configure(EntityTypeBuilder<BurgerOrder> entity)
        {
            entity.HasData(
                new BurgerOrder
                {
                     BurgerId = 1, OrderId = 1
                }
            );
        }
    }
}
