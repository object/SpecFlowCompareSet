// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.6.0.0
//      SpecFlow Generator Version:1.6.0.0
//      Runtime Version:4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
namespace SpecFlowCompareSet.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.6.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Table comparison")]
    public partial class TableComparisonFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Table comparison.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Table comparison", "In order to avoid writing my own collection comparison code\r\nAs a SpecFlow user\r\n" +
                    "I want to compare collections using different criteria", GenerationTargetLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Match")]
        public virtual void Match()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Match", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Artist",
                        "Album"});
            table1.AddRow(new string[] {
                        "Beatles",
                        "Rubber Soul"});
            table1.AddRow(new string[] {
                        "Pink Floyd",
                        "Animals"});
            table1.AddRow(new string[] {
                        "Muse",
                        "Absolution"});
#line 7
 testRunner.When("I have a collection", ((string)(null)), table1);
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Artist",
                        "Album"});
            table2.AddRow(new string[] {
                        "Beatles",
                        "Rubber Soul"});
            table2.AddRow(new string[] {
                        "Pink Floyd",
                        "Animals"});
            table2.AddRow(new string[] {
                        "Muse",
                        "Absolution"});
#line 12
 testRunner.Then("it should match", ((string)(null)), table2);
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Artist",
                        "Album"});
            table3.AddRow(new string[] {
                        "Beatles",
                        "Rubber Soul"});
            table3.AddRow(new string[] {
                        "Muse",
                        "Absolution"});
            table3.AddRow(new string[] {
                        "Pink Floyd",
                        "Animals"});
#line 17
 testRunner.And("it should match", ((string)(null)), table3);
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Artist",
                        "Album"});
            table4.AddRow(new string[] {
                        "Beatles",
                        "Rubber Soul"});
            table4.AddRow(new string[] {
                        "Pink Floyd",
                        "Animals"});
            table4.AddRow(new string[] {
                        "Muse",
                        "Absolution"});
#line 22
 testRunner.And("it should exactly match", ((string)(null)), table4);
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Artist",
                        "Album"});
            table5.AddRow(new string[] {
                        "Beatles",
                        "Rubber Soul"});
            table5.AddRow(new string[] {
                        "Queuen",
                        "Jazz"});
            table5.AddRow(new string[] {
                        "Muse",
                        "Absolution"});
#line 27
 testRunner.But("it should not match", ((string)(null)), table5);
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Artist",
                        "Album"});
            table6.AddRow(new string[] {
                        "Beatles",
                        "Rubber Soul"});
            table6.AddRow(new string[] {
                        "Muse",
                        "Absolution"});
#line 32
 testRunner.And("it should not match", ((string)(null)), table6);
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Artist",
                        "Album"});
            table7.AddRow(new string[] {
                        "Beatles",
                        "Rubber Soul"});
            table7.AddRow(new string[] {
                        "Muse",
                        "Absolution"});
            table7.AddRow(new string[] {
                        "Pink Floyd",
                        "Animals"});
#line 36
 testRunner.And("it should not exactly match", ((string)(null)), table7);
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Containment")]
        public virtual void Containment()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Containment", ((string[])(null)));
#line 42
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Artist",
                        "Album"});
            table8.AddRow(new string[] {
                        "Beatles",
                        "Rubber Soul"});
            table8.AddRow(new string[] {
                        "Pink Floyd",
                        "Animals"});
            table8.AddRow(new string[] {
                        "Muse",
                        "Absolution"});
#line 43
 testRunner.When("I have a collection", ((string)(null)), table8);
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Artist",
                        "Album"});
            table9.AddRow(new string[] {
                        "Beatles",
                        "Rubber Soul"});
            table9.AddRow(new string[] {
                        "Muse",
                        "Absolution"});
#line 48
 testRunner.Then("it should contain all items", ((string)(null)), table9);
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Artist",
                        "Album"});
            table10.AddRow(new string[] {
                        "Beatles",
                        "Rubber Soul"});
            table10.AddRow(new string[] {
                        "Muse",
                        "Resistance"});
#line 52
 testRunner.But("it should not contain all items", ((string)(null)), table10);
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Artist",
                        "Album"});
            table11.AddRow(new string[] {
                        "Beatles",
                        "Abbey Road"});
            table11.AddRow(new string[] {
                        "Muse",
                        "Resistance"});
#line 56
 testRunner.And("it should not contain any of items", ((string)(null)), table11);
#line hidden
            testRunner.CollectScenarioErrors();
        }
    }
}
#endregion
