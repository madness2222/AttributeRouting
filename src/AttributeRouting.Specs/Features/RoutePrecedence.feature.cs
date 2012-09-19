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
    [NUnit.Framework.DescriptionAttribute("Route Precedence")]
    public partial class RoutePrecedenceFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "RoutePrecedence.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Route Precedence", "", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Route precedence among routes for an action using the Order property")]
        public virtual void RoutePrecedenceAmongRoutesForAnActionUsingTheOrderProperty()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Route precedence among routes for an action using the Order property", ((string[])(null)));
#line 3
this.ScenarioSetup(scenarioInfo);
#line 5
 testRunner.Given("I have registered the routes for the RoutePrecedenceAmongRoutesController");
#line 6
 testRunner.When("I fetch the routes for the RoutePrecedenceAmongRoutes controller\'s Index action");
#line 7
 testRunner.Then("the 1st route\'s url is \"Index/First\"");
#line 8
 testRunner.And("the 2nd route\'s url is \"Index/Second\"");
#line 9
 testRunner.And("the 3rd route\'s url is \"Index/Third\"");
#line 10
 testRunner.And("the 4th route\'s url is \"Index/Fourth\"");
#line 11
 testRunner.And("the 5th route\'s url is \"Index/Fifth\"");
#line 12
 testRunner.And("the 6th route\'s url is \"Index/Sixth\"");
#line 13
 testRunner.And("the 7th route\'s url is \"Index/Seventh\"");
#line 15
 testRunner.Given("I have registered the routes for the HttpRoutePrecedenceAmongRoutesController");
#line 16
 testRunner.When("I fetch the routes for the HttpRoutePrecedenceAmongRoutes controller\'s Get action" +
                    "");
#line 17
 testRunner.Then("the 1st route\'s url is \"Get/First\"");
#line 18
 testRunner.And("the 2nd route\'s url is \"Get/Second\"");
#line 19
 testRunner.And("the 3rd route\'s url is \"Get/Third\"");
#line 20
 testRunner.And("the 4th route\'s url is \"Get/Fourth\"");
#line 21
 testRunner.And("the 5th route\'s url is \"Get/Fifth\"");
#line 22
 testRunner.And("the 6th route\'s url is \"Get/Sixth\"");
#line 23
 testRunner.And("the 7th route\'s url is \"Get/Seventh\"");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Route precedence among actions within a controller using the Precedence property")]
        public virtual void RoutePrecedenceAmongActionsWithinAControllerUsingThePrecedenceProperty()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Route precedence among actions within a controller using the Precedence property", ((string[])(null)));
#line 25
this.ScenarioSetup(scenarioInfo);
#line 27
 testRunner.Given("I have registered the routes for the RoutePrecedenceAmongActionsController");
#line 28
 testRunner.When("I fetch the routes for the RoutePrecedenceAmongActions controller");
#line 29
 testRunner.Then("the 1st route\'s url is \"Route1\"");
#line 30
 testRunner.And("the 2nd route\'s url is \"Route2\"");
#line 31
 testRunner.And("the 3rd route\'s url is \"Route3\"");
#line 32
 testRunner.And("the 4th route\'s url is \"Route4\"");
#line 33
 testRunner.And("the 5th route\'s url is \"Route5\"");
#line 34
 testRunner.And("the 6th route\'s url is \"Route6\"");
#line 35
 testRunner.And("the 7th route\'s url is \"Route7\"");
#line 37
 testRunner.Given("I have registered the routes for the HttpRoutePrecedenceAmongActionsController");
#line 38
 testRunner.When("I fetch the routes for the HttpRoutePrecedenceAmongActions controller");
#line 39
 testRunner.Then("the 1st route\'s url is \"ApiRoute1\"");
#line 40
 testRunner.And("the 2nd route\'s url is \"ApiRoute2\"");
#line 41
 testRunner.And("the 3rd route\'s url is \"ApiRoute3\"");
#line 42
 testRunner.And("the 4th route\'s url is \"ApiRoute4\"");
#line 43
 testRunner.And("the 5th route\'s url is \"ApiRoute5\"");
#line 44
 testRunner.And("the 6th route\'s url is \"ApiRoute6\"");
#line 45
 testRunner.And("the 7th route\'s url is \"ApiRoute7\"");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Route precedence set for the site using the SitePrecedence property")]
        public virtual void RoutePrecedenceSetForTheSiteUsingTheSitePrecedenceProperty()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Route precedence set for the site using the SitePrecedence property", ((string[])(null)));
