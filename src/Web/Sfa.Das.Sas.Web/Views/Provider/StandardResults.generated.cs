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

namespace Sfa.Das.Sas.Web.Views.Provider
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
    using Sfa.Das.Sas.Web;
    
    #line 1 "..\..\Views\Provider\StandardResults.cshtml"
    using Sfa.Das.Sas.Web.Extensions;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Provider\StandardResults.cshtml"
    using Sfa.Das.Sas.Web.ViewModels;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Provider/StandardResults.cshtml")]
    public partial class StandardResults : System.Web.Mvc.WebViewPage<ProviderStandardSearchResultViewModel>
    {

#line 100 "..\..\Views\Provider\StandardResults.cshtml"
public System.Web.WebPages.HelperResult GetPaginationBackLink()
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 101 "..\..\Views\Provider\StandardResults.cshtml"
 
if (Model.ActualPage > 1)
{
    var previousPage = @Model.ActualPage - 1;
    var url = @Url.Action("StandardResults", "Provider", GetNavigationRouteValues(previousPage, Model.DeliveryModes), null);

        

#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "<a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 4663), Tuple.Create("\"", 4674)

#line 107 "..\..\Views\Provider\StandardResults.cshtml"
, Tuple.Create(Tuple.Create("", 4670), Tuple.Create<System.Object, System.Int32>(url

#line default
#line hidden
, 4670), false)
);

WriteLiteralTo(__razor_helper_writer, " style=\"visibility: visible\"");

WriteLiteralTo(__razor_helper_writer, " class=\"page-navigation__btn prev\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n            <i");

WriteLiteralTo(__razor_helper_writer, " class=\"arrow-button fa fa-angle-left\"");

WriteLiteralTo(__razor_helper_writer, "></i>\r\n            <span");

WriteLiteralTo(__razor_helper_writer, " class=\"description\"");

WriteLiteralTo(__razor_helper_writer, ">Previous <span");

WriteLiteralTo(__razor_helper_writer, " class=\"hide-mob\"");

WriteLiteralTo(__razor_helper_writer, ">page</span></span>\r\n            <span");

WriteLiteralTo(__razor_helper_writer, " class=\"counter\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 110 "..\..\Views\Provider\StandardResults.cshtml"
    WriteTo(__razor_helper_writer, previousPage);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " of ");


#line 110 "..\..\Views\Provider\StandardResults.cshtml"
                     WriteTo(__razor_helper_writer, Model.LastPage);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</span>\r\n        </a>\r\n");


#line 112 "..\..\Views\Provider\StandardResults.cshtml"
}


#line default
#line hidden
});

#line 113 "..\..\Views\Provider\StandardResults.cshtml"
}
#line default
#line hidden

#line 115 "..\..\Views\Provider\StandardResults.cshtml"
public System.Web.WebPages.HelperResult GetPaginationNextLink()
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 116 "..\..\Views\Provider\StandardResults.cshtml"
 
if (Model.ActualPage < Model.LastPage)
{
    var nextPage = @Model.ActualPage + 1;

    var url = @Url.Action("StandardResults", "Provider", GetNavigationRouteValues(nextPage, Model.DeliveryModes), null);
        

#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "<a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 5242), Tuple.Create("\"", 5253)

#line 122 "..\..\Views\Provider\StandardResults.cshtml"
, Tuple.Create(Tuple.Create("", 5249), Tuple.Create<System.Object, System.Int32>(url

#line default
#line hidden
, 5249), false)
);

WriteLiteralTo(__razor_helper_writer, " style=\"visibility: visible\"");

WriteLiteralTo(__razor_helper_writer, " class=\"page-navigation__btn next\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n            <i");

WriteLiteralTo(__razor_helper_writer, " class=\"arrow-button fa fa-angle-right\"");

WriteLiteralTo(__razor_helper_writer, "></i>\r\n            <span");

WriteLiteralTo(__razor_helper_writer, " class=\"description\"");

WriteLiteralTo(__razor_helper_writer, ">Next <span");

WriteLiteralTo(__razor_helper_writer, " class=\"hide-mob\"");

WriteLiteralTo(__razor_helper_writer, ">page</span></span>\r\n            <span");

WriteLiteralTo(__razor_helper_writer, " class=\"counter\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 125 "..\..\Views\Provider\StandardResults.cshtml"
    WriteTo(__razor_helper_writer, nextPage);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " of ");


#line 125 "..\..\Views\Provider\StandardResults.cshtml"
                 WriteTo(__razor_helper_writer, Model.LastPage);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</span>\r\n        </a>\r\n");


#line 127 "..\..\Views\Provider\StandardResults.cshtml"
}


