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
    
    #line 2 "..\..\Views\Provider\Detail.cshtml"
    using Sfa.Das.Sas.Resources;
    
    #line default
    #line hidden
    using Sfa.Das.Sas.Web;
    
    #line 1 "..\..\Views\Provider\Detail.cshtml"
    using Sfa.Das.Sas.Web.Extensions;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Provider/Detail.cshtml")]
    public partial class Detail : System.Web.Mvc.WebViewPage<Sfa.Das.Sas.Web.ViewModels.ProviderViewModel>
    {

#line 97 "..\..\Views\Provider\Detail.cshtml"
public System.Web.WebPages.HelperResult ShowTrainingLocation(string title)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 98 "..\..\Views\Provider\Detail.cshtml"
 
if (@Model != null)
{


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <dt");

WriteLiteralTo(__razor_helper_writer, " class=\"training-location-title\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 101 "..\..\Views\Provider\Detail.cshtml"
              WriteTo(__razor_helper_writer, title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dt>\r\n");


#line 102 "..\..\Views\Provider\Detail.cshtml"

    if (@Model.DeliveryModes.Count == 1 && @Model.DeliveryModes.Contains("100PercentEmployer"))
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <dd");

WriteLiteralTo(__razor_helper_writer, " id=\"training-location\"");

WriteLiteralTo(__razor_helper_writer, " class=\"training-location\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n            Training takes place at your location\r\n        </dd>\r\n");


#line 108 "..\..\Views\Provider\Detail.cshtml"
    }
    else
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <dd");

WriteLiteralTo(__razor_helper_writer, " id=\"training-location\"");

WriteLiteralTo(__razor_helper_writer, " class=\"training-location\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n");

WriteLiteralTo(__razor_helper_writer, "            ");


#line 112 "..\..\Views\Provider\Detail.cshtml"
WriteTo(__razor_helper_writer, Model.Location.LocationName);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " ");


#line 112 "..\..\Views\Provider\Detail.cshtml"
           WriteTo(__razor_helper_writer, Model.Address.Address1);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " ");


#line 112 "..\..\Views\Provider\Detail.cshtml"
                                   WriteTo(__razor_helper_writer, Model.Address.Address2);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " ");


#line 112 "..\..\Views\Provider\Detail.cshtml"
                                                           WriteTo(__razor_helper_writer, Model.Address.Postcode);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n        </dd>\r\n");


#line 114 "..\..\Views\Provider\Detail.cshtml"
    }
}


#line default
#line hidden
});

#line 116 "..\..\Views\Provider\Detail.cshtml"
}
#line default
#line hidden

#line 118 "..\..\Views\Provider\Detail.cshtml"
public System.Web.WebPages.HelperResult GetStandardPropertyHtml(string title, string id, string item, bool hideIfEmpty = false)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 119 "..\..\Views\Provider\Detail.cshtml"
 
    if (!string.IsNullOrEmpty(item) || !hideIfEmpty)
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <dt");

WriteLiteralTo(__razor_helper_writer, " class=\"phone-title\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 122 "..\..\Views\Provider\Detail.cshtml"
  WriteTo(__razor_helper_writer, title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dt>\r\n");

WriteLiteralTo(__razor_helper_writer, "        <dd");

WriteAttributeTo(__razor_helper_writer, "id", Tuple.Create(" id=\"", 4852), Tuple.Create("\"", 4860)

#line 123 "..\..\Views\Provider\Detail.cshtml"
, Tuple.Create(Tuple.Create("", 4857), Tuple.Create<System.Object, System.Int32>(id

#line default
#line hidden
, 4857), false)
);

WriteLiteralTo(__razor_helper_writer, " class=\"phone\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 123 "..\..\Views\Provider\Detail.cshtml"
     WriteTo(__razor_helper_writer, Html.Raw(item));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dd>\r\n");


#line 124 "..\..\Views\Provider\Detail.cshtml"
    }


#line default
#line hidden
});

