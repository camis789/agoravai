using System;
using System.ComponentModel.DataAnnotations;

namespace SisProdutos.models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        public virtual Category Category { get; set; }
        public DateTime DateCreate { get; set; }
    }
}
