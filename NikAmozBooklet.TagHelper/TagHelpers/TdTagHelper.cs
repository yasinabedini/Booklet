using Microsoft.AspNetCore.Razor.TagHelpers;

namespace NikAmozBooklet.TagHelpers.TagHelpers
{
    public class TdTagHelper:TagHelper
    {

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var text = context.Items["Cell Text"].ToString();

            output.Content.Append(text);
        }
    }
}
