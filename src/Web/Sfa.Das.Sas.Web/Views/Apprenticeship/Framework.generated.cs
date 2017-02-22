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
    
    #line 1 "..\..\Views\Apprenticeship\Framework.cshtml"
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
    
    #line 2 "..\..\Views\Apprenticeship\Framework.cshtml"
    using Sfa.Das.Sas.Resources;
    
    #line default
    #line hidden
    using Sfa.Das.Sas.Web;
    
    #line 3 "..\..\Views\Apprenticeship\Framework.cshtml"
    using Sfa.Das.Sas.Web.Extensions;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Apprenticeship/Framework.cshtml")]
    public partial class Framework : System.Web.Mvc.WebViewPage<Sfa.Das.Sas.Web.ViewModels.FrameworkViewModel>
    {

#line 186 "..\..\Views\Apprenticeship\Framework.cshtml"
public System.Web.WebPages.HelperResult GetStandardProperty(string title, string id, string item, bool hideIfEmpty = false)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 187 "..\..\Views\Apprenticeship\Framework.cshtml"
 
if (!string.IsNullOrEmpty(item) || !hideIfEmpty)
{


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <dt>");


#line 190 "..\..\Views\Apprenticeship\Framework.cshtml"
WriteTo(__razor_helper_writer, title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dt>\n");

WriteLiteralTo(__razor_helper_writer, "        <dd");

WriteAttributeTo(__razor_helper_writer, "id", Tuple.Create(" id=\"", 8476), Tuple.Create("\"", 8484)

#line 191 "..\..\Views\Apprenticeship\Framework.cshtml"
, Tuple.Create(Tuple.Create("", 8481), Tuple.Create<System.Object, System.Int32>(id

#line default
#line hidden
, 8481), false)
);

WriteLiteralTo(__razor_helper_writer, ">item</dd>\n");


#line 192 "..\..\Views\Apprenticeship\Framework.cshtml"
}


#line default
#line hidden
});

#line 193 "..\..\Views\Apprenticeship\Framework.cshtml"
}
#line default
#line hidden

#line 195 "..\..\Views\Apprenticeship\Framework.cshtml"
public System.Web.WebPages.HelperResult GetFundingBandProperty(int value)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 196 "..\..\Views\Apprenticeship\Framework.cshtml"
 
    var fundingCapFormatted = value.ToString("C0", new CultureInfo("en-GB"));



#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <dt>Funding cap<br />(from 1 May 2017)</dt>\n");

WriteLiteralTo(__razor_helper_writer, "    <dd");

WriteLiteralTo(__razor_helper_writer, " id=\"funding-cap\"");

WriteLiteralTo(__razor_helper_writer, ">\n        Up to ");


#line 201 "..\..\Views\Apprenticeship\Framework.cshtml"
WriteTo(__razor_helper_writer, fundingCapFormatted);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " per apprentice.<br />\n        <a");

WriteLiteralTo(__razor_helper_writer, " href=\"https://www.gov.uk/government/publications/apprenticeship-levy-how-it-will" +
"-work/apprenticeship-levy-how-it-will-work\"");

WriteLiteralTo(__razor_helper_writer, " target=\"_blank\"");

WriteLiteralTo(__razor_helper_writer, ">More information about funding</a>\n    </dd>\n");


#line 204 "..\..\Views\Apprenticeship\Framework.cshtml"


#line default
#line hidden
});

