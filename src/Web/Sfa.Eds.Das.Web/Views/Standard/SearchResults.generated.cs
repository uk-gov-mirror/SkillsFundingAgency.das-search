﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sfa.Eds.Das.Web.Views.Standard
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Sfa.Eds.Das.Web;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Standard/SearchResults.cshtml")]
    public partial class SearchResults : System.Web.Mvc.WebViewPage<Sfa.Eds.Das.Web.ViewModels.StandardSearchResultViewModel>
    {

#line 72 "..\..\Views\Standard\SearchResults.cshtml"
public System.Web.WebPages.HelperResult GetStandardDetailItem(string title, string item, string unit = "")
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 73 "..\..\Views\Standard\SearchResults.cshtml"
 
    if (!string.IsNullOrEmpty(item))
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <dt>");


#line 76 "..\..\Views\Standard\SearchResults.cshtml"
WriteTo(__razor_helper_writer, title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dt>\r\n");

WriteLiteralTo(__razor_helper_writer, "            <dd>");


#line 77 "..\..\Views\Standard\SearchResults.cshtml"
WriteTo(__razor_helper_writer, item);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " ");


#line 77 "..\..\Views\Standard\SearchResults.cshtml"
WriteTo(__razor_helper_writer, unit);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dd>\r\n");


#line 78 "..\..\Views\Standard\SearchResults.cshtml"
    }


#line default
#line hidden
});

#line 79 "..\..\Views\Standard\SearchResults.cshtml"
}
#line default
#line hidden

        public SearchResults()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Standard\SearchResults.cshtml"
  
    ViewBag.Title = "Search Results";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<main");

WriteLiteral(" id=\"content\"");

WriteLiteral(" role=\"main\"");

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 7 "..\..\Views\Standard\SearchResults.cshtml"
Write(Html.ActionLink("Search", "Search", null, new { @class = "link-back" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n    <div");

WriteLiteral(" id=\"results\"");

WriteLiteral(" class=\"grid-row\"");

WriteLiteral(">\r\n\r\n        <div");

WriteLiteral(" class=\"column-two-thirds\"");

WriteLiteral(">\r\n\r\n            <div");

WriteLiteral(" class=\"hgroup\"");

WriteLiteral(">\r\n\r\n                <h1");

WriteLiteral(" class=\"heading-xlarge\"");

WriteLiteral(">\r\n                    Search results\r\n                </h1>\r\n\r\n            </div" +
">\r\n            <p>\r\n");

            
            #line 20 "..\..\Views\Standard\SearchResults.cshtml"
                
            
            #line default
            #line hidden
            
            #line 20 "..\..\Views\Standard\SearchResults.cshtml"
                  
                    Html.RenderPartial("_SearchResultMessage");
                
            
            #line default
            #line hidden
WriteLiteral("\r\n            </p>\r\n");

            
            #line 24 "..\..\Views\Standard\SearchResults.cshtml"
                
            
            #line default
            #line hidden
            
            #line 24 "..\..\Views\Standard\SearchResults.cshtml"
                 foreach (var item in Model.Results)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <article");

WriteLiteral(" class=\"result\"");

WriteLiteral(">\r\n                        <header>\r\n                            <h2");

WriteLiteral(" class=\"result-title\"");

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 29 "..\..\Views\Standard\SearchResults.cshtml"
                           Write(Html.ActionLink(item.Title, "Detail", "Standard", new { @id = item.StandardId }, null));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </h2>\r\n                        </header>\r\n         " +
"                   ");

WriteLiteral("\r\n                            <dl");

WriteLiteral(" class=\"result-data-list\"");

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 39 "..\..\Views\Standard\SearchResults.cshtml"
                           Write(GetStandardDetailItem("Level:", item.NotionalEndLevel.ToString()));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                                ");

            
            #line 40 "..\..\Views\Standard\SearchResults.cshtml"
                           Write(GetStandardDetailItem("Typical length:", item.TypicalLengthMessage));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </dl>\r\n                    </article>\r\n");

            
            #line 43 "..\..\Views\Standard\SearchResults.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"column-third\"");

WriteLiteral(">\r\n\r\n            <div");

WriteLiteral(" class=\"related-container\"");

WriteLiteral(">\r\n                <aside");

WriteLiteral(" class=\"related\"");

WriteLiteral(" id=\"related\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"inner group related-subsection\"");

WriteLiteral(">\r\n\r\n                        <h2");

WriteLiteral(" id=\"parent-subsection\"");

WriteLiteral(">Help</h2>\r\n\r\n                        <ul");

WriteLiteral(" class=\"link-list\"");

WriteLiteral(">\r\n                            <li>\r\n                                <a");

WriteLiteral(" href=\"help_standards.html\"");

WriteLiteral(">What is a standard</a>\r\n                            </li>\r\n                     " +
"   </ul>\r\n\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"inner group\"");

WriteLiteral(">\r\n                        <a");

WriteLiteral(" class=\"return-to-top\"");

WriteLiteral(" href=\"#content\"");

WriteLiteral(">Return to top ↑</a>\r\n                    </div>\r\n                </aside>\r\n     " +
"       </div>\r\n\r\n        </div>\r\n    </div>\r\n</main>\r\n\r\n");

        }
    }
}
#pragma warning restore 1591