#line 125 "..\..\Views\Provider\Detail.cshtml"
}
#line default
#line hidden

#line 127 "..\..\Views\Provider\Detail.cshtml"
public System.Web.WebPages.HelperResult GetEmailPropertyHtml(string title, string id, string item, bool hideIfEmpty = false)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 128 "..\..\Views\Provider\Detail.cshtml"
 
if (!string.IsNullOrEmpty(item) || !hideIfEmpty)
{


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <dt");

WriteLiteralTo(__razor_helper_writer, " class=\"email-title\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 131 "..\..\Views\Provider\Detail.cshtml"
  WriteTo(__razor_helper_writer, title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dt>\r\n");

WriteLiteralTo(__razor_helper_writer, "        <dd");

WriteAttributeTo(__razor_helper_writer, "id", Tuple.Create(" id=\"", 5116), Tuple.Create("\"", 5124)

#line 132 "..\..\Views\Provider\Detail.cshtml"
, Tuple.Create(Tuple.Create("", 5121), Tuple.Create<System.Object, System.Int32>(id

#line default
#line hidden
, 5121), false)
);

WriteLiteralTo(__razor_helper_writer, " class=\"email\"");

WriteLiteralTo(__razor_helper_writer, "><a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 5142), Tuple.Create("\"", 5171)
, Tuple.Create(Tuple.Create("", 5149), Tuple.Create("mailto:", 5149), true)

#line 132 "..\..\Views\Provider\Detail.cshtml"
, Tuple.Create(Tuple.Create("", 5156), Tuple.Create<System.Object, System.Int32>(Html.Raw(item)

#line default
#line hidden
, 5156), false)
);

WriteLiteralTo(__razor_helper_writer, ">");


#line 132 "..\..\Views\Provider\Detail.cshtml"
                                      WriteTo(__razor_helper_writer, Html.Raw(item));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</a></dd>\r\n");


#line 133 "..\..\Views\Provider\Detail.cshtml"
}


#line default
#line hidden
});

#line 134 "..\..\Views\Provider\Detail.cshtml"
}
#line default
#line hidden

#line 136 "..\..\Views\Provider\Detail.cshtml"
public System.Web.WebPages.HelperResult GetStandardPropertyAsLinkHtml(string title, string cssClass, string classTitle, string classIdentifier, string url, string urlTitle = "")
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 137 "..\..\Views\Provider\Detail.cshtml"
 
    if (!string.IsNullOrEmpty(url))
    {
        var linkProtocol = url.StartsWith("http") ? string.Empty : "http://";


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <dt");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 5491), Tuple.Create("\"", 5510)

#line 141 "..\..\Views\Provider\Detail.cshtml"
, Tuple.Create(Tuple.Create("", 5499), Tuple.Create<System.Object, System.Int32>(classTitle

#line default
#line hidden
, 5499), false)
);

WriteLiteralTo(__razor_helper_writer, ">");


#line 141 "..\..\Views\Provider\Detail.cshtml"
  WriteTo(__razor_helper_writer, title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dt>\r\n");

WriteLiteralTo(__razor_helper_writer, "        <dd>\r\n            <a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 5553), Tuple.Create("\"", 5577)

#line 143 "..\..\Views\Provider\Detail.cshtml"
, Tuple.Create(Tuple.Create("", 5560), Tuple.Create<System.Object, System.Int32>(linkProtocol

#line default
#line hidden
, 5560), false)

#line 143 "..\..\Views\Provider\Detail.cshtml"
, Tuple.Create(Tuple.Create("", 5573), Tuple.Create<System.Object, System.Int32>(url

#line default
#line hidden
, 5573), false)
);

WriteLiteralTo(__razor_helper_writer, " rel=\"external\"");

WriteLiteralTo(__razor_helper_writer, " target=\"_blank\"");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 5609), Tuple.Create("\"", 5643)

