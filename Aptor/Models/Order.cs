using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace Aptor.Models
{
    public class Order
    {
        [Display(Name = "Id zamówienia")]
        public long OrderId { get; set; }
        [Display(Name = "Id klienta")]
        public long ClientId { get; set; }
        [Display(Name = "Produkty")]
        public string Products { get; set; }
        [Display(Name = "Cena")]
        public double Price { get; set; }
        [Display(Name = "Pozycja")]
        public int Position { get; set; }

        public Client Client { get; set; }
    }

    public class OrderDbContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
    }
}