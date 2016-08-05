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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Provider/_FilterProviders.cshtml")]
    public partial class FilterProviders : System.Web.Mvc.WebViewPage<IEnumerable<Sfa.Das.Sas.Web.ViewModels.DeliveryModeViewModel>>
    {
        public FilterProviders()
        {
        }
        public override void Execute()
        {
WriteLiteral("<fieldset");

WriteLiteral(" class=\"filters filters-accordion\"");

WriteLiteral(">\r\n    <h2");

WriteLiteral(" class=\"toggler heading-small\"");

WriteLiteral(">Training options</h2>\r\n    <div");

WriteLiteral(" class=\"toggled-content\"");

WriteLiteral("> \r\n        <ul>\r\n");

            
            #line 7 "..\..\Views\Provider\_FilterProviders.cshtml"
            
            
            #line default
            #line hidden
            
            #line 7 "..\..\Views\Provider\_FilterProviders.cshtml"
             foreach (var item in Model)
            {

            
            #line default
            #line hidden
WriteLiteral("                <li>\r\n                    <input");

WriteAttribute("value", Tuple.Create(" value=\"", 334), Tuple.Create("\"", 353)
            
            #line 10 "..\..\Views\Provider\_FilterProviders.cshtml"
, Tuple.Create(Tuple.Create("", 342), Tuple.Create<System.Object, System.Int32>(item.Value
            
            #line default
            #line hidden
, 342), false)
);

WriteLiteral(" name=\"DeliveryModes\"");

WriteAttribute("id", Tuple.Create("  id=\"", 375), Tuple.Create("\"", 406)
, Tuple.Create(Tuple.Create("", 381), Tuple.Create("DeliveryModes_", 381), true)
            
            #line 10 "..\..\Views\Provider\_FilterProviders.cshtml"
        , Tuple.Create(Tuple.Create("", 395), Tuple.Create<System.Object, System.Int32>(item.Value
            
            #line default
            #line hidden
, 395), false)
);

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" ");

            
            #line 10 "..\..\Views\Provider\_FilterProviders.cshtml"
                                                                                                               Write(Html.Raw(item.Checked ? "checked" : ""));

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 10 "..\..\Views\Provider\_FilterProviders.cshtml"
                                                                                                                                                        Write(Html.Raw(item.Count == 0 ? "disabled" : ""));

            
            #line default
            #line hidden
WriteLiteral("/>\r\n                    <label");

WriteAttribute("for", Tuple.Create(" for=\"", 539), Tuple.Create("\"", 570)
, Tuple.Create(Tuple.Create("", 545), Tuple.Create("DeliveryModes_", 545), true)
            
            #line 11 "..\..\Views\Provider\_FilterProviders.cshtml"
, Tuple.Create(Tuple.Create("", 559), Tuple.Create<System.Object, System.Int32>(item.Value
            
            #line default
            #line hidden
, 559), false)
);

WriteLiteral(">");

            
            #line 11 "..\..\Views\Provider\_FilterProviders.cshtml"
                                                      Write(item.Title);

            
            #line default
            #line hidden
WriteLiteral(" (");

            
            #line 11 "..\..\Views\Provider\_FilterProviders.cshtml"
                                                                   Write(item.Count);

            
            #line default
            #line hidden
WriteLiteral(")</label>\r\n                </li>\r\n");

            
            #line 13 "..\..\Views\Provider\_FilterProviders.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </ul>\r\n        <details>\r\n            <summary>Explain training options</" +
"summary>\r\n            <div");

WriteLiteral(" class=\"panel panel-border-narrow\"");

WriteLiteral(">\r\n                <p>\r\n                    <span");

WriteLiteral(" class=\"bold-small\"");

WriteLiteral(">Day release:</span> for example one day a week at the training provider\'s locati" +
"on.\r\n                </p>\r\n                <p>\r\n                    <span");

WriteLiteral(" class=\"bold-small\"");

WriteLiteral(">Block release:</span> for example 3-4 weeks at the training provider\'s location." +
"\r\n                </p>\r\n                <p>\r\n                    <span");

WriteLiteral(" class=\"bold-small\"");

WriteLiteral(">At your location:</span> the provider comes to your workplace.\r\n                " +
"</p>\r\n            </div>\r\n        </details>\r\n    </div>\r\n</fieldset>");

        }
    }
}
#pragma warning restore 1591
