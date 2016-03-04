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

namespace Sfa.Eds.Das.Web.Views.Provider
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
    
    #line 1 "..\..\Views\Provider\_ProviderInformation.cshtml"
    using Sfa.Das.ApplicationServices.Models;
    
    #line default
    #line hidden
    using Sfa.Eds.Das.Web;
    
    #line 2 "..\..\Views\Provider\_ProviderInformation.cshtml"
    using Sfa.Eds.Das.Web.ViewModels;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Provider/_ProviderInformation.cshtml")]
    public partial class ProviderInformation : System.Web.Mvc.WebViewPage<Sfa.Eds.Das.Web.ViewModels.ProviderSearchResultViewModel>
    {

#line 39 "..\..\Views\Provider\_ProviderInformation.cshtml"
public System.Web.WebPages.HelperResult  RenderEmployersLocationProviderDetails(ProviderResultItemViewModel item)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 40 "..\..\Views\Provider\_ProviderInformation.cshtml"
 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <dl>\r\n        <dt");

WriteLiteralTo(__razor_helper_writer, " class=\"distance\"");

WriteLiteralTo(__razor_helper_writer, ">Distance:</dt>\r\n        <dd");

WriteLiteralTo(__razor_helper_writer, " class=\"distance\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n            <span>Training will take place at the employer\'s location.</span>\r" +
"\n        </dd>\r\n    </dl>\r\n");

WriteLiteralTo(__razor_helper_writer, "    <dl>\r\n        <dt");

WriteLiteralTo(__razor_helper_writer, " class=\"distance\"");

WriteLiteralTo(__razor_helper_writer, ">Website:</dt>\r\n        <dd");

WriteLiteralTo(__razor_helper_writer, " class=\"website\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n            <a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 1727), Tuple.Create("\"", 1747)

#line 50 "..\..\Views\Provider\_ProviderInformation.cshtml"
, Tuple.Create(Tuple.Create("", 1734), Tuple.Create<System.Object, System.Int32>(item.Website

#line default
#line hidden
, 1734), false)
);

WriteLiteralTo(__razor_helper_writer, "> ");


#line 50 "..\..\Views\Provider\_ProviderInformation.cshtml"
       WriteTo(__razor_helper_writer, item.Website);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</a>\r\n        </dd>\r\n    </dl>\r\n");


#line 53 "..\..\Views\Provider\_ProviderInformation.cshtml"


#line default
#line hidden
});

#line 53 "..\..\Views\Provider\_ProviderInformation.cshtml"
}
#line default
#line hidden

#line 55 "..\..\Views\Provider\_ProviderInformation.cshtml"
public System.Web.WebPages.HelperResult  RenderProviderDetails(ProviderResultItemViewModel item)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 56 "..\..\Views\Provider\_ProviderInformation.cshtml"
 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <dl>\r\n        <dt");

WriteLiteralTo(__razor_helper_writer, " class=\"distance\"");

WriteLiteralTo(__razor_helper_writer, ">Distance:</dt>\r\n        <dd");

WriteLiteralTo(__razor_helper_writer, " class=\"distance\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n            <span>");


#line 60 "..\..\Views\Provider\_ProviderInformation.cshtml"
WriteTo(__razor_helper_writer, item.Distance);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " miles away</span>\r\n        </dd>\r\n    </dl>\r\n");

WriteLiteralTo(__razor_helper_writer, "    <dl>\r\n        <dt");

WriteLiteralTo(__razor_helper_writer, " class=\"distance\"");

WriteLiteralTo(__razor_helper_writer, ">Website:</dt>\r\n        <dd");

WriteLiteralTo(__razor_helper_writer, " class=\"website\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n            <a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 2131), Tuple.Create("\"", 2151)

#line 66 "..\..\Views\Provider\_ProviderInformation.cshtml"
, Tuple.Create(Tuple.Create("", 2138), Tuple.Create<System.Object, System.Int32>(item.Website

#line default
#line hidden
, 2138), false)
);

WriteLiteralTo(__razor_helper_writer, "> ");


#line 66 "..\..\Views\Provider\_ProviderInformation.cshtml"
       WriteTo(__razor_helper_writer, item.Website);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</a>\r\n        </dd>\r\n    </dl>\r\n");

WriteLiteralTo(__razor_helper_writer, "    <dl>\r\n        <dt");

