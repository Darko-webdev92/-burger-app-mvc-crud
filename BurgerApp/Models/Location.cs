namespace BurgerApp.Models
{
    public class Location
    {
        public int LocationId { get; set; }

        public string LocationName { get; set; }
        public DateTime OpensAt { get; set; }
        public DateTime ClosesAt { get; set; }

        //public ICollection<Order> Orders { get; set; }
    }
}
