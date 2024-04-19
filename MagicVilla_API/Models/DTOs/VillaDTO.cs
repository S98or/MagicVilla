

namespace MagicVilla_API.Models.DTOs
{
    public class VillaDTO
    {

        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;

        public string Detalle { get; set; }

        public double Tarifa { get; set; }

        public int ocupantes { get; set; }
    }
}
