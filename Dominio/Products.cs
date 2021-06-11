using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Dominio
{
    public class Products
    {
        [Key]
        public int idProducts {get; set;}
        public string price { get; set; }
        public string model { get; set; }   
        public string status { get; set; }
        public string delivery { get; set; }
        public int idCondition { get; set; }
        public string description { get; set; }
        public byte[] cover_image { get; set; }
        public int idStatus { get; set; }
        public int idTipo { get; set; }

        public Conditions conditions { get; set;}
        public Status estado { get; set; }
        public Products_Type products_Type { get; set; }

        public ICollection<Products_Gallery> galleries { get; set; }

    }
}