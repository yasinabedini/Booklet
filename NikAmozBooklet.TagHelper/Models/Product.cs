using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace NikAmozBooklet.TagHelpers.Models
{
    public class Product
    {
        public Product() { }

        public int Id { get; set; }

        [Required]        
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
