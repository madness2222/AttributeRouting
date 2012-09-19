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
    [NUnit.Framework.DescriptionAttribute("Route Prefixes")]
    public partial class RoutePrefixesFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "RoutePrefixes.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Route Prefixes", "", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Generating prefixed routes")]
        public virtual void GeneratingPrefixedRoutes()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generating prefixed routes", ((string[])(null)));
#line 3
this.ScenarioSetup(scenarioInfo);
#line 5
 testRunner.Given("I have registered the routes for the RoutePrefixesController");
#line 6
 testRunner.When("I fetch the routes for the RoutePrefixes controller\'s Index action");
#line 7
 testRunner.Then("the route url is \"Prefix/Index\"");
#line 9
 testRunner.Given("I have registered the routes for the HttpRoutePrefixesController");
#line 10
 testRunner.When("I fetch the routes for the HttpRoutePrefixes controller\'s Get action");
#line 11
 testRunner.Then("the route url is \"ApiPrefix/Get\"");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generating prefixed routes when route urls specify a duplicate prefix")]
        public virtual void GeneratingPrefixedRoutesWhenRouteUrlsSpecifyADuplicatePrefix()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generating prefixed routes when route urls specify a duplicate prefix", ((string[])(null)));
#line 13
this.ScenarioSetup(scenarioInfo);
#line 15
 testRunner.Given("I have registered the routes for the RoutePrefixesController");
#line 16
 testRunner.When("I fetch the routes for the RoutePrefixes controller\'s DuplicatePrefix action");
#line 17
 testRunner.Then("the route url is \"Prefix/DuplicatePrefix\"");
#line 19
 testRunner.Given("I have registered the routes for the HttpRoutePrefixesController");
#line 20
 testRunner.When("I fetch the routes for the HttpRoutePrefixes controller\'s DuplicatePrefix action");
#line 21
 testRunner.Then("the route url is \"ApiPrefix/DuplicatePrefix\"");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generating absolute routes when a route prefix is defined")]
        public virtual void GeneratingAbsoluteRoutesWhenARoutePrefixIsDefined()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generating absolute routes when a route prefix is defined", ((string[])(null)));
#line 23
this.ScenarioSetup(scenarioInfo);
#line 25
 testRunner.Given("I have registered the routes for the RoutePrefixesController");
#line 26
 testRunner.When("I fetch the routes for the RoutePrefixes controller\'s Absolute action");
#line 27
 testRunner.Then("the route url is \"PrefixAbsolute\"");
#line 29
 testRunner.Given("I have registered the routes for the HttpRoutePrefixesController");
#line 30
 testRunner.When("I fetch the routes for the HttpRoutePrefixes controller\'s Absolute action");
#line 31
 testRunner.Then("the route url is \"ApiPrefixAbsolute\"");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generating prefixed routes when route url starts with the route prefix")]
        public virtual void GeneratingPrefixedRoutesWhenRouteUrlStartsWithTheRoutePrefix()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generating prefixed routes when route url starts with the route prefix", ((string[])(null)));
#line 33
this.ScenarioSetup(scenarioInfo);
#line 35
 testRunner.Given("I have registered the routes for the RoutePrefixesController");
#line 36
 testRunner.When("I fetch the routes for the RoutePrefixes controller\'s RouteBeginsWithRoutePrefix " +
                    "action");
#line 37
 testRunner.Then("the route url is \"Prefix/Prefixer\"");
#line 39
 testRunner.Given("I have registered the routes for the HttpRoutePrefixesController");
#line 40
 testRunner.When("I fetch the routes for the HttpRoutePrefixes controller\'s RouteBeginsWithRoutePre" +
                    "fix action");
#line 41
 testRunner.Then("the route url is \"ApiPrefix/ApiPrefixer\"");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generating prefixed area routes")]
        public virtual void GeneratingPrefixedAreaRoutes()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generating prefixed area routes", ((string[])(null)));
#line 43
this.ScenarioSetup(scenarioInfo);
#line 45
 testRunner.Given("I have registered the routes for the AreaRoutePrefixesController");
#line 46
 testRunner.When("I fetch the routes for the AreaRoutePrefixes controller\'s Index action");
#line 47
 testRunner.Then("the route url is \"Area/Prefix/Index\"");
#line 49
 testRunner.Given("I have registered the routes for the HttpAreaRoutePrefixesController");
#line 50
 testRunner.When("I fetch the routes for the HttpAreaRoutePrefixes controller\'s Get action");
#line 51
 testRunner.Then("the route url is \"ApiArea/ApiPrefix/Get\"");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generating prefixed area routes when route urls specify a duplicate prefix")]
        public virtual void GeneratingPrefixedAreaRoutesWhenRouteUrlsSpecifyADuplicatePrefix()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generating prefixed area routes when route urls specify a duplicate prefix", ((string[])(null)));
#line 53
this.ScenarioSetup(scenarioInfo);
#line 55
 testRunner.Given("I have registered the routes for the AreaRoutePrefixesController");
#line 56
 testRunner.When("I fetch the routes for the AreaRoutePrefixes controller\'s DuplicatePrefix action");
#line 57
 testRunner.Then("the route url is \"Area/Prefix/DuplicatePrefix\"");
#line 59
 testRunner.Given("I have registered the routes for the HttpAreaRoutePrefixesController");
#line 60
 testRunner.When("I fetch the routes for the HttpAreaRoutePrefixes controller\'s DuplicatePrefix act" +
                    "ion");
#line 61
 testRunner.Then("the route url is \"ApiArea/ApiPrefix/DuplicatePrefix\"");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generating absolute routes when a route area and route prefix is defined")]
        public virtual void GeneratingAbsoluteRoutesWhenARouteAreaAndRoutePrefixIsDefined()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generating absolute routes when a route area and route prefix is defined", ((string[])(null)));
#line 63
this.ScenarioSetup(scenarioInfo);
#line 65
 testRunner.Given("I have registered the routes for the AreaRoutePrefixesController");
#line 66
 testRunner.When("I fetch the routes for the AreaRoutePrefixes controller\'s Absolute action");
#line 67
 testRunner.Then("the route url is \"AreaPrefixAbsolute\"");
#line 69
 testRunner.Given("I have registered the routes for the HttpAreaRoutePrefixesController");
#line 70
 testRunner.When("I fetch the routes for the HttpAreaRoutePrefixes controller\'s Absolute action");
#line 71
 testRunner.Then("the route url is \"ApiAreaPrefixAbsolute\"");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generating routes when a route area and route prefix are defined and the action r" +
            "especifies the area url")]
        public virtual void GeneratingRoutesWhenARouteAreaAndRoutePrefixAreDefinedAndTheActionRespecifiesTheAreaUrl()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generating routes when a route area and route prefix are defined and the action r" +
                    "especifies the area url", ((string[])(null)));
#line 73
this.ScenarioSetup(scenarioInfo);
#line 75
 testRunner.Given("I have registered the routes for the AreaRoutePrefixesController");
#line 76
 testRunner.When("I fetch the routes for the AreaRoutePrefixes controller\'s RelativeUrlIsAreaUrl ac" +
                    "tion");
#line 77
 testRunner.Then("the route url is \"Area/Prefix/Area\"");
#line 79
 testRunner.Given("I have registered the routes for the HttpAreaRoutePrefixesController");
#line 80
 testRunner.When("I fetch the routes for the HttpAreaRoutePrefixes controller\'s RelativeUrlIsAreaUr" +
                    "l action");
#line 81
 testRunner.Then("the route url is \"ApiArea/ApiPrefix/ApiArea\"");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
