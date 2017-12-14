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
    
    #line 1 "..\..\Views\Provider\ProviderDetail.cshtml"
    using Sfa.Das.Sas.Web.Extensions;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Provider\ProviderDetail.cshtml"
    using Sfa.Das.Sas.Web.ViewModels;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Provider/ProviderDetail.cshtml")]
    public partial class ProviderDetail : System.Web.Mvc.WebViewPage<ProviderDetailViewModel>
    {

#line 153 "..\..\Views\Provider\ProviderDetail.cshtml"
public System.Web.WebPages.HelperResult CreateProgressBar(string message, int progress)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 154 "..\..\Views\Provider\ProviderDetail.cshtml"
 
if (progress > 0)
{


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <div");

WriteLiteralTo(__razor_helper_writer, " class=\"progress-container\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n            <div");

WriteLiteralTo(__razor_helper_writer, " class=\"progressbar\"");

WriteAttributeTo(__razor_helper_writer, "style", Tuple.Create(" style=\"", 7191), Tuple.Create("\"", 7216)
, Tuple.Create(Tuple.Create("", 7199), Tuple.Create("width:", 7199), true)

#line 158 "..\..\Views\Provider\ProviderDetail.cshtml"
, Tuple.Create(Tuple.Create(" ", 7205), Tuple.Create<System.Object, System.Int32>(progress

#line default
#line hidden
, 7206), false)
, Tuple.Create(Tuple.Create("", 7215), Tuple.Create("%", 7215), true)
);

WriteLiteralTo(__razor_helper_writer, "></div>\r\n        </div>\r\n");


#line 160 "..\..\Views\Provider\ProviderDetail.cshtml"
}


#line default
#line hidden
});