#line default
#line hidden
});

#line 128 "..\..\Views\Provider\StandardResults.cshtml"
}
#line default
#line hidden

#line 130 "..\..\Views\Provider\StandardResults.cshtml"
public System.Web.WebPages.HelperResult FilterForm(string cssClass)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 131 "..\..\Views\Provider\StandardResults.cshtml"
 
if (!Model.DeliveryModes.IsNullOrEmpty())
{
    var hideMenu = Model.DeliveryModes.All(deliveryMode => deliveryMode.Count == 0);

    if (@Model.TotalResults != 0 || !hideMenu)
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <div");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 5803), Tuple.Create("\"", 5820)

#line 138 "..\..\Views\Provider\StandardResults.cshtml"
, Tuple.Create(Tuple.Create("", 5811), Tuple.Create<System.Object, System.Int32>(cssClass

#line default
#line hidden
, 5811), false)
);

WriteLiteralTo(__razor_helper_writer, ">\r\n                <form");

WriteLiteralTo(__razor_helper_writer, " method=\"get\"");

WriteLiteralTo(__razor_helper_writer, " autocomplete=\"off\"");

WriteAttributeTo(__razor_helper_writer, "action", Tuple.Create(" action=\"", 5877), Tuple.Create("\"", 5905)

#line 139 "..\..\Views\Provider\StandardResults.cshtml"
, Tuple.Create(Tuple.Create("", 5886), Tuple.Create<System.Object, System.Int32>(Model.AbsolutePath

#line default
#line hidden
, 5886), false)
);

WriteLiteralTo(__razor_helper_writer, ">\r\n                    <input");

WriteLiteralTo(__razor_helper_writer, " type=\"hidden\"");

WriteLiteralTo(__razor_helper_writer, " name=\"PostCode\"");

WriteAttributeTo(__razor_helper_writer, "value", Tuple.Create(" value=\"", 5965), Tuple.Create("\"", 6005)

#line 140 "..\..\Views\Provider\StandardResults.cshtml"
, Tuple.Create(Tuple.Create("", 5973), Tuple.Create<System.Object, System.Int32>(Model.PostCode.FormatPostcode()

#line default
#line hidden
, 5973), false)
);

WriteLiteralTo(__razor_helper_writer, " />\r\n                    <input");

WriteLiteralTo(__razor_helper_writer, " type=\"hidden\"");

WriteLiteralTo(__razor_helper_writer, " name=\"apprenticeshipid\"");

WriteAttributeTo(__razor_helper_writer, "value", Tuple.Create(" value=\"", 6075), Tuple.Create("\"", 6100)

#line 141 "..\..\Views\Provider\StandardResults.cshtml"
, Tuple.Create(Tuple.Create("", 6083), Tuple.Create<System.Object, System.Int32>(Model.StandardId

#line default
#line hidden
, 6083), false)
);

WriteLiteralTo(__razor_helper_writer, " />\r\n                    <input");

WriteLiteralTo(__razor_helper_writer, " type=\"hidden\"");

WriteLiteralTo(__razor_helper_writer, " name=\"showAll\"");

WriteAttributeTo(__razor_helper_writer, "value", Tuple.Create(" value=\"", 6161), Tuple.Create("\"", 6194)

#line 142 "..\..\Views\Provider\StandardResults.cshtml"
, Tuple.Create(Tuple.Create("", 6169), Tuple.Create<System.Object, System.Int32>(Model.ShowAll.ToString()

#line default
#line hidden
, 6169), false)
);

WriteLiteralTo(__razor_helper_writer, " />\r\n                    <input");

WriteLiteralTo(__razor_helper_writer, " type=\"hidden\"");

WriteLiteralTo(__razor_helper_writer, " name=\"isLevyPayingEmployer\"");

WriteAttributeTo(__razor_helper_writer, "value", Tuple.Create(" value=\"", 6268), Tuple.Create("\"", 6314)

#line 143 "..\..\Views\Provider\StandardResults.cshtml"
, Tuple.Create(Tuple.Create("", 6276), Tuple.Create<System.Object, System.Int32>(Model.IsLevyPayingEmployer.ToString()

#line default
#line hidden
, 6276), false)
);

WriteLiteralTo(__razor_helper_writer, " />\r\n                    <input");

WriteLiteralTo(__razor_helper_writer, " type=\"hidden\"");

WriteLiteralTo(__razor_helper_writer, " name=\"keywords\"");

