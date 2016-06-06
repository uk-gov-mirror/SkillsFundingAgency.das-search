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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Provider/_StandardSearchResultMessage.cshtml")]
    public partial class StandardSearchResultMessage : System.Web.Mvc.WebViewPage<Sfa.Das.Sas.Web.ViewModels.ProviderStandardSearchResultViewModel>
    {

#line 23 "..\..\Views\Provider\_StandardSearchResultMessage.cshtml"
public System.Web.WebPages.HelperResult  RenderErrorMessage()
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 24 "..\..\Views\Provider\_StandardSearchResultMessage.cshtml"
 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <p");

WriteLiteralTo(__razor_helper_writer, " id=\"standard-provider-search-message\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n        There was a problem performing a search. Try again later.\r\n    </p>\r\n");


#line 28 "..\..\Views\Provider\_StandardSearchResultMessage.cshtml"


#line default
#line hidden
});

#line 28 "..\..\Views\Provider\_StandardSearchResultMessage.cshtml"
}
#line default
#line hidden

#line 30 "..\..\Views\Provider\_StandardSearchResultMessage.cshtml"
public System.Web.WebPages.HelperResult RenderZeroResult()
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 31 "..\..\Views\Provider\_StandardSearchResultMessage.cshtml"
 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <p");

WriteLiteralTo(__razor_helper_writer, " id=\"standard-provider-search-message\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n        There are currently no providers for the apprenticeship: <b");

WriteLiteralTo(__razor_helper_writer, " id=\"standard-name\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 33 "..\..\Views\Provider\_StandardSearchResultMessage.cshtml"
                                                         WriteTo(__razor_helper_writer, Model.StandardName);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</b> covering postcode \'<b");

WriteLiteralTo(__razor_helper_writer, " id=\"postalcode\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 33 "..\..\Views\Provider\_StandardSearchResultMessage.cshtml"
                                                                                                                       WriteTo(__razor_helper_writer, Model.PostCode);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</b>\'.\r\n    </p>\r\n");

WriteLiteralTo(__razor_helper_writer, "    <div>\r\n        You can:\r\n        <ul>\r\n");


#line 38 "..\..\Views\Provider\_StandardSearchResultMessage.cshtml"
            

#line default
#line hidden

#line 38 "..\..\Views\Provider\_StandardSearchResultMessage.cshtml"
             if (Model.TotalProvidersCountry > 0)
            {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "                <li");

WriteLiteralTo(__razor_helper_writer, " class=\"total-providers-country\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 40 "..\..\Views\Provider\_StandardSearchResultMessage.cshtml"
                      WriteTo(__razor_helper_writer, Html.ActionLink(string.Format("view all({0}) training providers", @Model.TotalProvidersCountry), "StandardResults", "Provider", new { @apprenticeshipId = @Model.StandardId, @postcode = Model.PostCode, @showAll = true }, new { @class = "" }));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " for ");


#line 40 "..\..\Views\Provider\_StandardSearchResultMessage.cshtml"
                                                                                                                                                                                                                                                                            WriteTo(__razor_helper_writer, Model.StandardName);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " in England</li>\r\n");


#line 41 "..\..\Views\Provider\_StandardSearchResultMessage.cshtml"
            }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <li");

WriteLiteralTo(__razor_helper_writer, " class=\"return-search-results\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 42 "..\..\Views\Provider\_StandardSearchResultMessage.cshtml"
                WriteTo(__razor_helper_writer, Html.ActionLink("return to your apprenticeship training search results", "SearchForProviders", "Apprenticeship", new {@standardId = @Model.StandardId}, new {@class = ""}));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</li>\r\n            <li");

WriteLiteralTo(__razor_helper_writer, " class=\"start-again\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 43 "..\..\Views\Provider\_StandardSearchResultMessage.cshtml"
      WriteTo(__razor_helper_writer, Html.ActionLink("start your keyword search again", "Search", "Apprenticeship"));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</li>\r\n        </ul>\r\n    </div>\r\n");


#line 46 "..\..\Views\Provider\_StandardSearchResultMessage.cshtml"


#line default
#line hidden
});

#line 46 "..\..\Views\Provider\_StandardSearchResultMessage.cshtml"
}
#line default
#line hidden

#line 48 "..\..\Views\Provider\_StandardSearchResultMessage.cshtml"
public System.Web.WebPages.HelperResult  RenderMessageOneResult()
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 49 "..\..\Views\Provider\_StandardSearchResultMessage.cshtml"
 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <p");

