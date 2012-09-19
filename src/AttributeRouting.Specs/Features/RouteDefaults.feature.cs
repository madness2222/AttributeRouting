﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.8.1.0
//      SpecFlow Generator Version:1.8.0.0
//      Runtime Version:4.0.30319.17929
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace AttributeRouting.Specs.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Route Defaults")]
    public partial class RouteDefaultsFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "RouteDefaults.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Route Defaults", "", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        public virtual void FeatureBackground()
        {
#line 3
#line 4
 testRunner.Given("I have a new configuration object");
#line 5
 testRunner.And("I add the routes from the RouteDefaults controller");
#line 6
 testRunner.And("I add the routes from the HttpRouteDefaults controller");
#line 7
 testRunner.And("I generate the routes with this configuration");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Route default specified inline")]
        public virtual void RouteDefaultSpecifiedInline()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Route default specified inline", ((string[])(null)));
#line 9
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line 10
 testRunner.When("I fetch the routes for the RouteDefaults controller\'s InlineDefaults action");
#line 11
 testRunner.Then("the route url is \"InlineDefaults/{hello}/{goodnight}\"");
#line 12
 testRunner.Then("the default for \"hello\" is \"sun\"");
#line 13
 testRunner.Then("the default for \"goodnight\" is \"moon\"");
#line 14
 testRunner.When("I fetch the routes for the HttpRouteDefaults controller\'s InlineDefaults action");
#line 15
 testRunner.Then("the route url is \"InlineDefaults/{hello}/{goodnight}\"");
#line 16
 testRunner.Then("the default for \"hello\" is \"sun\"");
#line 17
 testRunner.Then("the default for \"goodnight\" is \"moon\"");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Optional parameters specified with a url parameter token")]
        public virtual void OptionalParametersSpecifiedWithAUrlParameterToken()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Optional parameters specified with a url parameter token", ((string[])(null)));
#line 19
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line 20
 testRunner.When("I fetch the routes for the RouteDefaults controller\'s Optionals action");
#line 21
 testRunner.Then("the route url is \"Optionals/{p1}\"");
#line 22
 testRunner.And("the parameter \"p1\" is optional");
#line 23
 testRunner.When("I fetch the routes for the HttpRouteDefaults controller\'s Optionals action");
#line 24
 testRunner.Then("the route url is \"Optionals/{p1}\"");
#line 25
 testRunner.And("the parameter \"p1\" is optional");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