WriteAttributeTo(__razor_helper_writer, "value", Tuple.Create(" value=\"", 6376), Tuple.Create("\"", 6402)

#line 144 "..\..\Views\Provider\StandardResults.cshtml"
, Tuple.Create(Tuple.Create("", 6384), Tuple.Create<System.Object, System.Int32>(Model.SearchTerms

#line default
#line hidden
, 6384), false)
);

WriteLiteralTo(__razor_helper_writer, " />\r\n\r\n");


#line 146 "..\..\Views\Provider\StandardResults.cshtml"
                    

#line default
#line hidden

#line 146 "..\..\Views\Provider\StandardResults.cshtml"
                      
                        Html.RenderPartial("_FilterProviders", Model.DeliveryModes);
                    

#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n");


#line 149 "..\..\Views\Provider\StandardResults.cshtml"
                    

#line default
#line hidden

#line 149 "..\..\Views\Provider\StandardResults.cshtml"
                      
                        Html.RenderPartial("_FilterNationalProviders", Model.NationalProviders);
                    

#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n                    <input");

WriteLiteralTo(__razor_helper_writer, " type=\"submit\"");

WriteLiteralTo(__razor_helper_writer, " value=\"Update results\"");

WriteLiteralTo(__razor_helper_writer, " class=\"button margin-top-x2 postcode-search-button\"");

WriteLiteralTo(__razor_helper_writer, " />\r\n                </form>\r\n            </div>\r\n");


#line 155 "..\..\Views\Provider\StandardResults.cshtml"
                            }
                        }


#line default
#line hidden
});

#line 157 "..\..\Views\Provider\StandardResults.cshtml"
}
#line default
#line hidden

        #line 160 "..\..\Views\Provider\StandardResults.cshtml"
 
    RouteValueDictionary GetNavigationRouteValues(int page, IEnumerable<DeliveryModeViewModel> deliveryModes)
    {

        var rv = new RouteValueDictionary { { "apprenticeshipid", Model.StandardId }, { "postcode", Model.PostCode.FormatPostcode() }, { "page", page }, { "showall", Model.ShowAll }, { "isLevyPayingEmployer", Model.IsLevyPayingEmployer } };
        int i = 0;
        foreach (var deliveryMode in deliveryModes.Where(m => m.Checked))
        {
            rv.Add("DeliveryModes[" + i + "]", deliveryMode.Value);
            i++;
        }

        if (Model.ShowNationalProviders)
        {
            rv.Add("NationalProvidersOnly", true);
        }

        return rv;
    }

        #line default
        #line hidden
        
        public StandardResults()
        {
        }
        public override void Execute()
        {
            
            #line 5 "..\..\Views\Provider\StandardResults.cshtml"
  
    ViewBag.Title = "Provider Search Results";
    ViewBag.Description = "The Find Apprenticeship Training service is for employers in England who want to find training courses for their apprentices and search for training providers.";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<main");

WriteLiteral(" id=\"content\"");

WriteLiteral(" role=\"main\"");

WriteLiteral(">\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteAttribute("value", Tuple.Create(" value=\"", 422), Tuple.Create("\"", 462)
            
            #line 11 "..\..\Views\Provider\StandardResults.cshtml"
, Tuple.Create(Tuple.Create("", 430), Tuple.Create<System.Object, System.Int32>(Model.PostCode.FormatPostcode()
            
            #line default
            #line hidden
, 430), false)
);

WriteLiteral(" id=\"ga-postcode\"");

WriteLiteral(" />\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteAttribute("value", Tuple.Create(" value=\"", 509), Tuple.Create("\"", 564)
            
            #line 12 "..\..\Views\Provider\StandardResults.cshtml"
, Tuple.Create(Tuple.Create("", 517), Tuple.Create<System.Object, System.Int32>(Model.StandardName
            
            #line default
            #line hidden
, 517), false)
, Tuple.Create(Tuple.Create("", 536), Tuple.Create(",", 536), true)
, Tuple.Create(Tuple.Create(" ", 537), Tuple.Create("level", 538), true)
            
            #line 12 "..\..\Views\Provider\StandardResults.cshtml"
, Tuple.Create(Tuple.Create(" ", 543), Tuple.Create<System.Object, System.Int32>(Model.StandardLevel
            
            #line default
            #line hidden
, 544), false)
);

WriteLiteral(" id=\"ga-apprenticeship-title\"");

WriteLiteral(" />\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteAttribute("value", Tuple.Create(" value=\"", 623), Tuple.Create("\"", 669)
            
            #line 13 "..\..\Views\Provider\StandardResults.cshtml"
, Tuple.Create(Tuple.Create("", 631), Tuple.Create<System.Object, System.Int32>(Model.Hits.IsNullOrEmpty().ToString()
            
            #line default
            #line hidden
, 631), false)
);

