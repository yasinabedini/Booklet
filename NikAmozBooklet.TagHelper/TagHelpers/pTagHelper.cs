using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace NikAmozBooklet.TagHelpers.TagHelpers
{
    [HtmlTargetElement("p", ParentTag = "div", Attributes = "active")]
    [HtmlTargetElement("a", ParentTag = "div", Attributes = "active")]
    //[HtmlTargetElement("*")]
    public class pTagHelper : TagHelper
    {
        public string paramColor { get; set; } = "Info";

        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewContext { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (!ViewContext.HttpContext.User.IsInRole("admin"))
            {
                output.SuppressOutput();
            }
            output.PreElement.Append("Before P Tag");
            output.PreContent.Append("After Child Of Div");
            output.PreContent.AppendHtml("<br/>");
            output.Content.Append("Child Of Div");
            output.PostContent.Append("After Child Of Div");
            output.PostElement.Append("After P Tag");
            output.Attributes.Add("class", $"text-{paramColor} p-3");


        }
    }
}
