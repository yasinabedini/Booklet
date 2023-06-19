using Microsoft.AspNetCore.Razor.TagHelpers;

namespace NikAmozBooklet.TagHelpers.TagHelpers
{
    public class TrTagHelper:TagHelper
    {
        public string CellText { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            //share information from child and parent
            context.Items["Cell Text"] = CellText;
        }

    }
}