#line 204 "..\..\Views\Apprenticeship\Framework.cshtml"
}
#line default
#line hidden

        public Framework()
        {
        }
        public override void Execute()
        {
            
            #line 6 "..\..\Views\Apprenticeship\Framework.cshtml"
  
    ViewBag.Title = @Model.Title + " - Apprenticeship Framework";
    ViewBag.Description = "The Find Apprenticeship Training service is for employers in England who want to find training courses for their apprentices and search for training providers.";

            
            #line default
            #line hidden
WriteLiteral("\n\n<main");

WriteLiteral(" id=\"content\"");

WriteLiteral(">\n    <div");

WriteLiteral(" class=\"grid-row\"");

WriteLiteral(">\n        <div");

WriteLiteral(" class=\"column-two-thirds\"");

WriteLiteral(">\n            <h1");

WriteLiteral(" class=\"heading-xlarge\"");

WriteLiteral(">\n");

WriteLiteral("                ");

            
            #line 15 "..\..\Views\Apprenticeship\Framework.cshtml"
           Write(Model.Title);

            
            #line default
            #line hidden
WriteLiteral("\n            </h1>\n            <p>\n                This information is taken from" +
" an apprenticeship framework. It sets out what qualifications the apprentice can" +
" achieve.\n            </p>\n");

            
            #line 20 "..\..\Views\Apprenticeship\Framework.cshtml"
            
            
            #line default
            #line hidden
            
            #line 20 "..\..\Views\Apprenticeship\Framework.cshtml"
             if (Model.ExpiryDateString != null)
            {


            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"notice\"");

WriteLiteral(">\n                    <i");

WriteLiteral(" class=\"icon icon-important\"");

WriteLiteral(">\n                        <span");

WriteLiteral(" class=\"visuallyhidden\"");

WriteLiteral(">Warning</span>\n                    </i>\n                    <strong");

WriteLiteral(" class=\"bold-small\"");

WriteLiteral(">\n                        This apprenticeship is closed to new starters from ");

            
            #line 28 "..\..\Views\Apprenticeship\Framework.cshtml"
                                                                      Write(Model.ExpiryDateString);

            
            #line default
            #line hidden
WriteLiteral("\n                    </strong>\n                </div>\n");

            
            #line 31 "..\..\Views\Apprenticeship\Framework.cshtml"

            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\n\n        <div");

WriteLiteral(" class=\"column-third\"");

WriteLiteral(">\n            <div");

WriteLiteral(" class=\"related-container\"");

WriteLiteral(">\n                <aside");

WriteLiteral(" class=\"hidden-for-mobile-tablet\"");

WriteLiteral(">\n\n                    <a");

WriteLiteral(" class=\"button ui-find-training-providers\"");

WriteLiteral(" rel=\"nofollow\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1442), Tuple.Create("\"", 1577)
            
            #line 39 "..\..\Views\Apprenticeship\Framework.cshtml"
      , Tuple.Create(Tuple.Create("", 1449), Tuple.Create<System.Object, System.Int32>(Url.Action("SearchForFrameworkProviders", "Apprenticeship", new {frameworkId = Model.FrameworkId, keywords = Model.SearchTerm})
            
            #line default
            #line hidden
, 1449), false)
);

WriteLiteral(">\n                        Find training providers\n                    </a>\n      " +
"          </aside>\n            </div>\n\n        </div>\n    </div>\n\n    <section>\n" +
"        <header>\n            <h2");

WriteLiteral(" class=\"heading-large\"");

WriteLiteral(">\n                Summary of this apprenticeship framework\n            </h2>\n    " +
"    </header>\n\n        <dl");

WriteLiteral(" class=\"data-list\"");

