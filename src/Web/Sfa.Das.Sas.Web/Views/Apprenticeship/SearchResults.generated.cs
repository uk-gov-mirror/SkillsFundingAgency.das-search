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
    using Sfa.Das.Sas.Web;
    
    #line 2 "..\..\Views\Apprenticeship\SearchResults.cshtml"
    using Sfa.Das.Sas.Web.Extensions;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Apprenticeship\SearchResults.cshtml"
    using Sfa.Das.Sas.Web.Helpers;
    
    #line default
    #line hidden
    
    #line 1 "..\..\Views\Apprenticeship\SearchResults.cshtml"
    using Sfa.Das.Sas.Web.ViewModels;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Apprenticeship/SearchResults.cshtml")]
    public partial class SearchResults : System.Web.Mvc.WebViewPage<ApprenticeshipSearchResultViewModel>
    {

#line 114 "..\..\Views\Apprenticeship\SearchResults.cshtml"
public System.Web.WebPages.HelperResult GetPaginationBackLink()
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 115 "..\..\Views\Apprenticeship\SearchResults.cshtml"
 
    if (Model.ActualPage <= 1)
    {
        return;
    }

    var previousPage = @Model.ActualPage - 1;
    var url = @Url.Action("SearchResults", "Apprenticeship", GetNavigationRouteValues(previousPage, Model.AggregationLevel, Model.SortOrder), null);
    

#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "<a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 5461), Tuple.Create("\"", 5472)

#line 123 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 5468), Tuple.Create<System.Object, System.Int32>(url

#line default
#line hidden
, 5468), false)
);

WriteLiteralTo(__razor_helper_writer, " style=\"visibility: visible\"");

WriteLiteralTo(__razor_helper_writer, " class=\"page-navigation__btn prev\"");

WriteLiteralTo(__razor_helper_writer, ">\n        <i");

WriteLiteralTo(__razor_helper_writer, " class=\"arrow-button fa fa-angle-left\"");

WriteLiteralTo(__razor_helper_writer, "></i>\n        <span");

WriteLiteralTo(__razor_helper_writer, " class=\"description\"");

WriteLiteralTo(__razor_helper_writer, ">Previous <span");

WriteLiteralTo(__razor_helper_writer, " class=\"hide-mob\"");

WriteLiteralTo(__razor_helper_writer, ">page</span></span>\n        <span");

WriteLiteralTo(__razor_helper_writer, " class=\"counter\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 126 "..\..\Views\Apprenticeship\SearchResults.cshtml"
WriteTo(__razor_helper_writer, previousPage);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " of ");


#line 126 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                 WriteTo(__razor_helper_writer, Model.LastPage);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</span>\n    </a>\n");


#line 128 "..\..\Views\Apprenticeship\SearchResults.cshtml"


#line default
#line hidden
});

#line 128 "..\..\Views\Apprenticeship\SearchResults.cshtml"
}
#line default
#line hidden

#line 131 "..\..\Views\Apprenticeship\SearchResults.cshtml"
public System.Web.WebPages.HelperResult GetPaginationNextLink()
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 132 "..\..\Views\Apprenticeship\SearchResults.cshtml"
 
    if (Model.ActualPage >= Model.LastPage || Model.ActualPage < 0)
    {
        return;
    }

    var nextPage = @Model.ActualPage + 1;

    var url = @Url.Action("SearchResults", "Apprenticeship", GetNavigationRouteValues(nextPage, Model.AggregationLevel, Model.SortOrder), null);
    

#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "<a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 6084), Tuple.Create("\"", 6095)

#line 141 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 6091), Tuple.Create<System.Object, System.Int32>(url

#line default
#line hidden
, 6091), false)
);

WriteLiteralTo(__razor_helper_writer, " style=\"visibility: visible\"");

WriteLiteralTo(__razor_helper_writer, " class=\"page-navigation__btn next\"");

WriteLiteralTo(__razor_helper_writer, ">\n        <i");

WriteLiteralTo(__razor_helper_writer, " class=\"arrow-button fa fa-angle-right\"");

WriteLiteralTo(__razor_helper_writer, "></i>\n        <span");

WriteLiteralTo(__razor_helper_writer, " class=\"description\"");