WriteLiteralTo(__razor_helper_writer, " class=\"distance\"");

WriteLiteralTo(__razor_helper_writer, ">Trainer location name:</dt>\r\n        <dd");

WriteLiteralTo(__razor_helper_writer, " class=\"distance\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n            <span>");


#line 72 "..\..\Views\Provider\_ProviderInformation.cshtml"
WriteTo(__razor_helper_writer, item.TrainingLocationName);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " a</span>\r\n        </dd>\r\n    </dl>\r\n");

WriteLiteralTo(__razor_helper_writer, "    <dl>\r\n        <dt");

WriteLiteralTo(__razor_helper_writer, " class=\"distance\"");

WriteLiteralTo(__razor_helper_writer, ">Trainer location address:</dt>\r\n        <dd");

WriteLiteralTo(__razor_helper_writer, " class=\"distance\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n            <span>");


#line 78 "..\..\Views\Provider\_ProviderInformation.cshtml"
WriteTo(__razor_helper_writer, item.TrainingLocationAddress);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " a</span>\r\n        </dd>\r\n    </dl>\r\n");


#line 81 "..\..\Views\Provider\_ProviderInformation.cshtml"


#line default
#line hidden
});

#line 81 "..\..\Views\Provider\_ProviderInformation.cshtml"
}
#line default
#line hidden

        public ProviderInformation()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div>\r\n");

            
            #line 6 "..\..\Views\Provider\_ProviderInformation.cshtml"
    
            
            #line default
            #line hidden
            
            #line 6 "..\..\Views\Provider\_ProviderInformation.cshtml"
     foreach (var item in Model.Hits)
    {

            
            #line default
            #line hidden
WriteLiteral("        <li");

WriteLiteral(" class=\"result\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"column details\"");

WriteLiteral(">\r\n                <h2");

WriteLiteral(" class=\"heading-medium\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 11 "..\..\Views\Provider\_ProviderInformation.cshtml"
               Write(Html.ActionLink(item.ProviderName, "Detail", "Provider", new {@id = item.Id}, null));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </h2>\r\n");

            
            #line 13 "..\..\Views\Provider\_ProviderInformation.cshtml"
                
            
            #line default
            #line hidden
            
            #line 13 "..\..\Views\Provider\_ProviderInformation.cshtml"
                 if (item.DeliveryModes.Count == 1 && item.DeliveryModes.First() == DeliveryMode.HundredPercentEmployer)
                {
                    
            
            #line default
            #line hidden
            
            #line 15 "..\..\Views\Provider\_ProviderInformation.cshtml"
               Write(RenderEmployersLocationProviderDetails(item));

            
            #line default
            #line hidden
            
            #line 15 "..\..\Views\Provider\_ProviderInformation.cshtml"
                                                                 
                }
                else
                {
                    
            
            #line default
            #line hidden
            
            #line 19 "..\..\Views\Provider\_ProviderInformation.cshtml"
               Write(RenderProviderDetails(item));

            
            #line default
            #line hidden
            
            #line 19 "..\..\Views\Provider\_ProviderInformation.cshtml"
                                                
                }

            
            #line default
            #line hidden
WriteLiteral("                \r\n                <dl>\r\n                    <dt");

WriteLiteral(" class=\"distance\"");

WriteLiteral(">Employer satisfaction:</dt>\r\n                    <dd");

WriteLiteral(" class=\"distance\"");

WriteLiteral(">\r\n                        <span>");

            
            #line 25 "..\..\Views\Provider\_ProviderInformation.cshtml"
                         Write(item.EmployerSatisfaction);

            
            #line default
            #line hidden
WriteLiteral(" %</span>\r\n                    </dd>\r\n                </dl>\r\n                <dl>" +
"\r\n                    <dt");

WriteLiteral(" class=\"distance\"");

WriteLiteral(">Learner satisfaction:</dt>\r\n                    <dd");

WriteLiteral(" class=\"distance\"");

WriteLiteral(">\r\n                        <span>");

            
            #line 31 "..\..\Views\Provider\_ProviderInformation.cshtml"
                         Write(item.LearnerSatisfaction);

            
            #line default
            #line hidden
WriteLiteral(" %</span>\r\n                    </dd>\r\n                </dl>\r\n            </div>\r\n" +
"        </li>\r\n");

            
            #line 36 "..\..\Views\Provider\_ProviderInformation.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n\r\n");

WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