WriteLiteralTo(__razor_helper_writer, " id=\"standard-provider-search-message\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n        There is <b");

WriteLiteralTo(__razor_helper_writer, " id=\"total-results\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 51 "..\..\Views\Provider\_StandardSearchResultMessage.cshtml"
         WriteTo(__razor_helper_writer, Model.TotalResults);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</b> training provider for the apprenticeship: <b");

WriteLiteralTo(__razor_helper_writer, " id=\"standard-name\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 51 "..\..\Views\Provider\_StandardSearchResultMessage.cshtml"
                                                                                                 WriteTo(__razor_helper_writer, Model.StandardName);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</b>.\r\n    </p>\r\n");

WriteLiteralTo(__razor_helper_writer, "    <p>\r\n        Results are ordered by distance from \'<b");

WriteLiteralTo(__razor_helper_writer, " id=\"postalcode\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 54 "..\..\Views\Provider\_StandardSearchResultMessage.cshtml"
                                   WriteTo(__razor_helper_writer, Model.PostCode);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</b>\'.\r\n    </p>\r\n");


#line 56 "..\..\Views\Provider\_StandardSearchResultMessage.cshtml"


#line default
#line hidden
});

#line 56 "..\..\Views\Provider\_StandardSearchResultMessage.cshtml"
}
#line default
#line hidden

#line 59 "..\..\Views\Provider\_StandardSearchResultMessage.cshtml"
public System.Web.WebPages.HelperResult  RenderMessage()
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 60 "..\..\Views\Provider\_StandardSearchResultMessage.cshtml"
 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <p");

WriteLiteralTo(__razor_helper_writer, " id=\"standard-provider-search-message\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n        There are <b");

WriteLiteralTo(__razor_helper_writer, " id=\"total-results\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 62 "..\..\Views\Provider\_StandardSearchResultMessage.cshtml"
          WriteTo(__razor_helper_writer, Model.TotalResults);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</b> training providers for the apprenticeship: <b>");


#line 62 "..\..\Views\Provider\_StandardSearchResultMessage.cshtml"
                                                                                WriteTo(__razor_helper_writer, Model.StandardName);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</b>.\r\n    </p>\r\n");

WriteLiteralTo(__razor_helper_writer, "    <p>\r\n        Results are ordered by distance from \'<b>");


#line 65 "..\..\Views\Provider\_StandardSearchResultMessage.cshtml"
                   WriteTo(__razor_helper_writer, Model.PostCode);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</b>\'.\r\n    </p>\r\n");


#line 67 "..\..\Views\Provider\_StandardSearchResultMessage.cshtml"


#line default
#line hidden
});

#line 67 "..\..\Views\Provider\_StandardSearchResultMessage.cshtml"
}
#line default
#line hidden

        public StandardSearchResultMessage()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div>\r\n\r\n");

            
            #line 5 "..\..\Views\Provider\_StandardSearchResultMessage.cshtml"
    
            
            #line default
            #line hidden
            
            #line 5 "..\..\Views\Provider\_StandardSearchResultMessage.cshtml"
     if (Model.HasError)
    {
        
            
            #line default
            #line hidden
            
            #line 7 "..\..\Views\Provider\_StandardSearchResultMessage.cshtml"
   Write(RenderErrorMessage());

            
            #line default
            #line hidden
            
            #line 7 "..\..\Views\Provider\_StandardSearchResultMessage.cshtml"
                             
    }
    else if (Model.TotalResults == 0)
    {
        
            
            #line default
            #line hidden
            
            #line 11 "..\..\Views\Provider\_StandardSearchResultMessage.cshtml"
   Write(RenderZeroResult());

            
            #line default
            #line hidden
            
            #line 11 "..\..\Views\Provider\_StandardSearchResultMessage.cshtml"
                           ;
    }
    else if (Model.TotalResults == 1)
    {
        
            
            #line default
            #line hidden
            
            #line 15 "..\..\Views\Provider\_StandardSearchResultMessage.cshtml"
   Write(RenderMessageOneResult());

            
            #line default
            #line hidden
            
            #line 15 "..\..\Views\Provider\_StandardSearchResultMessage.cshtml"
                                 
    }
    else
    {
        
            
            #line default
            #line hidden
            
            #line 19 "..\..\Views\Provider\_StandardSearchResultMessage.cshtml"
   Write(RenderMessage());

            
            #line default
            #line hidden
            
            #line 19 "..\..\Views\Provider\_StandardSearchResultMessage.cshtml"
                        
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n\r\n");

        }
    }
}
#pragma warning restore 1591
