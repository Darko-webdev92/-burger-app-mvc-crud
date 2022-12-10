using System.ComponentModel.DataAnnotations;

namespace BurgerApp.Models
{
    public class Burger
    {
        //[Key]
        //public int Id { get; set; }
        public int BurgerId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Price { get; set; }
        public bool IsVegetarian { get; set; }
        public bool IsVegan { get; set; }
        public bool HasFries { get; set; }

        public ICollection<BurgerOrder>? BurgerOrders { get; set; }
    }
}