#line 161 "..\..\Views\Provider\ProviderDetail.cshtml"
}
#line default
#line hidden

        public ProviderDetail()
        {
        }
        public override void Execute()
        {
            
            #line 5 "..\..\Views\Provider\ProviderDetail.cshtml"
  
    ViewBag.Title = "Provider Details";
    ViewBag.Description = "";

            
            #line default
            #line hidden
WriteLiteral("\r\n<main");

WriteLiteral(" id=\"content\"");

WriteLiteral(" class=\"provider-detail\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"grid-row\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"column-two-thirds\"");

WriteLiteral(">\r\n            <h1");

WriteLiteral(" class=\"heading-xlarge\"");

WriteLiteral(" id=\"provider-name\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 13 "..\..\Views\Provider\ProviderDetail.cshtml"
           Write(Model.ProviderName);

            
            #line default
            #line hidden
WriteLiteral(" \r\n");

            
            #line 14 "..\..\Views\Provider\ProviderDetail.cshtml"
                
            
            #line default
            #line hidden
            
            #line 14 "..\..\Views\Provider\ProviderDetail.cshtml"
                 if (@Model.NationalProvider)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <span");

WriteLiteral(" class=\"tag-national\"");

WriteLiteral("><span");

WriteLiteral(" class=\"font-adjust\"");

WriteLiteral(">National</span></span>\r\n");

            
            #line 17 "..\..\Views\Provider\ProviderDetail.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </h1>\r\n        </div>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"grid-row\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"column-two-thirds\"");

WriteLiteral(">\r\n            <dl");

WriteLiteral(" class=\"data-list--provider data-list--compact\"");

WriteLiteral(">\r\n");

            
            #line 24 "..\..\Views\Provider\ProviderDetail.cshtml"
                
            
            #line default
            #line hidden
            
            #line 24 "..\..\Views\Provider\ProviderDetail.cshtml"
                 if (!string.IsNullOrEmpty(Model.TradingNames))
                {

            
            #line default
            #line hidden
WriteLiteral("                    <dt>Trading names:</dt>\r\n");

WriteLiteral("                    <dd");

WriteLiteral(" id=\"trading-names\"");

WriteLiteral(">");

            
            #line 27 "..\..\Views\Provider\ProviderDetail.cshtml"
                                      Write(Model.TradingNames);

            
            #line default
            #line hidden
WriteLiteral("</dd>\r\n");

            
            #line 28 "..\..\Views\Provider\ProviderDetail.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                <dt>UKPRN:</dt>\r\n                <dd>");

            
            #line 30 "..\..\Views\Provider\ProviderDetail.cshtml"
               Write(Model.UkPrn);

            
            #line default
            #line hidden
WriteLiteral("</dd>                   \r\n            </dl>\r\n            <p");

WriteLiteral(" class=\"markdown-header-text\"");

WriteLiteral(">About this Provider</p>\r\n");

            
            #line 33 "..\..\Views\Provider\ProviderDetail.cshtml"
            
            
            #line default
            #line hidden
            
            #line 33 "..\..\Views\Provider\ProviderDetail.cshtml"
             if (string.IsNullOrEmpty(Model.MarketingInfo))
            {

            
            #line default
            #line hidden
WriteLiteral("                <span>There is no marketing information available about this prov" +
"ider.</span>\r\n");

            
            #line 36 "..\..\Views\Provider\ProviderDetail.cshtml"
            }
            else
            {
                
            
            #line default
            #line hidden
            
            #line 39 "..\..\Views\Provider\ProviderDetail.cshtml"
           Write(Html.MarkdownToHtml(Model.MarketingInfo));

            
            #line default
            #line hidden
            
            #line 39 "..\..\Views\Provider\ProviderDetail.cshtml"
                                                         
            }

            
            #line default
            #line hidden
WriteLiteral("            \r\n  \r\n");

            
            #line 43 "..\..\Views\Provider\ProviderDetail.cshtml"
            
            
            #line default
            #line hidden
            
            #line 43 "..\..\Views\Provider\ProviderDetail.cshtml"
             if (Model.ApprenticeshipTrainingSummary != null && Model.ApprenticeshipTrainingSummary.Count > 0)
            {

            
            #line default
            #line hidden
WriteLiteral("               <div");

WriteLiteral(" id=\"search-app-offered\"");

WriteLiteral(">\r\n                     <h2");

WriteLiteral(" class=\"heading-medium app-offered\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 47 "..\..\Views\Provider\ProviderDetail.cshtml"
                   Write(Model.ApprenticeshipTrainingSummary.Count);

            
            #line default
            #line hidden
WriteLiteral(" Apprenticeships offered\r\n                    </h2>        \r\n                </di" +
"v>\r\n");

WriteLiteral("                <table");

WriteLiteral(" class=\"app-details\"");

WriteLiteral(">\r\n                    <thead>\r\n                        <tr>\r\n                   " +
"         <th>Apprenticeship</th>\r\n                            <th>Type</th>\r\n   " +
"                         <th>Level</th>\r\n                            <th><span");

WriteLiteral(" class=\"visibility-hidden\"");

WriteLiteral(">View details</span></th>\r\n                        </tr>\r\n                    </t" +
"head>\r\n                    <tbody>\r\n");

            
            #line 60 "..\..\Views\Provider\ProviderDetail.cshtml"
                
            
            #line default
            #line hidden
            
            #line 60 "..\..\Views\Provider\ProviderDetail.cshtml"
                 foreach (var item in Model.ApprenticeshipTrainingSummary.ApprenticeshipTrainingItems)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <tr>\r\n                        <td>");

            
            #line 63 "..\..\Views\Provider\ProviderDetail.cshtml"
                       Write(item.Name);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                        <td>");

            
            #line 64 "..\..\Views\Provider\ProviderDetail.cshtml"
                       Write(item.Type);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                        <td>");

            
            #line 65 "..\..\Views\Provider\ProviderDetail.cshtml"
                       Write(item.Level);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                        <td><a");

WriteAttribute("href", Tuple.Create(" href=\"", 2590), Tuple.Create("\"", 2640)
, Tuple.Create(Tuple.Create("", 2597), Tuple.Create("/Apprenticeship/", 2597), true)
            
            #line 66 "..\..\Views\Provider\ProviderDetail.cshtml"
, Tuple.Create(Tuple.Create("", 2613), Tuple.Create<System.Object, System.Int32>(item.Type
            
            #line default
            #line hidden
, 2613), false)
, Tuple.Create(Tuple.Create("", 2623), Tuple.Create("/", 2623), true)
            
            #line 66 "..\..\Views\Provider\ProviderDetail.cshtml"
, Tuple.Create(Tuple.Create("", 2624), Tuple.Create<System.Object, System.Int32>(item.Identifier
            
            #line default
            #line hidden
, 2624), false)
);

WriteLiteral(">Details</a></td>\r\n                    </tr>\r\n");

            
            #line 68 "..\..\Views\Provider\ProviderDetail.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                    </tbody>\r\n                </table>\r\n");

            
            #line 71 "..\..\Views\Provider\ProviderDetail.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n        <div");

WriteLiteral(" class=\"column-one-third\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"panel--contact\"");

WriteLiteral(">\r\n                <h2");

WriteLiteral(" class=\"heading-medium\"");

WriteLiteral(">Contact details</h2>\r\n                <dl>\r\n");

            
            #line 77 "..\..\Views\Provider\ProviderDetail.cshtml"
                     
            
            #line default
            #line hidden
            
            #line 77 "..\..\Views\Provider\ProviderDetail.cshtml"
                       var linkProtocol = Model.Website.StartsWith("http") ? string.Empty : "http://";
            
            #line default
            #line hidden
WriteLiteral("\r\n                    <dt");

WriteLiteral(" class=\"apprenticeshipContactTitle\"");

WriteLiteral(">Website:</dt>\r\n                    <dd>\r\n                        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 3193), Tuple.Create("\"", 3227)
            
            #line 80 "..\..\Views\Provider\ProviderDetail.cshtml"
, Tuple.Create(Tuple.Create("", 3200), Tuple.Create<System.Object, System.Int32>(linkProtocol
            
            #line default
            #line hidden
, 3200), false)
            
            #line 80 "..\..\Views\Provider\ProviderDetail.cshtml"
, Tuple.Create(Tuple.Create("", 3213), Tuple.Create<System.Object, System.Int32>(Model.Website
            
            #line default
            #line hidden
, 3213), false)
);

WriteLiteral(" rel=\"external\"");

WriteLiteral(" target=\"_blank\"");

WriteLiteral(" class=\"course-link apprenticeshipContact\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 81 "..\..\Views\Provider\ProviderDetail.cshtml"
                       Write(Html.Raw(Model.ProviderName + " website"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </a>\r\n                    </dd>\r\n\r\n");

            
            #line 85 "..\..\Views\Provider\ProviderDetail.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 85 "..\..\Views\Provider\ProviderDetail.cshtml"
                      
                    if (!string.IsNullOrEmpty(Model.Phone))
                        {

            
            #line default
            #line hidden
WriteLiteral("                        <dt");

WriteLiteral(" class=\"phone-title\"");

WriteLiteral(">Phone number:</dt>\r\n");

WriteLiteral("                        <dd");

WriteLiteral(" id=\"phone\"");

WriteLiteral(" class=\"phone\"");

WriteLiteral(">");

            
            #line 89 "..\..\Views\Provider\ProviderDetail.cshtml"
                                                Write(Html.Raw(Model.Phone));

            
            #line default
            #line hidden
WriteLiteral("</dd>\r\n");

            
            #line 90 "..\..\Views\Provider\ProviderDetail.cshtml"
                        }
                    
            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 92 "..\..\Views\Provider\ProviderDetail.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 92 "..\..\Views\Provider\ProviderDetail.cshtml"
                      
                    if (!string.IsNullOrEmpty(Model.Email))
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <dt");

WriteLiteral(" class=\"email-title\"");

WriteLiteral(">Email:</dt>\r\n");

WriteLiteral("                            <dd");

WriteLiteral(" id=\"email\"");

WriteLiteral(" class=\"email\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 3983), Tuple.Create("\"", 4019)
, Tuple.Create(Tuple.Create("", 3990), Tuple.Create("mailto:", 3990), true)
            
            #line 96 "..\..\Views\Provider\ProviderDetail.cshtml"
, Tuple.Create(Tuple.Create("", 3997), Tuple.Create<System.Object, System.Int32>(Html.Raw(Model.Email)
            
            #line default
            #line hidden
, 3997), false)
);

WriteLiteral(">");

            
            #line 96 "..\..\Views\Provider\ProviderDetail.cshtml"
                                                                                            Write(Html.Raw(Model.Email));

            
            #line default
            #line hidden
WriteLiteral("</a></dd>\r\n");

            
            #line 97 "..\..\Views\Provider\ProviderDetail.cshtml"
                        }
                    
            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n                </dl>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"panel--contact panel--satisfaction\"");

WriteLiteral(">\r\n                <dl>\r\n                    <dt>Employer satisfaction:</dt>\r\n   " +
"                 <dd>\r\n                        <div");

WriteLiteral(" class=\"rating rating--inline\"");

WriteLiteral(">\r\n                            <span");

WriteLiteral(" id=\"employer-satisfaction\"");

WriteAttribute("class", Tuple.Create(" class=\"", 4433), Tuple.Create("\"", 4475)
, Tuple.Create(Tuple.Create("", 4441), Tuple.Create("rating-", 4441), true)
            
            #line 107 "..\..\Views\Provider\ProviderDetail.cshtml"
, Tuple.Create(Tuple.Create("", 4448), Tuple.Create<System.Object, System.Int32>(Model.EmployerSatisfaction
            
            #line default
            #line hidden
, 4448), false)
);

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 108 "..\..\Views\Provider\ProviderDetail.cshtml"
                           Write(Model.EmployerSatisfactionMessage);

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </span>\r\n");

WriteLiteral("                            ");

            
            #line 110 "..\..\Views\Provider\ProviderDetail.cshtml"
                       Write(CreateProgressBar(Model.EmployerSatisfactionMessage, (int)Model.EmployerSatisfaction));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                    </dd>\r\n                    " +
"<dt>Learner satisfaction:</dt>\r\n                    <dd>\r\n                      " +
"  <div");

WriteLiteral(" class=\"rating rating--inline\"");

WriteLiteral(">\r\n                            <span");

WriteLiteral(" id=\"learner-satisfaction\"");

WriteAttribute("class", Tuple.Create(" class=\"", 4957), Tuple.Create("\"", 4998)
, Tuple.Create(Tuple.Create("", 4965), Tuple.Create("rating-", 4965), true)
            
            #line 116 "..\..\Views\Provider\ProviderDetail.cshtml"
, Tuple.Create(Tuple.Create("", 4972), Tuple.Create<System.Object, System.Int32>(Model.LearnerSatisfaction
            
            #line default
            #line hidden
, 4972), false)
);

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 117 "..\..\Views\Provider\ProviderDetail.cshtml"
                           Write(Model.LearnerSatisfactionMessage);

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </span>\r\n");

WriteLiteral("                            ");

            
            #line 119 "..\..\Views\Provider\ProviderDetail.cshtml"
                       Write(CreateProgressBar(Model.LearnerSatisfactionMessage, (int)Model.LearnerSatisfaction));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n");

            
            #line 121 "..\..\Views\Provider\ProviderDetail.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 121 "..\..\Views\Provider\ProviderDetail.cshtml"
                         if (!(Model.EmployerSatisfactionMessage == "no data available" && Model.LearnerSatisfactionMessage == "no data available"))
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <span");

WriteLiteral(" class=\"satisfaction-source font-small\"");

WriteLiteral(">\r\n                                Source: <a");

WriteLiteral(" href=\"https://www.gov.uk/government/statistical-data-sets/fe-choices-performance" +
"-indicators\"");

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">Skills Funding Agency FE Choices</a>\r\n                            </span>\r\n");

            
            #line 126 "..\..\Views\Provider\ProviderDetail.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </dd>\r\n                </dl>\r\n            </div>\r\n           " +
" <div");

WriteLiteral(" class=\"panel-disclaimer\"");

WriteLiteral(@">
                <h4>Content disclaimer</h4>
                <p>
                    Education and Skills Funding Agency cannot guarantee the accuracy of course information on this site and makes 
                    no representations about the quality of any courses which appear on the site. Education and Skills Funding Agency 
                    is not liable for any losses suffered as a result of any party relying on the course information 
                    provided.
                </p>
            </div>
            <div");

WriteLiteral(" id=\"expand-collapse\"");

WriteLiteral(">\r\n               <details>\r\n                    <summary>Explain levels</summary" +
">\r\n                    <div");

WriteLiteral(" class=\"panel panel-border-narrow\"");

WriteLiteral(">\r\n                        <p>Apprenticeships are set at different levels of diff" +
"iculty from the equivalent of GCSE (level 2) up to postgraduate (level 7)</p>\r\n " +
"                       <p><a");

WriteLiteral(" href=\"https://www.gov.uk/what-different-qualification-levels-mean/overview\"");

WriteLiteral(" target=\"_blank\"");

WriteLiteral(" rel=\"external\"");

WriteLiteral(">More about levels</a></p>\r\n                    </div>\r\n                </details" +
">\r\n            </div>\r\n        </div>       \r\n    </div>\r\n</main>\r\n     \r\n\r\n");

        }
    }
}
#pragma warning restore 1591