WriteLiteralTo(__razor_helper_writer, ">Next <span");

WriteLiteralTo(__razor_helper_writer, " class=\"hide-mob\"");

WriteLiteralTo(__razor_helper_writer, ">page</span></span>\n        <span");

WriteLiteralTo(__razor_helper_writer, " class=\"counter\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 144 "..\..\Views\Apprenticeship\SearchResults.cshtml"
WriteTo(__razor_helper_writer, nextPage);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " of ");


#line 144 "..\..\Views\Apprenticeship\SearchResults.cshtml"
             WriteTo(__razor_helper_writer, Model.LastPage);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</span>\n    </a>\n");


#line 146 "..\..\Views\Apprenticeship\SearchResults.cshtml"


#line default
#line hidden
});

#line 146 "..\..\Views\Apprenticeship\SearchResults.cshtml"
}
#line default
#line hidden

        #line 150 "..\..\Views\Apprenticeship\SearchResults.cshtml"
 
    RouteValueDictionary GetNavigationRouteValues(int page, IEnumerable<LevelAggregationViewModel> selectedLevels, string order)
    {

        var rv = new RouteValueDictionary { { "keywords", Model.SearchTerm }, { "page", page }, { "order", order }, { "take", Model.ResultsToTake } };
        var i = 0;
        foreach (var level in selectedLevels.Where(m => m.Checked))
        {
            rv.Add("SelectedLevels[" + i + "]", level.Value);
            i++;
        }
        return rv;
    }

        #line default
        #line hidden

#line 166 "..\..\Views\Apprenticeship\SearchResults.cshtml"
public System.Web.WebPages.HelperResult GetStandardTitle(ApprenticeshipSearchResultItemViewModel item, int index)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 167 "..\..\Views\Apprenticeship\SearchResults.cshtml"
 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <h2");

WriteLiteralTo(__razor_helper_writer, " class=\"result-title\"");

WriteLiteralTo(__razor_helper_writer, ">\n");

WriteLiteralTo(__razor_helper_writer, "        ");


#line 169 "..\..\Views\Apprenticeship\SearchResults.cshtml"
WriteTo(__razor_helper_writer, Html.ActionLink(item.Title, "Standard", "Apprenticeship", 
            new { @id = item.StandardId, @keywords = Model.SearchTerm}, 
            new { @attr_ga_result_interval = @ViewHelper.GetGaIndexAttrbute(index) } ));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\n        <span");

WriteLiteralTo(__razor_helper_writer, " class=\"tag tag-new\"");

WriteLiteralTo(__razor_helper_writer, ">New</span>\n    </h2>\n");


#line 174 "..\..\Views\Apprenticeship\SearchResults.cshtml"


#line default
#line hidden
});

#line 174 "..\..\Views\Apprenticeship\SearchResults.cshtml"
}
#line default
#line hidden

#line 176 "..\..\Views\Apprenticeship\SearchResults.cshtml"
public System.Web.WebPages.HelperResult GetFrameworkTitle(ApprenticeshipSearchResultItemViewModel item, int index)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 177 "..\..\Views\Apprenticeship\SearchResults.cshtml"
 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <h2");

WriteLiteralTo(__razor_helper_writer, " class=\"result-title\"");

WriteLiteralTo(__razor_helper_writer, ">\n");

WriteLiteralTo(__razor_helper_writer, "        ");


#line 179 "..\..\Views\Apprenticeship\SearchResults.cshtml"
WriteTo(__razor_helper_writer, Html.ActionLink(item.Title, "Framework", "Apprenticeship", 
            new { @id = item.FrameworkId, @keywords = Model.SearchTerm }, 
            new { @attr_ga_result_interval = @ViewHelper.GetGaIndexAttrbute(index) }));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\n    </h2>\n");


#line 183 "..\..\Views\Apprenticeship\SearchResults.cshtml"


#line default
#line hidden
});

#line 183 "..\..\Views\Apprenticeship\SearchResults.cshtml"
}
#line default
#line hidden