WriteLiteral(">\n");

            
            #line 56 "..\..\Views\Apprenticeship\Framework.cshtml"
            
            
            #line default
            #line hidden
            
            #line 56 "..\..\Views\Apprenticeship\Framework.cshtml"
             if (!string.IsNullOrEmpty(Model.FrameworkOverview))
            {

            
            #line default
            #line hidden
WriteLiteral("                <dt");

WriteLiteral(" class=\"overviewTitle\"");

WriteLiteral(">Overview of role</dt>\n");

WriteLiteral("                <dd");

WriteLiteral(" class=\"overviewText\"");

WriteLiteral(">");

            
            #line 59 "..\..\Views\Apprenticeship\Framework.cshtml"
                                    Write(Model.FrameworkOverview);

            
            #line default
            #line hidden
WriteLiteral(" </dd>\n");

            
            #line 60 "..\..\Views\Apprenticeship\Framework.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            ");

            
            #line 61 "..\..\Views\Apprenticeship\Framework.cshtml"
       Write(GetStandardProperty("Level", "level", $"{Model.Level} (equivalent to {EquivalenceLevelService.GetApprenticeshipLevel(Model.Level.ToString())})"));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("            ");

            
            #line 62 "..\..\Views\Apprenticeship\Framework.cshtml"
       Write(GetStandardProperty("Typical length", "length", Model.TypicalLengthMessage));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("            ");

            
            #line 63 "..\..\Views\Apprenticeship\Framework.cshtml"
       Write(GetFundingBandProperty(Model.MaxFunding));

            
            #line default
            #line hidden
WriteLiteral("\n            <dt>Entry requirements</dt>\n            <dd");

WriteLiteral(" class=\"entry-requirements\"");

WriteLiteral(">\n");

            
            #line 66 "..\..\Views\Apprenticeship\Framework.cshtml"
                
            
            #line default
            #line hidden
            
            #line 66 "..\..\Views\Apprenticeship\Framework.cshtml"
                 if (!string.IsNullOrEmpty(Model.EntryRequirements))
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div>");

            
            #line 68 "..\..\Views\Apprenticeship\Framework.cshtml"
                    Write(Model.EntryRequirements);

            
            #line default
            #line hidden
WriteLiteral("</div>\n");

            
            #line 69 "..\..\Views\Apprenticeship\Framework.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                <div>Your chosen training provider can advise you about entry req" +
"uirements for apprentices.</div>\n            </dd>\n\n            <dt>Suitable rol" +
"es for apprentices</dt>\n            <dd");

WriteLiteral(" class=\"job-roles\"");

WriteLiteral(">\n");

            
            #line 75 "..\..\Views\Apprenticeship\Framework.cshtml"
                
            
            #line default
            #line hidden
            
            #line 75 "..\..\Views\Apprenticeship\Framework.cshtml"
                 if (Model.JobRoles != null && Model.JobRoles.Any())
                {

            
            #line default
            #line hidden
WriteLiteral("                    <ul>\n");

            
            #line 78 "..\..\Views\Apprenticeship\Framework.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 78 "..\..\Views\Apprenticeship\Framework.cshtml"
                         foreach (var jobRole in Model.JobRoles.Take(5))
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <li>");

            
            #line 80 "..\..\Views\Apprenticeship\Framework.cshtml"
                           Write(jobRole);

            
            #line default
            #line hidden
WriteLiteral("</li>\n");

            
            #line 81 "..\..\Views\Apprenticeship\Framework.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                        ");

            
            #line 82 "..\..\Views\Apprenticeship\Framework.cshtml"
                         if (Model.JobRoles.Count() > 5)
                        {
                            foreach (var jobRole in Model.JobRoles.Skip(5))
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <li");

WriteLiteral(" class=\"default-hidden\"");

WriteLiteral(">");

            
            #line 86 "..\..\Views\Apprenticeship\Framework.cshtml"
                                                      Write(jobRole);

            
            #line default
            #line hidden
WriteLiteral("</li>\n");

            
            #line 87 "..\..\Views\Apprenticeship\Framework.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                            <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"showmore hidden\"");

WriteLiteral(">Show more</a>\n");

            
            #line 89 "..\..\Views\Apprenticeship\Framework.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </ul>\n");

            
            #line 91 "..\..\Views\Apprenticeship\Framework.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("\n                <div>\n                    Your chosen training provider can advi" +
"se you about the kinds of skills apprentices will learn.\n                </div>\n" +
"            </dd>\n            <dt>Qualifications</dt>\n            <dd>\n         " +
"       <div");

WriteLiteral(" class=\"qualifications\"");

WriteLiteral(">\n");

            
            #line 100 "..\..\Views\Apprenticeship\Framework.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 100 "..\..\Views\Apprenticeship\Framework.cshtml"
                     if (Model.CompetencyQualification != null && Model.CompetencyQualification.Any())
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" class=\"competencyQualifications\"");

