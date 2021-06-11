using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Dominio
{
    public class Products_Type
    {
        [Key]
        public int idProductType { get; set; }
        public string name { get; set; }
        public byte[] image { get; set; }
        public string description { get; set; }

        public ICollection<Products> products { get; set;}
    }
}