WriteLiteral(" id=\"ga-no-result\"");

WriteLiteral(" />\r\n\r\n    <p");

WriteLiteral(" class=\"small-btm-margin\"");

WriteLiteral(">\r\n");

            
            #line 16 "..\..\Views\Provider\StandardResults.cshtml"
        
            
            #line default
            #line hidden
            
            #line 16 "..\..\Views\Provider\StandardResults.cshtml"
         if (Model.Hits.Count() != 0)
        {
            
            
            #line default
            #line hidden
            
            #line 18 "..\..\Views\Provider\StandardResults.cshtml"
       Write(Html.ActionLink("Back", "SearchForStandardProviders", "Apprenticeship", new { @standardId = Model.StandardId, @keywords = Model.SearchTerms, isLevyPayingEmployer = Model.IsLevyPayingEmployer }, new { @class = "link-back new-postcode-search" }));

            
            #line default
            #line hidden
            
            #line 18 "..\..\Views\Provider\StandardResults.cshtml"
                                                                                                                                                                                                                                                                

        }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 22 "..\..\Views\Provider\StandardResults.cshtml"
        
            
            #line default
            #line hidden
            
            #line 22 "..\..\Views\Provider\StandardResults.cshtml"
           Html.RenderPartial("_ManageApprenticeshipFunds", Model.ManageApprenticeshipFunds); 
            
            #line default
            #line hidden
WriteLiteral("\r\n    </p>\r\n\r\n    <div>\r\n        <div>\r\n            <hgroup");

WriteLiteral(" class=\"hgroup\"");

WriteLiteral(">\r\n                <h1");

WriteLiteral(" class=\"heading-xlarge\"");

WriteLiteral(">\r\n                    Search results\r\n                </h1>\r\n");

            
            #line 31 "..\..\Views\Provider\StandardResults.cshtml"
                
            
            #line default
            #line hidden
            
            #line 31 "..\..\Views\Provider\StandardResults.cshtml"
                  
                    Html.RenderPartial("_StandardSearchResultMessage");
                
            
            #line default
            #line hidden
