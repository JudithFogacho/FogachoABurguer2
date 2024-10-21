namespace FogachoABurguer2.Models
{
    public class Promo
    {
        public int PromoId { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaPromo { get; set; }
        public int BurguerId { get; set; }
        public Burguer? Burguer { get; set; }

    }
}
