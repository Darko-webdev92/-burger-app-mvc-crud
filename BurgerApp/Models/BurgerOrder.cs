namespace BurgerApp.Models
{
    public class BurgerOrder
    {
        // foreign keys
        public int BurgerId { get; set; }
        public int OrderId { get; set; }


        // navigation properties
        public Burger Burger { get; set; }
        public Order Order { get; set; }

    }
}