WriteLiteral(">\n                            <p>Apprentices will achieve a practical (or \'compet" +
"ence\') qualification:</p>\n                            <ul>\n");

            
            #line 105 "..\..\Views\Apprenticeship\Framework.cshtml"
                                
            
            #line default
            #line hidden
            
            #line 105 "..\..\Views\Apprenticeship\Framework.cshtml"
                                 foreach (var qualification in Model.CompetencyQualification.Take(3))
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <li>");

            
            #line 107 "..\..\Views\Apprenticeship\Framework.cshtml"
                                   Write(qualification);

            
            #line default
            #line hidden
WriteLiteral("</li>\n");

            
            #line 108 "..\..\Views\Apprenticeship\Framework.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 110 "..\..\Views\Apprenticeship\Framework.cshtml"
                                
            
            #line default
            #line hidden
            
            #line 110 "..\..\Views\Apprenticeship\Framework.cshtml"
                                 if (Model.CompetencyQualification.Count() > 3)
                                {
                                    foreach (var qualification in Model.CompetencyQualification.Skip(3))
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        <li");

WriteLiteral(" class=\"default-hidden\"");

WriteLiteral(">");

            
            #line 114 "..\..\Views\Apprenticeship\Framework.cshtml"
                                                              Write(qualification);

            
            #line default
            #line hidden
WriteLiteral("</li>\n");

            
            #line 115 "..\..\Views\Apprenticeship\Framework.cshtml"
                                    }

            
            #line default
            #line hidden
WriteLiteral("                                    <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"showmore hidden\"");

WriteLiteral(">Show more</a>\n");

            
            #line 117 "..\..\Views\Apprenticeship\Framework.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral("                            </ul>\n                        </div>\n");

            
            #line 120 "..\..\Views\Apprenticeship\Framework.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 122 "..\..\Views\Apprenticeship\Framework.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 122 "..\..\Views\Apprenticeship\Framework.cshtml"
                     if (Model.KnowledgeQualification != null && Model.KnowledgeQualification.Any())
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" class=\"knowledgeQualifications\"");

WriteLiteral(">\n                            <p>Apprentices will also achieve a theory-based (or" +
" \'knowledge\') qualification:</p>\n                            <ul>\n");

            
            #line 127 "..\..\Views\Apprenticeship\Framework.cshtml"
                                
            
            #line default
            #line hidden
            
            #line 127 "..\..\Views\Apprenticeship\Framework.cshtml"
                                 foreach (var qualification in Model.KnowledgeQualification.Take(3))
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <li>");

            
            #line 129 "..\..\Views\Apprenticeship\Framework.cshtml"
                                   Write(qualification);

            
            #line default
            #line hidden
WriteLiteral("</li>\n");

            
            #line 130 "..\..\Views\Apprenticeship\Framework.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 132 "..\..\Views\Apprenticeship\Framework.cshtml"
                                
            
            #line default
            #line hidden
            
            #line 132 "..\..\Views\Apprenticeship\Framework.cshtml"
                                 if (Model.KnowledgeQualification.Count() > 3)
                                {
                                    foreach (var qualification in Model.KnowledgeQualification.Skip(3))
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        <li");

WriteLiteral(" class=\"default-hidden\"");

WriteLiteral(">");

            
            #line 136 "..\..\Views\Apprenticeship\Framework.cshtml"
                                                              Write(qualification);

            
            #line default
            #line hidden
WriteLiteral("</li>\n");

            
            #line 137 "..\..\Views\Apprenticeship\Framework.cshtml"
                                    }

            
            #line default
            #line hidden
WriteLiteral("                                    <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"showmore hidden\"");

WriteLiteral(">Show more</a>\n");

            
            #line 139 "..\..\Views\Apprenticeship\Framework.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral("                            </ul>\n                        </div>\n");

            
            #line 142 "..\..\Views\Apprenticeship\Framework.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 144 "..\..\Views\Apprenticeship\Framework.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 144 "..\..\Views\Apprenticeship\Framework.cshtml"
                     if (Model.CombinedQualificiation != null && Model.CombinedQualificiation.Any())
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" class=\"combinedQualification\"");

