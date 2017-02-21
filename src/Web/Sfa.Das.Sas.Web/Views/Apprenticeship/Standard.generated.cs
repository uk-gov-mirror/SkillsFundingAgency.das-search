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
    
    #line 1 "..\..\Views\Apprenticeship\Standard.cshtml"
    using System.Globalization;
    
    #line default
    #line hidden
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
    
    #line 2 "..\..\Views\Apprenticeship\Standard.cshtml"
    using Sfa.Das.Sas.Resources;
    
    #line default
    #line hidden
    using Sfa.Das.Sas.Web;
    
    #line 3 "..\..\Views\Apprenticeship\Standard.cshtml"
    using Sfa.Das.Sas.Web.Extensions;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Apprenticeship/Standard.cshtml")]
    public partial class Standard : System.Web.Mvc.WebViewPage<Sfa.Das.Sas.Web.ViewModels.StandardViewModel>
    {

#line 60 "..\..\Views\Apprenticeship\Standard.cshtml"
public System.Web.WebPages.HelperResult GetStandardProperty(string title, string id, string item, bool hideIfEmpty = false)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 61 "..\..\Views\Apprenticeship\Standard.cshtml"
 
if (!string.IsNullOrEmpty(item) || !hideIfEmpty)
{


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <dt>");


#line 64 "..\..\Views\Apprenticeship\Standard.cshtml"
WriteTo(__razor_helper_writer, title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dt>\n");

WriteLiteralTo(__razor_helper_writer, "    <dd");

WriteAttributeTo(__razor_helper_writer, "id", Tuple.Create(" id=\"", 2953), Tuple.Create("\"", 2961)

#line 65 "..\..\Views\Apprenticeship\Standard.cshtml"
, Tuple.Create(Tuple.Create("", 2958), Tuple.Create<System.Object, System.Int32>(id

#line default
#line hidden
, 2958), false)
);

WriteLiteralTo(__razor_helper_writer, ">");


#line 65 "..\..\Views\Apprenticeship\Standard.cshtml"
WriteTo(__razor_helper_writer, Html.MarkdownToHtml(item));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dd>\n");


#line 66 "..\..\Views\Apprenticeship\Standard.cshtml"
}


#line default
#line hidden
});

#line 67 "..\..\Views\Apprenticeship\Standard.cshtml"
}
#line default
#line hidden

#line 69 "..\..\Views\Apprenticeship\Standard.cshtml"
public System.Web.WebPages.HelperResult GetFundingBandProperty(int value)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 70 "..\..\Views\Apprenticeship\Standard.cshtml"
 
var fundingCapFormatted = value.ToString("C0", CultureInfo.CurrentCulture);



#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <dt>Funding cap<br />(from 1 May 2017)</dt>\n");

WriteLiteralTo(__razor_helper_writer, "    <dd");

WriteLiteralTo(__razor_helper_writer, " id=\"funding-cap\"");

WriteLiteralTo(__razor_helper_writer, ">\n        Up to ");


#line 75 "..\..\Views\Apprenticeship\Standard.cshtml"
WriteTo(__razor_helper_writer, fundingCapFormatted);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " per apprentice.<br />\n        <a");

WriteLiteralTo(__razor_helper_writer, " href=\"https://www.gov.uk/government/publications/apprenticeship-levy-how-it-will" +
"-work/apprenticeship-levy-how-it-will-work#buying-apprenticeship-training-and-as" +
"sessment\"");

WriteLiteralTo(__razor_helper_writer, " target=\"_blank\"");

WriteLiteralTo(__razor_helper_writer, ">More information about funding</a>\n    </dd>\n");


#line 78 "..\..\Views\Apprenticeship\Standard.cshtml"


#line default
#line hidden
});

#line 78 "..\..\Views\Apprenticeship\Standard.cshtml"
}
#line default
#line hidden

#line 80 "..\..\Views\Apprenticeship\Standard.cshtml"
public System.Web.WebPages.HelperResult GetDocumentItem(string pdfUrl, string title)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 81 "..\..\Views\Apprenticeship\Standard.cshtml"
 
if (!string.IsNullOrEmpty(title))
{


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <li>\n            <a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 3615), Tuple.Create("\"", 3629)

#line 85 "..\..\Views\Apprenticeship\Standard.cshtml"
, Tuple.Create(Tuple.Create("", 3622), Tuple.Create<System.Object, System.Int32>(pdfUrl

#line default
#line hidden
, 3622), false)
);

WriteLiteralTo(__razor_helper_writer, " target=\"_blank\"");

WriteLiteralTo(__razor_helper_writer, ">\n");

WriteLiteralTo(__razor_helper_writer, "                ");


#line 86 "..\..\Views\Apprenticeship\Standard.cshtml"
WriteTo(__razor_helper_writer, title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\n            </a>\n        </li>\n");


#line 89 "..\..\Views\Apprenticeship\Standard.cshtml"
}


#line default
#line hidden
});

