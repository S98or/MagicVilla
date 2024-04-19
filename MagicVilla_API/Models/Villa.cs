using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagicVilla_API.Models
{
    public class Villa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]   
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;

        public string Detalle { get; set; } 

        public double Tarifa { get; set; }

        public int ocupantes {  get; set; } 

        public string ImagenUrl {  get; set; }  
        public DateTime FechaCreacion { get; set; } 

        public DateTime FechaActualizacion { get; set; }    



    }
}
