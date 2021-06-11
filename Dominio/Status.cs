using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Dominio
{
    public class Status
    {
        [Key]
        public int idStatus { get; set; }
        public string name { get; set; }

        public ICollection<Products> products { get; set; }
    }
}