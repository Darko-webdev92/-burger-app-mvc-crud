using BurgerApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BurgerApp.Data.SeedData
{
    internal class SeedOrders : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> entity)
        {
            entity.HasData(
                new Order
                {
                    OrderId = 1,
                    FirstName = "Darko",
                    LastName = "Angelovski",
                    Address = "4-ti juli",
                    IsDelivered = false,
                    LocationId = 1,
                    BurgerOrders = new List<BurgerOrder>(),
                    Burgers = new List<Burger>()
                    {
                      
                    },

                
                    //Location = new Location()
                    //{
                    //    LocationId = 1,
                    //    OpensAt = TimeOnly.FromDateTime(new DateTime()),
                    //    ClosesAt = TimeOnly.FromDateTime(new DateTime()),
                    //    LocationName = "Gjorce"
                    //}
                    //Burgers = new List<Burger> {
                    //    new Burger()
                    //    {

                    //    }
                    //}
                }
            );
        }
    }
}
