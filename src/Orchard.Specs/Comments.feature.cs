﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.8.1.0
//      SpecFlow Generator Version:1.8.0.0
//      Runtime Version:4.0.30319.239
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Orchard.Specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Comments")]
    public partial class CommentsFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Comments.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Comments", "  In order to enable simple comment capabilities on my site\r\n  As an author\r\n  I " +
                    "want to allow comments to be safely posted on specific content item pages", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("HTML markup in any given comment is encoded")]
        public virtual void HTMLMarkupInAnyGivenCommentIsEncoded()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HTML markup in any given comment is encoded", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
    testRunner.Given("I have installed Orchard");
#line 8
    testRunner.When("I go to \"admin/blogs/create\"");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table1.AddRow(new string[] {
                        "Title.Title",
                        "My Blog"});
#line 9
        testRunner.And("I fill in", ((string)(null)), table1);
#line 12
        testRunner.And("I hit \"Save\"");
#line 13
        testRunner.And("I go to \"admin/blogs\"");
#line 14
        testRunner.And("I follow \"My Blog\"");
#line 15
        testRunner.And("I follow \"New Post\" where class name has \"primaryAction\"");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table2.AddRow(new string[] {
                        "Title.Title",
                        "My Post"});
            table2.AddRow(new string[] {
                        "Body.Text",
                        "Hi there."});
#line 16
        testRunner.And("I fill in", ((string)(null)), table2);
#line 20
        testRunner.And("I hit \"Publish Now\"");
#line 21
        testRunner.And("I go to \"my-blog/my-post\"");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table3.AddRow(new string[] {
                        "CommentText",
                        "This is<br id=\"bad-br\" />a <a href=\"#\">link</a>."});
#line 22
        testRunner.And("I fill in", ((string)(null)), table3);
#line 25
        testRunner.And("I hit \"Submit Comment\"");
#line 26
        testRunner.And("I am redirected");
#line 28
        testRunner.And("I go to \"my-blog/my-post\"");
#line 29
    testRunner.Then("I should see \"This is&lt;br id=&quot;bad-br&quot; /&gt;a &lt;a href\"");
#line 30
        testRunner.And("I should not see \"<br id=\"bad-br\" />\"");
#line 32
    testRunner.When("I go to \"Users/Account/LogOff\"");
#line 33
        testRunner.And("I am redirected");
#line 34
        testRunner.And("I go to \"my-blog/my-post\"");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table4.AddRow(new string[] {
                        "Name",
                        "Some One"});
            table4.AddRow(new string[] {
                        "CommentText",
                        "This is<br id=\"bad-anon-br\" />a <a href=\"#\">link</a>."});
#line 35
        testRunner.And("I fill in", ((string)(null)), table4);
#line 39
        testRunner.And("I hit \"Submit Comment\"");
#line 40
        testRunner.And("I am redirected");
#line 42
        testRunner.And("I go to \"my-blog/my-post\"");
#line 43
    testRunner.Then("I should see \"This is&lt;br id=&quot;bad-anon-br&quot; /&gt;a &lt;a href\"");
#line 44
        testRunner.And("I should not see \"<br id=\"bad-anon-br\" />\"");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
