﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Expidia.com.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Exedia Flight Booking")]
    public partial class ExediaFlightBookingFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ExpediaFeaturs.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Exedia Flight Booking", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
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
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Select Flight")]
        [NUnit.Framework.CategoryAttribute("Expedia")]
        [NUnit.Framework.TestCaseAttribute("MLA", "LON", "ROME", "02/17/2020", "02/20/2020", "02/24/2020", "4", null)]
        public virtual void SelectFlight(string fIRST, string sECOND, string tHIRD, string date1, string date2, string date3, string number, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Expedia"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Select Flight", null, @__tags);
#line 4
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
       testRunner.Given("I am on flight booking page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 6
       testRunner.And("Click user clicks on Flight section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 7
       testRunner.When("I select multi-select", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 8
       testRunner.Then("click on Add another flight", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 9
       testRunner.Then(string.Format("Search for flights between different airports {0},{1},{2} on dates {3},{4},{5}  f" +
                        "or {6}  adults", fIRST, sECOND, tHIRD, date1, date2, date3, number), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 10
       testRunner.Then("click on Search option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 11
    testRunner.And("verify tht the data entered is correct", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
       testRunner.And("select First flight", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
       testRunner.And(string.Format("Total Price must be equal to {0} multiplied fare of single person", number), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

