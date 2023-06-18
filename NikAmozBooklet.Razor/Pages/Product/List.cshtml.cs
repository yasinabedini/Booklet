using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NikAmozBooklet.Razor.Models;


namespace NikAmozBooklet.Razor.Pages.Product
{
    public class ListModel : PageModel
    {
        public List<Person> People { get; set; }



        public void OnGet()
        {
            this.People = new List<Person>()
            {
                 new Person("yasin",18),
                new Person("afaz",19),
                new Person("hadi",12)
            };
        }
    }
}
