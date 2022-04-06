using INTEX_2.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace INTEX_2.Infrastructure
{
    [HtmlTargetElement("div", Attributes = "page-model")]
    public class PaginationTagHelper : TagHelper
    {
        //Dyanmically create the page links for us

        private IUrlHelperFactory uhf;
        public PaginationTagHelper (IUrlHelperFactory temp)
        {
            uhf = temp;
        }

        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext vc { get; set; }
        public PageInfo PageModel { get; set; }
        public string PageAction { get; set; }
        public override void Process(TagHelperContext thc, TagHelperOutput tho)
        {
            IUrlHelper uh = uhf.GetUrlHelper(vc);
            TagBuilder final = new TagBuilder("div");
            for (int i = PageModel.CurrentPage - 3; i <= PageModel.CurrentPage + 3; i++)
            {
                if (i <= 0)
                {
                    continue;
                }
                else
                {
                    TagBuilder tb = new TagBuilder("a");
                    tb.MergeAttribute("role", "button");
                    tb.MergeAttribute("class", "btn btn-primary");
                    tb.Attributes["href"] = uh.Action(PageAction, new { pageNum = i });
                    tb.InnerHtml.Append(i.ToString());

                    final.InnerHtml.AppendHtml(tb);
                }
               
            }

            tho.Content.AppendHtml(final.InnerHtml);
        }
    }
}
