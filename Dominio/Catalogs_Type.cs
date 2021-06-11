using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Dominio
{
    public class Catalogs_Type
    {
        [Key]
        public int idCatalogue { get; set; }    
        public int idMarca { get; set; }
        public string name { get; set; }
        public byte[] image { get; set; }
        public string description_image { get; set; }

        public Marcas marcas {get; set;}

        public ICollection<Catalogs> catalogs {get; set;}
    }
}