#line 185 "..\..\Views\Apprenticeship\SearchResults.cshtml"
public System.Web.WebPages.HelperResult GetApprenticeshipDetailItem(string title, string id, string item, string unit = "")
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 186 "..\..\Views\Apprenticeship\SearchResults.cshtml"
 
    if (string.IsNullOrEmpty(item))
    {
        return;
    }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <dt><b>");


#line 191 "..\..\Views\Apprenticeship\SearchResults.cshtml"
WriteTo(__razor_helper_writer, title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</b></dt>\n");

WriteLiteralTo(__razor_helper_writer, "    <dd");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 7840), Tuple.Create("\"", 7851)

#line 192 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 7848), Tuple.Create<System.Object, System.Int32>(id

#line default
#line hidden
, 7848), false)
);

WriteLiteralTo(__razor_helper_writer, ">");


#line 192 "..\..\Views\Apprenticeship\SearchResults.cshtml"
WriteTo(__razor_helper_writer, item);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " ");


#line 192 "..\..\Views\Apprenticeship\SearchResults.cshtml"
WriteTo(__razor_helper_writer, unit);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dd>\n");


#line 193 "..\..\Views\Apprenticeship\SearchResults.cshtml"


#line default
#line hidden
});

#line 193 "..\..\Views\Apprenticeship\SearchResults.cshtml"
}
#line default
#line hidden

#line 195 "..\..\Views\Apprenticeship\SearchResults.cshtml"
public System.Web.WebPages.HelperResult FilterForm(string className)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 196 "..\..\Views\Apprenticeship\SearchResults.cshtml"
 
    if (Model.TotalResults <= 0)
    {
        return;
    }



#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <div");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 7982), Tuple.Create("\"", 8014)
, Tuple.Create(Tuple.Create("", 7990), Tuple.Create("filters-block", 7990), true)

#line 202 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create(" ", 8003), Tuple.Create<System.Object, System.Int32>(className

#line default
#line hidden
, 8004), false)
);

WriteLiteralTo(__razor_helper_writer, ">\n        <form");

WriteLiteralTo(__razor_helper_writer, " method=\"get\"");

WriteLiteralTo(__razor_helper_writer, " autocomplete=\"off\"");

WriteLiteralTo(__razor_helper_writer, ">\n            <input");

WriteLiteralTo(__razor_helper_writer, " type=\"hidden\"");

WriteLiteralTo(__razor_helper_writer, " name=\"Keywords\"");

WriteAttributeTo(__razor_helper_writer, "value", Tuple.Create(" value=\"", 8112), Tuple.Create("\"", 8137)

#line 204 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 8120), Tuple.Create<System.Object, System.Int32>(Model.SearchTerm

#line default
#line hidden
, 8120), false)
);

WriteLiteralTo(__razor_helper_writer, " />\n            <input");

WriteLiteralTo(__razor_helper_writer, " type=\"hidden\"");

WriteLiteralTo(__razor_helper_writer, " name=\"order\"");

WriteAttributeTo(__razor_helper_writer, "value", Tuple.Create(" value=\"", 8187), Tuple.Create("\"", 8211)

#line 205 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 8195), Tuple.Create<System.Object, System.Int32>(Model.SortOrder

#line default
#line hidden
, 8195), false)
);

WriteLiteralTo(__razor_helper_writer, " />\n\n            <fieldset");

WriteLiteralTo(__razor_helper_writer, " class=\"filters filters-accordion\"");

WriteLiteralTo(__razor_helper_writer, ">\n                <h2");

WriteLiteralTo(__razor_helper_writer, " class=\"toggler heading-small\"");

WriteLiteralTo(__razor_helper_writer, ">Apprenticeship level</h2>\n                <div");

WriteLiteralTo(__razor_helper_writer, " class=\"toggled-content\"");

WriteLiteralTo(__razor_helper_writer, ">\n                    <ul");

WriteLiteralTo(__razor_helper_writer, " name=\"alist22\"");

WriteLiteralTo(__razor_helper_writer, ">\n");


#line 211 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                        

#line default
#line hidden

#line 211 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                         foreach (var item in Model.AggregationLevel.OrderBy(m => m.Value))
                        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "                            <li>\n                                <input");

