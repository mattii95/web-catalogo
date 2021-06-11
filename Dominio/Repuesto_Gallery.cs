using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class Repuesto_Gallery
    {
        [Key]
        public int idGallery { get; set; }
        public byte[] image { get; set; }
        public string image_desc { get; set; }
        public int idRepuesto { get; set; }

        public Repuestos repuestos { get; set; }
    }
}