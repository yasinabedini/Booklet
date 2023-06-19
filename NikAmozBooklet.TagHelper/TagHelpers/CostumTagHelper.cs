using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace NikAmozBooklet.TagHelpers.TagHelpers
{
    public class CostumTagHelper:TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "Pro";
            output.Content.Append("this Tag Write By Yasin Abedini");

            //<h1> this is header text </h1>
            TagBuilder h1 = new TagBuilder("h1");
            h1.InnerHtml.Append("this is header text");
            output.PostContent.AppendHtml(h1);

        }
    }
}
