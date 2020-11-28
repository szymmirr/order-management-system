using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace Aptor.Models
{
    public class Client
    {
        [Display(Name = "Id")]
        public long ClientId { get; set; }
        [Display(Name = "Imię")]
        public string FirstName { get; set; }
        [Display(Name = "Nazwisko")]
        public string LastName { get; set; }
        [Display(Name = "Adres")]
        public string Address { get; set; }

        public ICollection<Order> Orders { get; set; }
    }

    public class ClientDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
    }
}