using System.ComponentModel.DataAnnotations;

namespace FogachoABurguer2.Models
{
    public class Burguer
    {
        public int BurguerId { get; set; }
        [Required]
        public string? BurguerName { get; set; }
        public bool WithCheese { get; set; }
        [Range(0.01,99.99)]
        public decimal Price { get; set; }
        public List<Promo>? Promos { get; set; }

    }
}