#line 47
this.ScenarioSetup(scenarioInfo);
#line 50
 testRunner.Given("I have a new configuration object");
#line 51
 testRunner.And("I add the routes from the RoutePrecedenceAmongControllers1 controller");
#line 52
 testRunner.And("I add the routes from the RoutePrecedenceAmongTheSitesRoutes controller");
#line 53
 testRunner.When("I generate the routes with this configuration");
#line 54
 testRunner.And("I fetch all the routes");
#line 55
 testRunner.Then("the 1st route\'s url is \"The-First-Route\"");
#line 56
 testRunner.Then("the 2nd route\'s url is \"Controller1/Index\"");
#line 57
 testRunner.Then("the 3rd route\'s url is \"The-Last-Route\"");
#line 59
 testRunner.Given("I have a new configuration object");
#line 60
 testRunner.And("I add the routes from the HttpRoutePrecedenceAmongControllers1 controller");
#line 61
 testRunner.And("I add the routes from the HttpRoutePrecedenceAmongTheSitesRoutes controller");
#line 62
 testRunner.When("I generate the routes with this configuration");
#line 63
 testRunner.And("I fetch all the routes");
#line 64
 testRunner.Then("the 1st route\'s url is \"The-First-Route\"");
#line 65
 testRunner.Then("the 2nd route\'s url is \"ApiController1/Get\"");
#line 66
 testRunner.Then("the 3rd route\'s url is \"The-Last-Route\"");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Route precedence set via Order, Precedence, and SitePrecedence properties")]
        public virtual void RoutePrecedenceSetViaOrderPrecedenceAndSitePrecedenceProperties()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Route precedence set via Order, Precedence, and SitePrecedence properties", ((string[])(null)));
#line 68
this.ScenarioSetup(scenarioInfo);
#line 70
 testRunner.Given("I have registered the routes for the RoutePrecedenceViaRoutePropertiesController");
#line 71
 testRunner.When("I fetch all the routes");
#line 72
 testRunner.Then("the 1st route\'s url is \"Route1\"");
#line 73
 testRunner.And("the 2nd route\'s url is \"Route2\"");
#line 74
 testRunner.And("the 3rd route\'s url is \"Route3\"");
#line 75
 testRunner.And("the 4th route\'s url is \"Route4\"");
#line 76
 testRunner.And("the 5th route\'s url is \"Route5\"");
#line 77
 testRunner.And("the 6th route\'s url is \"Route6\"");
#line 78
 testRunner.And("the 7th route\'s url is \"Route7\"");
#line 80
 testRunner.Given("I have registered the routes for the HttpRoutePrecedenceViaRoutePropertiesControl" +
                    "ler");
#line 81
 testRunner.When("I fetch all the routes");
#line 82
 testRunner.Then("the 1st route\'s url is \"ApiRoute1\"");
#line 83
 testRunner.And("the 2nd route\'s url is \"ApiRoute2\"");
#line 84
 testRunner.And("the 3rd route\'s url is \"ApiRoute3\"");
#line 85
 testRunner.And("the 4th route\'s url is \"ApiRoute4\"");
#line 86
 testRunner.And("the 5th route\'s url is \"ApiRoute5\"");
#line 87
 testRunner.And("the 6th route\'s url is \"ApiRoute6\"");
#line 88
 testRunner.And("the 7th route\'s url is \"ApiRoute7\"");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Route precedence among controllers added individually using the configuration api" +
            "")]
        public virtual void RoutePrecedenceAmongControllersAddedIndividuallyUsingTheConfigurationApi()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Route precedence among controllers added individually using the configuration api" +
                    "", ((string[])(null)));
#line 90
this.ScenarioSetup(scenarioInfo);
#line 92
 testRunner.Given("I have a new configuration object");
#line 93
 testRunner.And("I add the routes from the RoutePrecedenceAmongControllers1 controller");
#line 94
 testRunner.And("I add the routes from the RoutePrecedenceAmongControllers2 controller");
#line 95
 testRunner.And("I add the routes from the RoutePrecedenceAmongControllers3 controller");
#line 96
 testRunner.And("I add the Mvc routes from the executing assembly");
#line 97
 testRunner.And("I add the routes from the RoutePrecedenceAmongControllers4 controller");
#line 98
 testRunner.And("I add the routes from the RoutePrecedenceAmongControllers5 controller");
#line 99
 testRunner.When("I generate the routes with this configuration");
