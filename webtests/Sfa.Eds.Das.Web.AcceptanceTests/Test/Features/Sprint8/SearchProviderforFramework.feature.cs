﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Sfa.Eds.Das.Web.AcceptanceTests.Test.Features.Sprint8
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Search Provider by Postcode on FrameworkDetailPage")]
    public partial class SearchProviderByPostcodeOnFrameworkDetailPageFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "SearchProviderforFramework.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Search Provider by Postcode on FrameworkDetailPage", "In order to choose from a provider list\r\nAs an employer\r\nI want to be able to sea" +
                    "rch provider in my area by entering postcode", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Validate post code field mandatory on framework detail page")]
        public virtual void ValidatePostCodeFieldMandatoryOnFrameworkDetailPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Validate post code field mandatory on framework detail page", ((string[])(null)));
#line 12
this.ScenarioSetup(scenarioInfo);
#line 13
testRunner.Given("I am on Framework \'40322\' detail page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 14
testRunner.When("I search Search for provider", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 15
testRunner.Then("I should see error message \"This field can\'t be blank\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Search DUDLEY METROPOLITAN BOROUGH COUNCIL Provider by postcode falling on Provid" +
            "er radius")]
        [NUnit.Framework.TestCaseAttribute("BL1 1RU", "40335", null)]
        public virtual void SearchDUDLEYMETROPOLITANBOROUGHCOUNCILProviderByPostcodeFallingOnProviderRadius(string postcode, string id, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Search DUDLEY METROPOLITAN BOROUGH COUNCIL Provider by postcode falling on Provid" +
                    "er radius", exampleTags);
#line 19
this.ScenarioSetup(scenarioInfo);
#line 20
testRunner.Given(string.Format("I am on Framework \'{0}\' detail page", id), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 21
testRunner.And(string.Format("I enter \'{0}\' in provider search box", postcode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
testRunner.When("I search Search for provider", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 23
testRunner.Then("I should see provider \"DUDLEY METROPOLITAN BOROUGH COUNCIL\" in provider results p" +
                    "age.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Search Provider by postcode outside  Provider radius 80 miles")]
        [NUnit.Framework.TestCaseAttribute("LS21 3JS", "40335", null)]
        public virtual void SearchProviderByPostcodeOutsideProviderRadius80Miles(string postcode, string id, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Search Provider by postcode outside  Provider radius 80 miles", exampleTags);
#line 30
this.ScenarioSetup(scenarioInfo);
#line 31
testRunner.Given(string.Format("I am on Framework \'{0}\' detail page", id), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 32
testRunner.And(string.Format("I enter \'{0}\' in provider search box", postcode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
testRunner.When("I search Search for provider", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 34
testRunner.Then("I should not see provider \"DUDLEY METROPOLITAN BOROUGH COUNCIL\" in provider resul" +
                    "ts page.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Search Provider by postcode falling inside Provider radius")]
        [NUnit.Framework.IgnoreAttribute()]
        [NUnit.Framework.TestCaseAttribute("DE73 8EN", "40322", null)]
        public virtual void SearchProviderByPostcodeFallingInsideProviderRadius(string postcode, string id, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "ignore"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Search Provider by postcode falling inside Provider radius", @__tags);
#line 45
this.ScenarioSetup(scenarioInfo);
#line 46
testRunner.Given(string.Format("I am on Framework \'{0}\' detail page", id), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 47
testRunner.And(string.Format("I enter \'{0}\' in provider search box", postcode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 48
testRunner.When("I search Search for provider", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 49
testRunner.Then("I should see provider \"ASPIRE ACHIEVE ADVANCE LIMITED\" in provider results page.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 50
testRunner.And("I should see provider \"MILLBROOK MANAGEMENT SERVICES LIMITED\" in provider results" +
                    " page.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
