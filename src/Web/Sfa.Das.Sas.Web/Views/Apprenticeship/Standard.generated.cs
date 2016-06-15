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

namespace Sfa.Das.Sas.Web.Views.Apprenticeship
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
    
    #line 1 "..\..\Views\Apprenticeship\Standard.cshtml"
    using Sfa.Das.Sas.Resources;
    
    #line default
    #line hidden
    using Sfa.Das.Sas.Web;
    
    #line 2 "..\..\Views\Apprenticeship\Standard.cshtml"
    using Sfa.Das.Sas.Web.Extensions;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Apprenticeship/Standard.cshtml")]
    public partial class Standard : System.Web.Mvc.WebViewPage<Sfa.Das.Sas.Web.ViewModels.StandardViewModel>
    {

#line 77 "..\..\Views\Apprenticeship\Standard.cshtml"
public System.Web.WebPages.HelperResult GetStandardProperty(string title, string id, string item, bool hideIfEmpty = false)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 78 "..\..\Views\Apprenticeship\Standard.cshtml"
 
    if (!string.IsNullOrEmpty(item) || !hideIfEmpty)
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <dt>");


#line 81 "..\..\Views\Apprenticeship\Standard.cshtml"
WriteTo(__razor_helper_writer, title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dt>\r\n");

WriteLiteralTo(__razor_helper_writer, "        <dd");

WriteAttributeTo(__razor_helper_writer, "id", Tuple.Create(" id=\"", 3681), Tuple.Create("\"", 3689)

#line 82 "..\..\Views\Apprenticeship\Standard.cshtml"
, Tuple.Create(Tuple.Create("", 3686), Tuple.Create<System.Object, System.Int32>(id

#line default
#line hidden
, 3686), false)
);

WriteLiteralTo(__razor_helper_writer, ">");


#line 82 "..\..\Views\Apprenticeship\Standard.cshtml"
WriteTo(__razor_helper_writer, Html.MarkdownToHtml(item));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dd>\r\n");


#line 83 "..\..\Views\Apprenticeship\Standard.cshtml"
    }


#line default
#line hidden
});

#line 84 "..\..\Views\Apprenticeship\Standard.cshtml"
}
#line default
#line hidden

#line 86 "..\..\Views\Apprenticeship\Standard.cshtml"
public System.Web.WebPages.HelperResult GetDocumentItem(string pdfUrl, string title)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 87 "..\..\Views\Apprenticeship\Standard.cshtml"
 
    if (!string.IsNullOrEmpty(title))
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <li>\r\n            <a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 3867), Tuple.Create("\"", 3881)

#line 91 "..\..\Views\Apprenticeship\Standard.cshtml"
, Tuple.Create(Tuple.Create("", 3874), Tuple.Create<System.Object, System.Int32>(pdfUrl

#line default
#line hidden
, 3874), false)
);

WriteLiteralTo(__razor_helper_writer, " target=\"_blank\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n");

WriteLiteralTo(__razor_helper_writer, "                ");


#line 92 "..\..\Views\Apprenticeship\Standard.cshtml"
WriteTo(__razor_helper_writer, title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n            </a>\r\n        </li>\r\n");


#line 95 "..\..\Views\Apprenticeship\Standard.cshtml"
    }


#line default
#line hidden
});

#line 96 "..\..\Views\Apprenticeship\Standard.cshtml"
}
#line default
#line hidden

#line 98 "..\..\Views\Apprenticeship\Standard.cshtml"
public System.Web.WebPages.HelperResult GetShortlistLink(int id, bool isShortlisted)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 99 "..\..\Views\Apprenticeship\Standard.cshtml"
 
    if (isShortlisted)
    {
        

#line default
#line hidden

#line 102 "..\..\Views\Apprenticeship\Standard.cshtml"
WriteTo(__razor_helper_writer, Html.ActionLink("Remove from shortlist", "RemoveStandard", "ShortList", 
            new { id }, 
            new {@class= "link shortlist-link standard-shortlist-link", rel="nofollow", data_standard = id, data_action = "remove" }));


#line default
#line hidden

#line 104 "..\..\Views\Apprenticeship\Standard.cshtml"
                                                                                                                                     
    }
    else
    {
        

#line default
#line hidden

#line 108 "..\..\Views\Apprenticeship\Standard.cshtml"
WriteTo(__razor_helper_writer, Html.ActionLink("Shortlist apprenticeship", "AddStandard", "ShortList", 
            new { id }, 
            new { @class = "link shortlist-link standard-shortlist-link", rel="nofollow", data_standard = id, data_action = "add" }));


#line default
#line hidden

#line 110 "..\..\Views\Apprenticeship\Standard.cshtml"
                                                                                                                                    
    }


#line default
#line hidden
});