WriteAttributeTo(__razor_helper_writer, "value", Tuple.Create(" value=\"", 8625), Tuple.Create("\"", 8644)

#line 214 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 8633), Tuple.Create<System.Object, System.Int32>(item.Value

#line default
#line hidden
, 8633), false)
);

WriteAttributeTo(__razor_helper_writer, "id", Tuple.Create(" id=\"", 8645), Tuple.Create("\"", 8678)
, Tuple.Create(Tuple.Create("", 8650), Tuple.Create("SelectedLevels_", 8650), true)

#line 214 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 8665), Tuple.Create<System.Object, System.Int32>(item.Value

#line default
#line hidden
, 8665), false)
);

WriteLiteralTo(__razor_helper_writer, " name=\"SelectedLevels\"");

WriteLiteralTo(__razor_helper_writer, " type=\"checkbox\"");

WriteLiteralTo(__razor_helper_writer, " ");


#line 214 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                                                                                                     WriteTo(__razor_helper_writer, Html.Raw(item.Checked ? "checked" : ""));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " ");


#line 214 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                                                                                                                                              WriteTo(__razor_helper_writer, Html.Raw(item.Count == 0 ? "disabled" : ""));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " />\n                                <label");

WriteAttributeTo(__razor_helper_writer, "for", Tuple.Create(" for=\"", 8845), Tuple.Create("\"", 8879)
, Tuple.Create(Tuple.Create("", 8851), Tuple.Create("SelectedLevels_", 8851), true)

#line 215 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 8866), Tuple.Create<System.Object, System.Int32>(item.Value

#line default
#line hidden
, 8866), false)
);

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 8880), Tuple.Create("\"", 8932)

#line 215 "..\..\Views\Apprenticeship\SearchResults.cshtml"
 , Tuple.Create(Tuple.Create("", 8888), Tuple.Create<System.Object, System.Int32>(Html.Raw(item.Count == 0 ? "disabled" : "")

#line default
#line hidden
, 8888), false)
);

WriteLiteralTo(__razor_helper_writer, ">level ");


#line 215 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                                                                                                       WriteTo(__razor_helper_writer, item.Value);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " (");


#line 215 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                                                                                                                    WriteTo(__razor_helper_writer, item.Count);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, ")</label>\n                            </li>\n");


#line 217 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                        }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "                    </ul>\n\n                    <details>\n                        " +
"<summary>Explain levels</summary>\n                        <div");

WriteLiteralTo(__razor_helper_writer, " class=\"panel panel-border-narrow\"");

WriteLiteralTo(__razor_helper_writer, ">\n                            <p>Apprenticeships are set at different levels of d" +
"ifficulty from the equivalent of GCSE (level 2) up to postgraduate (level 7)</p>" +
"\n                            <p><a");

WriteLiteralTo(__razor_helper_writer, " href=\"https://www.gov.uk/what-different-qualification-levels-mean/overview\"");

WriteLiteralTo(__razor_helper_writer, " target=\"_blank\"");

WriteLiteralTo(__razor_helper_writer, " rel=\"external\"");

WriteLiteralTo(__razor_helper_writer, ">More about levels</a></p>\n                        </div>\n                    </d" +
"etails>\n                    \n\n                </div>\n            </fieldset>\n   " +
"         <input");

WriteLiteralTo(__razor_helper_writer, " type=\"submit\"");

WriteLiteralTo(__razor_helper_writer, " class=\"button\"");

WriteLiteralTo(__razor_helper_writer, " value=\"Update results\"");

WriteLiteralTo(__razor_helper_writer, " />\n        </form>\n    </div>\n");


#line 234 "..\..\Views\Apprenticeship\SearchResults.cshtml"


#line default
#line hidden
});

#line 234 "..\..\Views\Apprenticeship\SearchResults.cshtml"
}
#line default
#line hidden

        public SearchResults()
        {
        }
        public override void Execute()
        {
            
            #line 6 "..\..\Views\Apprenticeship\SearchResults.cshtml"
  
    ViewBag.Title = "Search Results";
    ViewBag.Description = "The Find Apprenticeship Training service is for employers in England who want to find training courses for their apprentices and search for training providers.";

            
            #line default
            #line hidden
WriteLiteral("\n<main");

WriteLiteral(" id=\"content\"");

WriteLiteral(" role=\"main\"");

WriteLiteral(">\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteAttribute("value", Tuple.Create(" value=\"", 431), Tuple.Create("\"", 456)
            
            #line 11 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 439), Tuple.Create<System.Object, System.Int32>(Model.SearchTerm
            
            #line default
            #line hidden
, 439), false)
);

