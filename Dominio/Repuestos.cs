using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Dominio
{
    public class Repuestos
    {
        [Key]
        public int idRpuesto { get; set; }
        public string name { get; set; }
        public int idMarca { get; set; }
        public int description { get; set; }
        public byte[] image { get; set; }
        public string image_desc { get; set; }

        public Marcas marcas { get; set; }

        public ICollection<Repuesto_Gallery> galleries { get; set; }
    }
}