#line 143 "..\..\Views\Provider\Detail.cshtml"
, Tuple.Create(Tuple.Create("", 5617), Tuple.Create<System.Object, System.Int32>(cssClass

#line default
#line hidden
, 5617), false)

#line 143 "..\..\Views\Provider\Detail.cshtml"
       , Tuple.Create(Tuple.Create(" ", 5626), Tuple.Create<System.Object, System.Int32>(classIdentifier

#line default
#line hidden
, 5627), false)
);

WriteLiteralTo(__razor_helper_writer, ">\r\n");


#line 144 "..\..\Views\Provider\Detail.cshtml"
                

#line default
#line hidden

#line 144 "..\..\Views\Provider\Detail.cshtml"
                 if (string.IsNullOrEmpty(urlTitle))
                {
                    

#line default
#line hidden

#line 146 "..\..\Views\Provider\Detail.cshtml"
WriteTo(__razor_helper_writer, url);


#line default
#line hidden

#line 146 "..\..\Views\Provider\Detail.cshtml"
                        
                }
                else
                {
                    

#line default
#line hidden

#line 150 "..\..\Views\Provider\Detail.cshtml"
WriteTo(__razor_helper_writer, urlTitle);


#line default
#line hidden

#line 150 "..\..\Views\Provider\Detail.cshtml"
                             
                }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            </a>\r\n        </dd>\r\n");


#line 154 "..\..\Views\Provider\Detail.cshtml"
    }


#line default
#line hidden
});

#line 155 "..\..\Views\Provider\Detail.cshtml"
}
#line default
#line hidden

#line 156 "..\..\Views\Provider\Detail.cshtml"
public System.Web.WebPages.HelperResult GetSatisfactionsHtml()
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 157 "..\..\Views\Provider\Detail.cshtml"
 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <p>\r\n        <b>Employer satisfaction:</b>\r\n        <span");

WriteLiteralTo(__razor_helper_writer, " id=\"employer-satisfaction\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n");

WriteLiteralTo(__razor_helper_writer, "            ");


#line 161 "..\..\Views\Provider\Detail.cshtml"
WriteTo(__razor_helper_writer, Model.EmployerSatisfactionMessage);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n        </span>\r\n");


#line 163 "..\..\Views\Provider\Detail.cshtml"
        

#line default
#line hidden

#line 163 "..\..\Views\Provider\Detail.cshtml"
         if (@Model.EmployerSatisfactionMessage != "No data available")
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <div");

WriteLiteralTo(__razor_helper_writer, " class=\"progress-container\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n                <div");

WriteLiteralTo(__razor_helper_writer, " class=\"progressbar\"");

WriteAttributeTo(__razor_helper_writer, "style", Tuple.Create(" style=\"", 6260), Tuple.Create("\"", 6303)
, Tuple.Create(Tuple.Create("", 6268), Tuple.Create("width:", 6268), true)

#line 166 "..\..\Views\Provider\Detail.cshtml"
, Tuple.Create(Tuple.Create(" ", 6274), Tuple.Create<System.Object, System.Int32>(Model.EmployerSatisfaction

#line default
#line hidden
, 6275), false)
, Tuple.Create(Tuple.Create("", 6302), Tuple.Create("%", 6302), true)
);

WriteLiteralTo(__razor_helper_writer, "></div>\r\n            </div>\r\n");


#line 168 "..\..\Views\Provider\Detail.cshtml"
        }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    </p>\r\n");


#line 170 "..\..\Views\Provider\Detail.cshtml"



#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <p>\r\n        <b>Learner satisfaction:</b>\r\n        <span");

WriteLiteralTo(__razor_helper_writer, " id=\"learner-satisfaction\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n");

WriteLiteralTo(__razor_helper_writer, "            ");


#line 174 "..\..\Views\Provider\Detail.cshtml"
WriteTo(__razor_helper_writer, Model.LearnerSatisfactionMessage);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n        </span>\r\n");


#line 176 "..\..\Views\Provider\Detail.cshtml"
        