WriteLiteral(" id=\"ga-search-term\"");

WriteLiteral("/>\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteAttribute("value", Tuple.Create(" value=\"", 504), Tuple.Create("\"", 553)
            
            #line 12 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 512), Tuple.Create<System.Object, System.Int32>(Model.Results.IsNullOrEmpty().ToString()
            
            #line default
            #line hidden
, 512), false)
);

WriteLiteral(" id=\"ga-no-result\"");

WriteLiteral(" />\r\n\r\n    <hgroup");

WriteLiteral(" class=\"hgroup\"");

WriteLiteral(">\n        <h1");

WriteLiteral(" class=\"heading-xlarge\"");

WriteLiteral(">\n            Search results\n        </h1>\n");

            
            #line 18 "..\..\Views\Apprenticeship\SearchResults.cshtml"
        
            
            #line default
            #line hidden
            
            #line 18 "..\..\Views\Apprenticeship\SearchResults.cshtml"
          
            Html.RenderPartial("_SearchResultMessage");
        
            
            #line default
            #line hidden
WriteLiteral("\n    </hgroup>\n\n");

            
            #line 23 "..\..\Views\Apprenticeship\SearchResults.cshtml"
    
            
            #line default
            #line hidden
            
            #line 23 "..\..\Views\Apprenticeship\SearchResults.cshtml"
     if (Model.TotalResults == 0)
    {
        using (Html.BeginForm("SearchResults", "Apprenticeship", FormMethod.Get, new { @class = "search-box" }))
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" for=\"keywords\"");

WriteLiteral(">\r\n                    <span");

WriteLiteral(" class=\"form-label-bold\"");

WriteLiteral(">Try a new search</span>\r\n                    <span");

WriteLiteral(" class=\"form-hint\"");

WriteLiteral(">Can include job title or apprenticeship</span>\r\n                </label>\r\n      " +
"          <span");

WriteLiteral(" class=\"error-message\"");

WriteLiteral("></span>\r\n                <input");

WriteLiteral(" type=\"search\"");

WriteLiteral(" id=\"keywords\"");

WriteLiteral(" name=\"Keywords\"");

WriteLiteral(" class=\"text-box form-control\"");

WriteLiteral(" maxlength=\"200\"");

WriteLiteral(">\r\n            </div>\r\n");

WriteLiteral("            <input");

WriteLiteral(" class=\"button\"");

WriteLiteral(" id=\"submit-keywords\"");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" value=\"Search\"");

WriteLiteral(" />\r\n");

            
            #line 36 "..\..\Views\Apprenticeship\SearchResults.cshtml"
        }
    }

            
            #line default
            #line hidden
WriteLiteral("\n    <div");

WriteLiteral(" class=\"grid-row\"");

WriteLiteral(">\r\n\r\n");

            
            #line 41 "..\..\Views\Apprenticeship\SearchResults.cshtml"
        
            
            #line default
            #line hidden
            
            #line 41 "..\..\Views\Apprenticeship\SearchResults.cshtml"
         if (Model.TotalResults > 0)
        {
            using (Html.BeginForm("SearchResults", "Apprenticeship", FormMethod.Get, new { @class = "search-box" }))
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" for=\"keywords\"");

WriteLiteral(">\r\n                        <span");

WriteLiteral(" class=\"form-label-bold\"");

WriteLiteral(">Showing search results for:</span>\r\n                    </label>\r\n              " +
"      <input");

WriteLiteral(" type=\"search\"");

WriteLiteral(" id=\"keywords\"");

WriteLiteral(" name=\"Keywords\"");

WriteLiteral(" class=\"text-box form-control\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2025), Tuple.Create("\"", 2050)
            
            #line 49 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                            , Tuple.Create(Tuple.Create("", 2033), Tuple.Create<System.Object, System.Int32>(Model.SearchTerm
            
            #line default
            #line hidden