#line 112 "..\..\Views\Apprenticeship\Standard.cshtml"
}
#line default
#line hidden

        public Standard()
        {
        }
        public override void Execute()
        {
            
            #line 5 "..\..\Views\Apprenticeship\Standard.cshtml"
  
    ViewBag.Title = "Standard - " + @Model.Title;

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<main");

WriteLiteral(" id=\"content\"");

WriteLiteral(" class=\"standard-detail\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"grid-row\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"column-two-thirds\"");

WriteLiteral(">\r\n            <div>\r\n                <h1");

WriteLiteral(" class=\"heading-xlarge\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 14 "..\..\Views\Apprenticeship\Standard.cshtml"
               Write(Model.Title);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </h1>\r\n                <div");

WriteLiteral(" class=\"standard-result-summary\"");

WriteLiteral(">\r\n                    This is an apprenticeship standard developed by a group of" +
" employers. It sets out what the apprentice needs to achieve and how they will b" +
"e assessed.\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n     " +
"   <div");

WriteLiteral(" class=\"column-third\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"related-container\"");

WriteLiteral(">\r\n                <aside");

WriteLiteral(" class=\"hidden-for-tablet\"");

WriteLiteral(">\r\n\r\n                    <a");

WriteLiteral(" class=\"button ui-find-training-providers\"");

WriteAttribute("href", Tuple.Create(" href=\"", 901), Tuple.Create("\"", 1027)
            
            #line 26 "..\..\Views\Apprenticeship\Standard.cshtml"
, Tuple.Create(Tuple.Create("", 908), Tuple.Create<System.Object, System.Int32>(Url.Action("SearchForProviders", "Apprenticeship", new { standardId = Model.StandardId, keywords = Model.SearchTerm })
            
            #line default
            #line hidden
, 908), false)
);

WriteLiteral(">\r\n                        <i");

WriteLiteral(" class=\"fa fa-search\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral("></i>\r\n                        Find training Providers\r\n                    </a>\r" +
"\n                    ");

WriteLiteral("\r\n                </aside>\r\n                 </div>\r\n\r\n            </div>\r\n      " +
"  </div>\r\n\r\n        <section>\r\n            <header>\r\n                <h2");

WriteLiteral(" class=\"heading-large\"");

WriteLiteral(">\r\n                    Summary of this apprenticeship standard\r\n                <" +
"/h2>\r\n            </header>\r\n            <dl");

WriteLiteral(" class=\"data-list\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 44 "..\..\Views\Apprenticeship\Standard.cshtml"
           Write(GetStandardProperty("Overview of role", "overview", Model.OverviewOfRole));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 45 "..\..\Views\Apprenticeship\Standard.cshtml"
           Write(GetStandardProperty("Level", "level", $"{@Model.NotionalEndLevel} (equivalent to {@EquivalenveLevelService.GetApprenticeshipLevel(Model.NotionalEndLevel.ToString())})"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 46 "..\..\Views\Apprenticeship\Standard.cshtml"
           Write(GetStandardProperty("Typical length", "length", @Model.TypicalLengthMessage));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 47 "..\..\Views\Apprenticeship\Standard.cshtml"
           Write(GetStandardProperty("Entry requirements", "entry-requirements", Model.EntryRequirements));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 48 "..\..\Views\Apprenticeship\Standard.cshtml"
           Write(GetStandardProperty("What apprentices will learn", "will-learn", Model.WhatApprenticesWillLearn));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 49 "..\..\Views\Apprenticeship\Standard.cshtml"
           Write(GetStandardProperty("Qualifications", "qualifications", Model.Qualifications));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 50 "..\..\Views\Apprenticeship\Standard.cshtml"
           Write(GetStandardProperty("Professional registration", "professional-registration", Model.ProfessionalRegistration, true));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </dl>\r\n\r\n");

            
            #line 53 "..\..\Views\Apprenticeship\Standard.cshtml"
            
            
            #line default
            #line hidden
            
            #line 53 "..\..\Views\Apprenticeship\Standard.cshtml"
             if (!string.IsNullOrEmpty($"{Model.AssessmentPlanPdfUrlTitle}{Model.StandardPdfUrlTitle}"))
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"panel-indent panel-indent-info\"");

WriteLiteral(">\r\n                    <h2");

WriteLiteral(" class=\"heading-large\"");

WriteLiteral(">\r\n                        Documents\r\n                    </h2>\r\n                " +
"    <ul>\r\n");

WriteLiteral("                        ");

            
            #line 60 "..\..\Views\Apprenticeship\Standard.cshtml"
                   Write(GetDocumentItem(@Model.StandardPdf, "Standard"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                        ");

            
            #line 61 "..\..\Views\Apprenticeship\Standard.cshtml"
                   Write(GetDocumentItem(@Model.AssessmentPlanPdf, "Assessment Plan"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </ul>\r\n                </div>\r\n");

            
            #line 64 "..\..\Views\Apprenticeship\Standard.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("\r\n            <hr/>\r\n            <div");

WriteLiteral(" id=\"bottom-actions\"");

WriteLiteral(">\r\n                <a");

WriteLiteral(" class=\"button ui-find-training-providers\"");

WriteAttribute("href", Tuple.Create(" href=\"", 3095), Tuple.Create("\"", 3221)
            
            #line 68 "..\..\Views\Apprenticeship\Standard.cshtml"
, Tuple.Create(Tuple.Create("", 3102), Tuple.Create<System.Object, System.Int32>(Url.Action("SearchForProviders", "Apprenticeship", new { standardId = Model.StandardId, keywords = Model.SearchTerm })
            
            #line default
            #line hidden
, 3102), false)
);

WriteLiteral(">\r\n                    <i");

WriteLiteral(" class=\"fa fa-search\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral("></i>\r\n                    Find training Providers\r\n                </a>\r\n       " +
"         ");

WriteLiteral("\r\n            </div>\r\n    </section>\r\n</main>\r\n\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
