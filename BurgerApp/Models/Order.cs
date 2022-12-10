namespace BurgerApp.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        // read-only property = SLUG
        public string FullName => $"{FirstName} {LastName}";
        public string Address { get; set; }
        public bool IsDelivered { get; set; }
        public Location Location { get; set; }
        public int LocationId { get; set; }
        public List<Burger> Burgers { get; set; }
        //public int TotalPrice => Burgers == null ? 0 : Burgers.Sum(x => x.Quantity * x.Price);
        public ICollection<BurgerOrder> BurgerOrders { get; set; }

    }
}