#line default
#line hidden

#line 176 "..\..\Views\Provider\Detail.cshtml"
         if (@Model.LearnerSatisfactionMessage != "No data available")
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <div");

WriteLiteralTo(__razor_helper_writer, " class=\"progress-container\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n                <div");

WriteLiteralTo(__razor_helper_writer, " class=\"progressbar\"");

WriteAttributeTo(__razor_helper_writer, "style", Tuple.Create(" style=\"", 6678), Tuple.Create("\"", 6719)
, Tuple.Create(Tuple.Create("", 6686), Tuple.Create("width:", 6686), true)

#line 179 "..\..\Views\Provider\Detail.cshtml"
, Tuple.Create(Tuple.Create("", 6692), Tuple.Create<System.Object, System.Int32>(Model.LearnerSatisfaction

#line default
#line hidden
, 6692), false)
, Tuple.Create(Tuple.Create("", 6718), Tuple.Create("%", 6718), true)
);

WriteLiteralTo(__razor_helper_writer, "></div>\r\n            </div>\r\n");


#line 181 "..\..\Views\Provider\Detail.cshtml"
        }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n    </p>\r\n");


#line 184 "..\..\Views\Provider\Detail.cshtml"


#line default
#line hidden
});

#line 184 "..\..\Views\Provider\Detail.cshtml"
}
#line default
#line hidden

#line 186 "..\..\Views\Provider\Detail.cshtml"
public System.Web.WebPages.HelperResult GetDeliveryModesHtml(string title, List<string> items, bool hideIfEmpty = false)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 187 "..\..\Views\Provider\Detail.cshtml"
 
    if (items != null)
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <dt");

WriteLiteralTo(__razor_helper_writer, " class=\"training-structure\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 190 "..\..\Views\Provider\Detail.cshtml"
         WriteTo(__razor_helper_writer, title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dt>\r\n");

WriteLiteralTo(__razor_helper_writer, "        <dd");

WriteLiteralTo(__razor_helper_writer, " id=\"delivery-modes\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n            <ul>\r\n");


#line 193 "..\..\Views\Provider\Detail.cshtml"
                

#line default
#line hidden

#line 193 "..\..\Views\Provider\Detail.cshtml"
                 if (items.Exists(m => m.Equals("DayRelease")))
                {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "                    <li");

WriteLiteralTo(__razor_helper_writer, " class=\"day-release\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 195 "..\..\Views\Provider\Detail.cshtml"
              WriteTo(__razor_helper_writer, Html.Raw("day release"));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</li>\r\n");


#line 196 "..\..\Views\Provider\Detail.cshtml"
                }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "                ");


#line 197 "..\..\Views\Provider\Detail.cshtml"
                 if (items.Exists(m => m.Equals("BlockRelease")))
                {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "                    <li");

WriteLiteralTo(__razor_helper_writer, " class=\"block-release\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 199 "..\..\Views\Provider\Detail.cshtml"
                WriteTo(__razor_helper_writer, Html.Raw("block release"));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</li>\r\n");


#line 200 "..\..\Views\Provider\Detail.cshtml"
                }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "                ");


#line 201 "..\..\Views\Provider\Detail.cshtml"
                 if (items.Exists(m => m.Equals("100PercentEmployer")))
                {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "                    <li");

WriteLiteralTo(__razor_helper_writer, " class=\"hundred-percent-employer\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 203 "..\..\Views\Provider\Detail.cshtml"
                           WriteTo(__razor_helper_writer, Html.Raw("at your location"));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</li>\r\n");


#line 204 "..\..\Views\Provider\Detail.cshtml"
                }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            </ul>\r\n                    <details>\r\n                        <summar" +
"y>Explain training options</summary>\r\n                        <div");

WriteLiteralTo(__razor_helper_writer, " class=\"panel panel-border-narrow\"");

WriteLiteralTo(__razor_helper_writer, ">   \r\n                            <p>\r\n                                <span");

