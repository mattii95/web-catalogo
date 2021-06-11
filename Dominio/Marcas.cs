using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Dominio
{
    public class Marcas
    {
        [Key]
        public int idMarca { get; set; }
        public string name { get; set; }
        public byte[] logo { get; set; }
        public string description_logo { get; set; }    
        public int idTipo { get; set; }

        public Marcas_Types marcas_Types {get; set;}
        public ICollection<Catalogs> catalogs {get; set;}
        public ICollection<Catalogs_Type> catalogs_Types {get; set;}
        public ICollection<Products> products {get; set;}
        public ICollection<Repuestos> repuestos {get; set;}

    }
}