WriteLiteral("\r\n            </hgroup>\r\n        </div>\r\n    </div>\r\n\r\n");

            
            #line 38 "..\..\Views\Provider\StandardResults.cshtml"
    
            
            #line default
            #line hidden
            
            #line 38 "..\..\Views\Provider\StandardResults.cshtml"
     if (Model.ShowNationalProviders && Model.TotalResults == 0)
    {

            
            #line default
            #line hidden
WriteLiteral("        <p>\r\n            Sorry, there are currently no results for the filters yo" +
"u applied\'.\r\n        </p>\r\n");

WriteLiteral("        <div>\r\n            <p>You can:</p>\r\n            <ul");

WriteLiteral(" class=\"list list-bullet\"");

WriteLiteral(">\r\n                <li");

WriteLiteral(" class=\"return-search-results\"");

WriteLiteral(">");

            
            #line 46 "..\..\Views\Provider\StandardResults.cshtml"
                                             Write(Html.ActionLink("return to your apprenticeship training search results", "StandardResults", "Provider", new { @apprenticeshipid = @Model.StandardId, @postcode = @Model.PostCode, @keywords = @Model.SearchTerms, isLevyPayingEmployer = Model.IsLevyPayingEmployer }, new { }));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n                <li");

WriteLiteral(" class=\"start-again\"");

WriteLiteral(">");

            
            #line 47 "..\..\Views\Provider\StandardResults.cshtml"
                                   Write(Html.ActionLink("start your job role or keyword search again", "Search", "Apprenticeship"));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n            </ul>\r\n        </div>\r\n");

            
            #line 50 "..\..\Views\Provider\StandardResults.cshtml"

        
            
            #line default
            #line hidden
            
            #line 51 "..\..\Views\Provider\StandardResults.cshtml"
   Write(Html.Partial("_Help"));

            
            #line default
            #line hidden
            
            #line 51 "..\..\Views\Provider\StandardResults.cshtml"
                              
    }
    else if (Model.TotalResults == 0)
    {

            
            #line default
            #line hidden
WriteLiteral("        <p>\r\n            Sorry, there are currently no training providers for <b>" +
"");

            
            #line 56 "..\..\Views\Provider\StandardResults.cshtml"
                                                               Write(Model.StandardName);

            
            #line default
            #line hidden
WriteLiteral(", level ");

            
            #line 56 "..\..\Views\Provider\StandardResults.cshtml"
                                                                                          Write(Model.StandardLevel);

            
            #line default
            #line hidden
WriteLiteral("</b> for \'<b>");

            
            #line 56 "..\..\Views\Provider\StandardResults.cshtml"
                                                                                                                           Write(Model.PostCode);

            
            #line default
            #line hidden
WriteLiteral("</b>\'.\r\n        </p>\r\n");

WriteLiteral("        <div>\r\n            <p>You can:</p>\r\n            <ul");

WriteLiteral(" class=\"list list-bullet\"");

WriteLiteral(">\r\n");

            
            #line 61 "..\..\Views\Provider\StandardResults.cshtml"
                
            
            #line default
            #line hidden
            
            #line 61 "..\..\Views\Provider\StandardResults.cshtml"
                 if (Model.TotalResultsForCountry > 0)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <li");

WriteLiteral(" class=\"total-providers-country\"");

WriteLiteral(">");

            
            #line 63 "..\..\Views\Provider\StandardResults.cshtml"
                                                   Write(Html.ActionLink(string.Format("view all ({0}) training providers", @Model.TotalResultsForCountry), "StandardResults", "Provider", new { @apprenticeshipId = @Model.StandardId, @postcode = Model.PostCode, @showAll = true, isLevyPayingEmployer = Model.IsLevyPayingEmployer }, new { @class = "" }));

            
            #line default
            #line hidden
WriteLiteral(" for <b>");

            
            #line 63 "..\..\Views\Provider\StandardResults.cshtml"
                                                                                                                                                                                                                                                                                                                                                                 Write(Model.StandardName);

            
            #line default
            #line hidden
WriteLiteral(", level ");

            
            #line 63 "..\..\Views\Provider\StandardResults.cshtml"
                                                                                                                                                                                                                                                                                                                                                                                            Write(Model.StandardLevel);

            
            #line default
            #line hidden
WriteLiteral("</b> in England</li>\r\n");

            
            #line 64 "..\..\Views\Provider\StandardResults.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                <li");

WriteLiteral(" class=\"return-search-results\"");

WriteLiteral(">");

            
            #line 65 "..\..\Views\Provider\StandardResults.cshtml"
                                             Write(Html.ActionLink("return to your apprenticeship training search results", "SearchResults", "Apprenticeship", new { @keywords = @Model.SearchTerms }, new { }));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n                <li");

WriteLiteral(" class=\"start-again\"");

WriteLiteral(">");

            
            #line 66 "..\..\Views\Provider\StandardResults.cshtml"
                                   Write(Html.ActionLink("start your job role or keyword search again", "Search", "Apprenticeship"));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n            </ul>\r\n        </div>\r\n");

            
            #line 69 "..\..\Views\Provider\StandardResults.cshtml"

        
            
            #line default
            #line hidden
            
            #line 70 "..\..\Views\Provider\StandardResults.cshtml"
   Write(Html.Partial("_Help"));

            
            #line default
            #line hidden
            
            #line 70 "..\..\Views\Provider\StandardResults.cshtml"
                              
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n    <div");

WriteLiteral(" class=\"grid-row\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"column-third\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"editSearch\"");

WriteLiteral(">\r\n");

            
            #line 76 "..\..\Views\Provider\StandardResults.cshtml"
                
            
            #line default
            #line hidden
            
            #line 76 "..\..\Views\Provider\StandardResults.cshtml"
                 if (Model.Hits.Any() && !Model.HasError)
            {

            
            #line default
            #line hidden
WriteLiteral("                    <h2");

WriteLiteral(" class=\"heading-medium\"");

WriteLiteral(">\r\n                        <a");

WriteLiteral(" href=\"#EditSearch\"");

WriteLiteral(">Filter results</a>\r\n                    </h2>\r\n");

WriteLiteral("                    <div");

WriteLiteral(" id=\"EditSearch\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 82 "..\..\Views\Provider\StandardResults.cshtml"
                   Write(FilterForm("filter-box"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n");

            
            #line 84 "..\..\Views\Provider\StandardResults.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </div>\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" id=\"provider-results\"");

WriteLiteral(" class=\"column-two-thirds\"");

WriteLiteral(">\r\n");

            
            #line 89 "..\..\Views\Provider\StandardResults.cshtml"
            
            
            #line default
            #line hidden
            
            #line 89 "..\..\Views\Provider\StandardResults.cshtml"
              
                Html.RenderPartial("_StandardProviderInformation");
            
            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"page-navigation\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 93 "..\..\Views\Provider\StandardResults.cshtml"
           Write(GetPaginationBackLink());

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 94 "..\..\Views\Provider\StandardResults.cshtml"
           Write(GetPaginationNextLink());

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</main>\r\n\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