WriteLiteralTo(__razor_helper_writer, " class=\"bold-small\"");

WriteLiteralTo(__razor_helper_writer, ">Day release:</span> eg one day a week at the training provider\'s location.\r\n    " +
"                        </p>\r\n                            <p>\r\n                 " +
"               <span");

WriteLiteralTo(__razor_helper_writer, " class=\"bold-small\"");

WriteLiteralTo(__razor_helper_writer, ">Block release:</span> eg 3-4 weeks at the training provider\'s location.\r\n       " +
"                     </p>\r\n                            <p>\r\n                    " +
"            <span");

WriteLiteralTo(__razor_helper_writer, " class=\"bold-small\"");

WriteLiteralTo(__razor_helper_writer, ">At your location:</span> the provider comes to your workplace.\r\n                " +
"            </p>\r\n                        </div>\r\n                    </details>" +
"                \r\n        </dd>\r\n");


#line 221 "..\..\Views\Provider\Detail.cshtml"
    }


#line default
#line hidden
});

#line 222 "..\..\Views\Provider\Detail.cshtml"
}
#line default
#line hidden

        public Detail()
        {
        }
        public override void Execute()
        {
            
            #line 5 "..\..\Views\Provider\Detail.cshtml"
  
    ViewBag.Title = "Provider - " + @Model.Name;

            
            #line default
            #line hidden
WriteLiteral("\r\n<main");

WriteLiteral(" id=\"content\"");

WriteLiteral(" class=\"provider-detail\"");

WriteLiteral(">\r\n\r\n    <p");

WriteLiteral(" class=\"small-btm-margin\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 11 "..\..\Views\Provider\Detail.cshtml"
   Write(Html.RenderAIfExists(@Model.SearchResultLink?.Title, @Model.SearchResultLink?.Url, "link-back"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </p>\r\n\r\n    <div");

WriteLiteral(" class=\"grid-row\"");

WriteLiteral(">\r\n\r\n        <div");

WriteLiteral(" class=\"column-two-thirds\"");

WriteLiteral(">\r\n            <div>\r\n                <h1");

WriteLiteral(" class=\"heading-xlarge\"");

WriteLiteral(" id=\"provider-name\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 19 "..\..\Views\Provider\Detail.cshtml"
               Write(Model.Name);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </h1>\r\n                <div");

WriteLiteral(" id=\"marketing\"");

WriteLiteral(" class=\"provider-marketing-info\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 22 "..\..\Views\Provider\Detail.cshtml"
               Write(Html.MarkdownToHtml(Model.ProviderMarketingInfo));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n\r\n            </div>\r\n\r\n\r\n            <section>\r\n      " +
"          <header");

WriteLiteral(" class=\"hgroup\"");

WriteLiteral(">\r\n                    <h2");

WriteLiteral(" class=\"heading-large apprenticeship-name-level\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 31 "..\..\Views\Provider\Detail.cshtml"
                   Write(Model.ApprenticeshipNameWithLevel);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </h2>\r\n                    <b>Level:</b>\r\n                 " +
"   <span>\r\n");

WriteLiteral("                        ");

            
            #line 35 "..\..\Views\Provider\Detail.cshtml"
                   Write(Model.ApprenticeshipLevel);

            
            #line default
            #line hidden
WriteLiteral(" (equivalent to ");

            
            #line 35 "..\..\Views\Provider\Detail.cshtml"
                                                             Write(EquivalenveLevelService.GetApprenticeshipLevel(@Model.ApprenticeshipLevel));

            
            #line default
            #line hidden
WriteLiteral(")\r\n                    </span>\r\n                </header>\r\n                <dl");

WriteLiteral(" class=\"data-list\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 39 "..\..\Views\Provider\Detail.cshtml"
               Write(GetStandardPropertyAsLinkHtml("Website", "course-link", "apprenticeshipContactTitle", "apprenticeshipContact", @Model.Apprenticeship.ApprenticeshipInfoUrl, "training provider website"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                    ");

            
            #line 40 "..\..\Views\Provider\Detail.cshtml"
               Write(GetStandardPropertyHtml("Phone", "phone", Model.ContactInformation.Phone));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                    ");

            
            #line 41 "..\..\Views\Provider\Detail.cshtml"
               Write(GetEmailPropertyHtml("Email", "email", Model.ContactInformation.Email));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                    ");

            
            #line 42 "..\..\Views\Provider\Detail.cshtml"
               Write(GetStandardPropertyAsLinkHtml("Contact page", "contact-link", "providerContactTitle", "providerContact", @Model.ContactInformation.ContactUsUrl, "contact this training provider"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                    ");

            
            #line 43 "..\..\Views\Provider\Detail.cshtml"
               Write(GetDeliveryModesHtml("Training options", Model.DeliveryModes));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                    ");

            
            #line 44 "..\..\Views\Provider\Detail.cshtml"
               Write(ShowTrainingLocation("Training location"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </dl>\r\n\r\n            </section>\r\n\r\n            <section>\r\n     " +
"           <header>\r\n                    <h2");

WriteLiteral(" class=\"heading-large\"");

WriteLiteral(">Apprenticeship training information</h2>\r\n                </header>\r\n           " +
"     <article");

WriteLiteral(" class=\"apprenticeship-marketing-info\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 54 "..\..\Views\Provider\Detail.cshtml"
               Write(Html.MarkdownToHtml(Model.Apprenticeship.ApprenticeshipMarketingInfo));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </article>\r\n            </section>\r\n\r\n\r\n\r\n            <div");

WriteLiteral(" class=\"survey-panel\"");

WriteLiteral(">\r\n                <h2");

WriteLiteral(" class=\"bold-large\"");

WriteLiteral(@">
                    Give us your feedback
                </h2>
                <p>
                    This is a new service and your feedback will help us improve it.<br />
                    Use the link below to take part in a short survey.
                </p>
                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2852), Tuple.Create("\"", 2875)
            
            #line 68 "..\..\Views\Provider\Detail.cshtml"
, Tuple.Create(Tuple.Create("", 2859), Tuple.Create<System.Object, System.Int32>(Model.SurveyUrl
            
            #line default
            #line hidden
, 2859), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(" class=\"button\"");

WriteLiteral(">Take the survey</a>\r\n            </div>\r\n            <aside");

WriteLiteral(" class=\"disclaimer\"");

WriteLiteral(">\r\n                <h4");

WriteLiteral(" class=\"heading-small\"");

WriteLiteral(@">Content disclaimer</h4>
                <p>
                    Skills Funding Agency cannot guarantee the accuracy of course information on this site and makes no representations about the quality of any courses which appear on the site. The Skills Funding Agency is not liable for any losses suffered as a result of any party relying on the course information provided.
                </p>
            </aside>

        </div>


        <div");

WriteLiteral(" class=\"column-third\"");

WriteLiteral(">\r\n");

            
            #line 81 "..\..\Views\Provider\Detail.cshtml"
            
            
            #line default
            #line hidden
            
            #line 81 "..\..\Views\Provider\Detail.cshtml"
             using (Html.BeginForm("StandardResults", "Provider", FormMethod.Get, new { @class = "search-box" }))
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"related-container\"");

WriteLiteral(">\r\n                    <aside");

WriteLiteral(" class=\"related\"");

WriteLiteral(">\r\n                        <h2");

WriteLiteral(" class=\"heading-medium\"");

WriteLiteral(">\r\n                            Training provider quality assessment\r\n            " +
"            </h2>\r\n");

WriteLiteral("                        ");

            
            #line 88 "..\..\Views\Provider\Detail.cshtml"
                   Write(GetSatisfactionsHtml());

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </aside>\r\n                </div>\r\n");

            
            #line 91 "..\..\Views\Provider\Detail.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n    </div>\r\n\r\n</main>\r\n\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591