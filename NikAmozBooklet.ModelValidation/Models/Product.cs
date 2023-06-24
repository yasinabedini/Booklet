using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace NikAmozBooklet.ModelValidation.Models
{
    public class Product
    {
        public Product() { }

        [BindNever]
        public int Id { get; set; }

       
        [Remote("checkName", "Product",ErrorMessage ="نام کاربری اشتباه است.")]
        public string Name { get; set; }

        [Display(Name="قیمت محصول")]
        [Required(ErrorMessage = "این یک فیلد اجباری است")]
        [Range(5,1000)]
        public int Price { get; set; }
    }
}
