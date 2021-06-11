using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class Products_Gallery
    {
        [Key]
        public int idGallery { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public byte[] image { get; set; }
        public int idProduct { get; set; }

        public Products products { get; set;}
        
    }
}