WriteLiteral(">\n                            <p>Apprentices will achieve a practical and theory-" +
"based (or \'combined\') qualification:</p>\n                            <ul>\n");

            
            #line 149 "..\..\Views\Apprenticeship\Framework.cshtml"
                                
            
            #line default
            #line hidden
            
            #line 149 "..\..\Views\Apprenticeship\Framework.cshtml"
                                 foreach (var qualification in Model.CombinedQualificiation.Take(3))
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <li>");

            
            #line 151 "..\..\Views\Apprenticeship\Framework.cshtml"
                                   Write(qualification);

            
            #line default
            #line hidden
WriteLiteral("</li>\n");

            
            #line 152 "..\..\Views\Apprenticeship\Framework.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 154 "..\..\Views\Apprenticeship\Framework.cshtml"
                                
            
            #line default
            #line hidden
            
            #line 154 "..\..\Views\Apprenticeship\Framework.cshtml"
                                 if (Model.CombinedQualificiation.Count() > 3)
                                {
                                    foreach (var qualification in Model.CombinedQualificiation.Skip(3))
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        <li");

WriteLiteral(" class=\"default-hidden\"");

WriteLiteral(">");

            
            #line 158 "..\..\Views\Apprenticeship\Framework.cshtml"
                                                              Write(qualification);

            
            #line default
            #line hidden
WriteLiteral("</li>\n");

            
            #line 159 "..\..\Views\Apprenticeship\Framework.cshtml"
                                    }

            
            #line default
            #line hidden
WriteLiteral("                                    <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"showmore hidden\"");

WriteLiteral(">Show more</a>\n");

            
            #line 161 "..\..\Views\Apprenticeship\Framework.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral("                            </ul>\n                        </div>\n");

            
            #line 164 "..\..\Views\Apprenticeship\Framework.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </div>\n\n");

            
            #line 167 "..\..\Views\Apprenticeship\Framework.cshtml"
                
            
            #line default
            #line hidden
            
            #line 167 "..\..\Views\Apprenticeship\Framework.cshtml"
                 if (Model.CompletionQualifications != string.Empty)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <p");

WriteLiteral(" class=\"completionQualifications\"");

WriteLiteral(">");

            
            #line 169 "..\..\Views\Apprenticeship\Framework.cshtml"
                                                   Write(Model.CompletionQualifications);

            
            #line default
            #line hidden
WriteLiteral("</p>\n");

            
            #line 170 "..\..\Views\Apprenticeship\Framework.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                <p");

WriteLiteral(" class=\"qualificationsStatic\"");

WriteLiteral(">Your chosen training provider can advise you about the qualifications open to ap" +
"prentices as they can change depending on individual and other circumstances.</p" +
">\n            </dd>\n\n            <dt>Professional registration</dt>\n            " +
"<dd>");

            
            #line 175 "..\..\Views\Apprenticeship\Framework.cshtml"
           Write(Model.ProfessionalRegistration);

            
            #line default
            #line hidden
WriteLiteral("</dd>\n        </dl>\n\n        <div");

WriteLiteral(" id=\"bottom-actions\"");

WriteLiteral(">\n            <a");

WriteLiteral(" class=\"button ui-find-training-providers\"");

WriteLiteral(" rel=\"nofollow\"");

WriteLiteral(" id=\"ga-find-provider-bottom\"");

WriteAttribute("href", Tuple.Create(" href=\"", 8062), Tuple.Create("\"", 8197)
            
            #line 179 "..\..\Views\Apprenticeship\Framework.cshtml"
                           , Tuple.Create(Tuple.Create("", 8069), Tuple.Create<System.Object, System.Int32>(Url.Action("SearchForFrameworkProviders", "Apprenticeship", new {frameworkId = Model.FrameworkId, keywords = Model.SearchTerm})
            
            #line default
            #line hidden
, 8069), false)
);

WriteLiteral(">\n                Find training providers\n            </a>\n        </div>\n    </s" +
"ection>\n</main>\n\n");

WriteLiteral("\n");

        }
    }
}
#pragma warning restore 1591
