using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace NikAmozBooklet.ModelBinding.Models
{
    public class Product
    {
        [BindNever]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