, 2033), false)
);

WriteLiteral(" maxlength=\"200\"");

WriteLiteral(">\r\n\r\n                    <input");

WriteLiteral(" class=\"button\"");

WriteLiteral(" id=\"submit-keywords\"");

WriteLiteral(" class=\"form-control-1-3\"");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" value=\"Search\"");

WriteLiteral(" />\r\n                </div>\r\n");

            
            #line 53 "..\..\Views\Apprenticeship\SearchResults.cshtml"
            }
        }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 56 "..\..\Views\Apprenticeship\SearchResults.cshtml"
        
            
            #line default
            #line hidden
            
            #line 56 "..\..\Views\Apprenticeship\SearchResults.cshtml"
         if (!Model.HasError && Model.TotalResults > 0)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"column-one-third\"");

WriteLiteral(">\n                <div");

WriteLiteral(" class=\"editSearch\"");

WriteLiteral(">\n                    <h2");

WriteLiteral(" class=\"heading-medium\"");

WriteLiteral(">\n                        <a");

WriteLiteral(" href=\"#EditSearch\"");

WriteLiteral(">Filter results</a>\n                    </h2>\n                    <div");

WriteLiteral(" id=\"EditSearch\"");

WriteLiteral(">\n");

WriteLiteral("                        ");

            
            #line 64 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                   Write(FilterForm("filter-box"));

            
            #line default
            #line hidden
WriteLiteral("\n                    </div>\n                </div>\n            </div>\n");

            
            #line 68 "..\..\Views\Apprenticeship\SearchResults.cshtml"


            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" id=\"apprenticeship-results\"");

WriteLiteral(" class=\"column-two-thirds\"");

WriteLiteral(">\n                <form");

WriteLiteral(" method=\"GET\"");

WriteLiteral(" id=\"search-results-order\"");

WriteLiteral(">\n                    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" name=\"Keywords\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2886), Tuple.Create("\"", 2911)
            
            #line 71 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 2894), Tuple.Create<System.Object, System.Int32>(Model.SearchTerm
            
            #line default
            #line hidden
, 2894), false)
);

WriteLiteral("/>\n                    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" name=\"page\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2967), Tuple.Create("\"", 2992)
            
            #line 72 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 2975), Tuple.Create<System.Object, System.Int32>(Model.ActualPage
            
            #line default
            #line hidden
, 2975), false)
);

WriteLiteral("/>\n                    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" name=\"take\"");

WriteAttribute("value", Tuple.Create(" value=\"", 3048), Tuple.Create("\"", 3076)
            
            #line 73 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 3056), Tuple.Create<System.Object, System.Int32>(Model.ResultsToTake
            
            #line default
            #line hidden
, 3056), false)
);

WriteLiteral("/>\n");

            
            #line 74 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 74 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                     foreach (var level in Model.AggregationLevel.Where(level => level.Checked))
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" name=\"SelectedLevels\"");

WriteAttribute("value", Tuple.Create(" value=\"", 3265), Tuple.Create("\"", 3285)
            
            #line 76 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 3273), Tuple.Create<System.Object, System.Int32>(level.Value
            
            #line default
            #line hidden
, 3273), false)
);

WriteLiteral("/>\n");

            
            #line 77 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"form-block\"");

WriteLiteral(">\n                        <label");

WriteLiteral(" for=\"select-order\"");

WriteLiteral(" class=\"form-label-bold\"");

WriteLiteral(">Sort by</label>\n                        <select");

WriteLiteral(" name=\"order\"");

WriteLiteral(" id=\"select-order\"");

WriteLiteral(" class=\"form-control form-control-1-3\"");

WriteLiteral(">\n                            <option");

WriteAttribute("selected", Tuple.Create(" selected=\"", 3583), Tuple.Create("\"", 3619)
            
            #line 81 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 3594), Tuple.Create<System.Object, System.Int32>(Model.SortOrder == "1"
            
            #line default
            #line hidden
, 3594), false)
);

WriteLiteral(" value=\"1\"");

WriteLiteral(">Best match</option>\n                            <option");

