using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Dominio
{
    public class Conditions
    {
        [Key]
        public int idCondition { get; set; }
        public string name { get; set; }

        public ICollection<Products> products { get; set; }
    }
}