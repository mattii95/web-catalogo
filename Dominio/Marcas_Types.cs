using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Dominio
{
    public class Marcas_Types
    {
        [Key]
        public int idMarcaType { get; set; }
        public string name { get; set; }

        public ICollection<Marcas> marcas {get; set;}
    }
}