WriteAttribute("selected", Tuple.Create(" selected=\"", 3686), Tuple.Create("\"", 3722)
            
            #line 82 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 3697), Tuple.Create<System.Object, System.Int32>(Model.SortOrder == "2"
            
            #line default
            #line hidden
, 3697), false)
);

WriteLiteral(" value=\"2\"");

WriteLiteral(">Level (high to low)</option>\n                            <option");

WriteAttribute("selected", Tuple.Create(" selected=\"", 3798), Tuple.Create("\"", 3834)
            
            #line 83 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 3809), Tuple.Create<System.Object, System.Int32>(Model.SortOrder == "3"
            
            #line default
            #line hidden
, 3809), false)
);

WriteLiteral(" value=\"3\"");

WriteLiteral(">Level (low to high)</option>\n                        </select>\n                 " +
"       <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" value=\"Sort\"");

WriteLiteral(" class=\"button\"");

WriteLiteral(">Sort</button>\n                    </div>\n                </form>\n\n");

            
            #line 89 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                
            
            #line default
            #line hidden
            
            #line 89 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                   var index = (Model.ActualPage * Model.ResultsToTake) - Model.ResultsToTake; 
            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 90 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                
            
            #line default
            #line hidden
            
            #line 90 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                 foreach (var item in Model.Results)
                {
                    index += 1;

            
            #line default
            #line hidden
WriteLiteral("                    <article");

WriteAttribute("class", Tuple.Create(" class=\"", 4277), Tuple.Create("\"", 4325)
, Tuple.Create(Tuple.Create("", 4285), Tuple.Create("result", 4285), true)
            
            #line 93 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create(" ", 4291), Tuple.Create<System.Object, System.Int32>(item.ApprenticeshipType
            
            #line default
            #line hidden
, 4292), false)
, Tuple.Create(Tuple.Create("", 4318), Tuple.Create("-result", 4318), true)
);

WriteAttribute("id", Tuple.Create(" \n                             id=\"", 4326), Tuple.Create("\"", 4460)
            
            #line 94 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 4361), Tuple.Create<System.Object, System.Int32>(item.ApprenticeshipType
            
            #line default
            #line hidden
, 4361), false)
, Tuple.Create(Tuple.Create("", 4387), Tuple.Create("-", 4387), true)
            
            #line 94 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 4388), Tuple.Create<System.Object, System.Int32>(!item.StandardId.IsNullOrEmpty() ? item.StandardId : item.FrameworkId
            
            #line default
            #line hidden
, 4388), false)
);

WriteLiteral(">\n                    <header>\n");

WriteLiteral("                        ");

            
            #line 96 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                    Write(!item.StandardId.IsNullOrEmpty() ? GetStandardTitle(item, index) : GetFrameworkTitle(item, index));

            
            #line default
            #line hidden
WriteLiteral("\n                    </header>\n                    <dl");

WriteLiteral(" class=\"result-data-list\"");

WriteLiteral(">\n");

WriteLiteral("                        ");

            
            #line 99 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                   Write(GetApprenticeshipDetailItem("Level:", "level", item.Level));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("                        ");

            
            #line 100 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                   Write(GetApprenticeshipDetailItem("Typical length:", "length", item.TypicalLengthMessage));

            
            #line default
            #line hidden
WriteLiteral("\n                    </dl>\n                </article>\n");

            
            #line 103 "..\..\Views\Apprenticeship\SearchResults.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"page-navigation\"");

WriteLiteral(">\n");

WriteLiteral("                    ");

            
            #line 105 "..\..\Views\Apprenticeship\SearchResults.cshtml"
               Write(GetPaginationBackLink());

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("                    ");

            
            #line 106 "..\..\Views\Apprenticeship\SearchResults.cshtml"
               Write(GetPaginationNextLink());

            
            #line default
            #line hidden
WriteLiteral("\n                </div>\n            </div>\n");

            
            #line 109 "..\..\Views\Apprenticeship\SearchResults.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("\n    </div>\n</main>\n\n");

WriteLiteral("\n\n");

WriteLiteral("\n\n");

WriteLiteral("\n\n");

WriteLiteral("\n");

WriteLiteral("\n");

WriteLiteral("\n");

        }
    }
}
#pragma warning restore 1591