#line 100
 testRunner.Then("the routes from the RoutePrecedenceAmongControllers1 controller precede those fro" +
                    "m the RoutePrecedenceAmongControllers2 controller");
#line 101
 testRunner.And("the routes from the RoutePrecedenceAmongControllers2 controller precede those fro" +
                    "m the RoutePrecedenceAmongControllers3 controller");
#line 102
 testRunner.And("the routes from the RoutePrecedenceAmongControllers3 controller precede those fro" +
                    "m the StandardUsage controller");
#line 103
 testRunner.And("the routes from the StandardUsage controller precede those from the RoutePreceden" +
                    "ceAmongControllers4 controller");
#line 104
 testRunner.And("the routes from the RoutePrecedenceAmongControllers4 controller precede those fro" +
                    "m the RoutePrecedenceAmongControllers5 controller");
#line 105
 testRunner.And("no routes follow the routes from the RoutePrecedenceAmongControllers5 controller");
#line 107
 testRunner.Given("I have a new configuration object");
#line 108
 testRunner.And("I add the routes from the HttpRoutePrecedenceAmongControllers1 controller");
#line 109
 testRunner.And("I add the routes from the HttpRoutePrecedenceAmongControllers2 controller");
#line 110
 testRunner.And("I add the routes from the HttpRoutePrecedenceAmongControllers3 controller");
#line 111
 testRunner.And("I add the Http routes from the executing assembly");
#line 112
 testRunner.And("I add the routes from the HttpRoutePrecedenceAmongControllers4 controller");
#line 113
 testRunner.And("I add the routes from the HttpRoutePrecedenceAmongControllers5 controller");
#line 114
 testRunner.When("I generate the routes with this configuration");
#line 115
 testRunner.Then("the routes from the HttpRoutePrecedenceAmongControllers1 controller precede those" +
                    " from the HttpRoutePrecedenceAmongControllers2 controller");
#line 116
 testRunner.And("the routes from the HttpRoutePrecedenceAmongControllers2 controller precede those" +
                    " from the HttpRoutePrecedenceAmongControllers3 controller");
#line 117
 testRunner.And("the routes from the HttpStandardUsage controller precede those from the HttpRoute" +
                    "PrecedenceAmongControllers4 controller");
#line 118
 testRunner.And("the routes from the HttpRoutePrecedenceAmongControllers4 controller precede those" +
                    " from the HttpRoutePrecedenceAmongControllers5 controller");
#line 119
 testRunner.And("no routes follow the routes from the HttpRoutePrecedenceAmongControllers5 control" +
                    "ler");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Route precedence among controllers added by base type using the configuration api" +
            "")]
        public virtual void RoutePrecedenceAmongControllersAddedByBaseTypeUsingTheConfigurationApi()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Route precedence among controllers added by base type using the configuration api" +
                    "", ((string[])(null)));
#line 121
this.ScenarioSetup(scenarioInfo);
#line 123
 testRunner.Given("I have a new configuration object");
#line 124
 testRunner.And("I add the routes from controllers derived from the RoutePrecedenceAmongDerivedCon" +
                    "trollersBase controller");
#line 125
 testRunner.And("I add the routes from the RoutePrecedenceAmongControllers1 controller");
#line 126
 testRunner.When("I generate the routes with this configuration");
#line 127
 testRunner.Then("the routes from the RoutePrecedenceAmongDerivedControllers1 controller precede th" +
                    "ose from the RoutePrecedenceAmongControllers1 controller");
#line 128
 testRunner.And("the routes from the RoutePrecedenceAmongDerivedControllers2 controller precede th" +
                    "ose from the RoutePrecedenceAmongControllers1 controller");
#line 130
 testRunner.Given("I have a new configuration object");
#line 131
 testRunner.And("I add the routes from controllers derived from the HttpRoutePrecedenceAmongDerive" +
                    "dControllersBase controller");
#line 132
 testRunner.And("I add the routes from the HttpRoutePrecedenceAmongControllers1 controller");
#line 133
 testRunner.When("I generate the routes with this configuration");
#line 134
 testRunner.Then("the routes from the HttpRoutePrecedenceAmongDerivedControllers1 controller preced" +
                    "e those from the HttpRoutePrecedenceAmongControllers1 controller");
#line 135
 testRunner.And("the routes from the HttpRoutePrecedenceAmongDerivedControllers2 controller preced" +
                    "e those from the HttpRoutePrecedenceAmongControllers1 controller");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
