using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class Catalogs
    {
        [Key]
        public int idMaquinaNueva { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public byte[] image { get; set; }
        public string archive { get; set; }
        public int idMarca { get; set; }
        public int idTipo { get; set; }

        public Marcas marcas {get; set;}
        public Catalogs_Type catalogs_Type {get; set;}
    }
}