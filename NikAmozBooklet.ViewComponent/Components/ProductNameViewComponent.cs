using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace NikAmozBookletViewComponent.Components
{
    public class ProductNameViewComponent : ViewComponent
    {     
        public ViewViewComponentResult Invoke(string viewName)
        {
            SortedList<string, string> prLst = new SortedList<string, string>();
            prLst.Add("Product1", "Mobile");
            prLst.Add("Product2", "Tablet");
            prLst.Add("Product3", "Hedphone");

            return View(viewName,prLst);
        }
    }
}