#line 90 "..\..\Views\Apprenticeship\Standard.cshtml"
}
#line default
#line hidden

        public Standard()
        {
        }
        public override void Execute()
        {
            
            #line 5 "..\..\Views\Apprenticeship\Standard.cshtml"
  
    ViewBag.Title = Model.Title + " - Apprenticeship Standard";
    ViewBag.Description = Model.OverviewOfRole;

            
            #line default
            #line hidden
WriteLiteral("\n<main");

WriteLiteral(" id=\"content\"");

WriteLiteral(" class=\"standard-detail\"");

WriteLiteral(">\n    <div");

WriteLiteral(" class=\"grid-row\"");

WriteLiteral(">\n        <div");

WriteLiteral(" class=\"column-two-thirds\"");

WriteLiteral(">\n            <div>\n                <h1");

WriteLiteral(" class=\"heading-xlarge\"");

WriteLiteral(">\n");

WriteLiteral("                    ");

            
            #line 14 "..\..\Views\Apprenticeship\Standard.cshtml"
               Write(Model.Title);

            
            #line default
            #line hidden
WriteLiteral("\n                </h1>\n                <p");

WriteLiteral(" class=\"lede\"");

WriteLiteral(">");

            
            #line 16 "..\..\Views\Apprenticeship\Standard.cshtml"
                           Write(Model.OverviewOfRole);

            
            #line default
            #line hidden
WriteLiteral("</p>\n            </div>\n        </div>\n        <div");

WriteLiteral(" class=\"column-third\"");

WriteLiteral(">\n            <div");

WriteLiteral(" class=\"related-container\"");

WriteLiteral(">\n                <aside");

WriteLiteral(" class=\"hidden-for-mobile-tablet\"");

WriteLiteral(">\n                    <a");

WriteLiteral(" class=\"button ui-find-training-providers\"");

WriteLiteral(" rel=\"nofollow\"");

WriteLiteral(" id=\"ga-find-provider-top\"");

WriteAttribute("href", Tuple.Create(" href=\"", 821), Tuple.Create("\"", 955)
            
            #line 22 "..\..\Views\Apprenticeship\Standard.cshtml"
                                 , Tuple.Create(Tuple.Create("", 828), Tuple.Create<System.Object, System.Int32>(Url.Action("SearchForStandardProviders", "Apprenticeship", new { standardId = Model.StandardId, keywords = Model.SearchTerm })
            
            #line default
            #line hidden
, 828), false)
);

WriteLiteral(">\n                        Find training providers\n                    </a>\n      " +
"          </aside>\n            </div>\n        </div>\n    </div>\n    <section>\n  " +
"      <header>\n            <h2");

WriteLiteral(" class=\"heading-large\"");

WriteLiteral(">\n                Summary of this apprenticeship standard\n            </h2>\n     " +
"   </header>\n        <dl");

WriteLiteral(" class=\"data-list\"");

WriteLiteral(">\n");

WriteLiteral("            ");

            
            #line 36 "..\..\Views\Apprenticeship\Standard.cshtml"
       Write(GetStandardProperty("Level", "level", $"{@Model.Level} (equivalent to {EquivalenceLevelService.GetApprenticeshipLevel(Model.Level.ToString())})"));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("            ");

            
            #line 37 "..\..\Views\Apprenticeship\Standard.cshtml"
       Write(GetFundingBandProperty(Model.MaxFunding));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("            ");

            
            #line 38 "..\..\Views\Apprenticeship\Standard.cshtml"
       Write(GetStandardProperty("Typical length", "length", @Model.TypicalLengthMessage));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("            ");

            
            #line 39 "..\..\Views\Apprenticeship\Standard.cshtml"
       Write(GetStandardProperty("Entry requirements", "entry-requirements", Model.EntryRequirements));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("            ");

            
            #line 40 "..\..\Views\Apprenticeship\Standard.cshtml"
       Write(GetStandardProperty("What apprentices will learn", "will-learn", Model.WhatApprenticesWillLearn));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("            ");

            
            #line 41 "..\..\Views\Apprenticeship\Standard.cshtml"
       Write(GetStandardProperty("Qualifications", "qualifications", Model.Qualifications));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("            ");

            
            #line 42 "..\..\Views\Apprenticeship\Standard.cshtml"
       Write(GetStandardProperty("Professional registration", "professional-registration", Model.ProfessionalRegistration, true));

            
            #line default
            #line hidden
WriteLiteral("\n            <dt>Documents</dt>\n            <dd>\n                <div");

WriteLiteral(" class=\"panel-indent panel-indent-info document-list\"");

WriteLiteral(">\n                    <ul>\n");

WriteLiteral("                        ");

            
            #line 47 "..\..\Views\Apprenticeship\Standard.cshtml"
                   Write(GetDocumentItem(Model.StandardPdf, "Standard"));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("                        ");

            
            #line 48 "..\..\Views\Apprenticeship\Standard.cshtml"
                   Write(GetDocumentItem(Model.AssessmentPlanPdf, "Assessment Plan"));

            
            #line default
            #line hidden
WriteLiteral("\n                    </ul>\n                </div>\n            </dd>\n        </dl>" +
"\n        <div");

WriteLiteral(" id=\"bottom-actions\"");

WriteLiteral(">\n            <a");

WriteLiteral(" class=\"button ui-find-training-providers\"");

WriteLiteral(" rel=\"nofollow\"");

WriteLiteral(" id=\"ga-find-provider-bottom\"");

WriteAttribute("href", Tuple.Create(" href=\"", 2549), Tuple.Create("\"", 2683)
            
            #line 54 "..\..\Views\Apprenticeship\Standard.cshtml"
                           , Tuple.Create(Tuple.Create("", 2556), Tuple.Create<System.Object, System.Int32>(Url.Action("SearchForStandardProviders", "Apprenticeship", new { standardId = Model.StandardId, keywords = Model.SearchTerm })
            
            #line default
            #line hidden
, 2556), false)
);

WriteLiteral(">\n                Find training providers\n            </a>\n        </div>\n    </s" +
"ection>\n</main>\n");

WriteLiteral("\n");

WriteLiteral("\n");

        }
    }
}
#pragma warning restore 1591
