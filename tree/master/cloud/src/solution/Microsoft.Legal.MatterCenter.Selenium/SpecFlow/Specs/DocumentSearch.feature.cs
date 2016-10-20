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
namespace Microsoft.Legal.MatterCenter.Selenium.SpecFlow.Specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class DocumentSearchPageFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "DocumentSearch.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Document Search Page", "", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((TechTalk.SpecFlow.FeatureContext.Current != null) 
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "Document Search Page")))
            {
                Microsoft.Legal.MatterCenter.Selenium.SpecFlow.Specs.DocumentSearchPageFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
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
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("01. Open the browser and load search document page")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Document Search Page")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("E2E")]
        public virtual void _01_OpenTheBrowserAndLoadSearchDocumentPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("01. Open the browser and load search document page", new string[] {
                        "E2E"});
#line 4
this.ScenarioSetup(scenarioInfo);
#line 5
 testRunner.When("user enters credentials on document search page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 6
 testRunner.Then("document search page should be loaded with element \'documentgrid\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("07. Verify the document drop down menu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Document Search Page")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("E2E")]
        public virtual void _07_VerifyTheDocumentDropDownMenu()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("07. Verify the document drop down menu", new string[] {
                        "E2E"});
#line 9
this.ScenarioSetup(scenarioInfo);
#line 10
 testRunner.When("user clicks on My Documents item from drop down menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.Then("it should display My Documents in header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 12
 testRunner.When("user clicks on Pinned Documents item from drop down menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 13
 testRunner.Then("it should display Pinned Documents in header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 14
 testRunner.When("user clicks on All Documents item from drop down menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 15
 testRunner.Then("it should display All Documents in header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("06. Verify the column picker")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Document Search Page")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("E2E")]
        public virtual void _06_VerifyTheColumnPicker()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("06. Verify the column picker", new string[] {
                        "E2E"});
#line 18
this.ScenarioSetup(scenarioInfo);
#line 19
 testRunner.When("user clicks on column picker and checks all columns", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 20
 testRunner.Then("it should display all the columns in header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 21
 testRunner.When("user clicks on column picker and remove all checked columns", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 22
 testRunner.Then("it should not display any columns except document column in header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("05. Verify the document search box")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Document Search Page")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("E2E")]
        public virtual void _05_VerifyTheDocumentSearchBox()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("05. Verify the document search box", new string[] {
                        "E2E"});
#line 25
this.ScenarioSetup(scenarioInfo);
#line 26
 testRunner.When("user searches with keyword \'Test\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 27
 testRunner.Then("it should display all the document which consist of \'test\' keyword", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("04. Verify the document sort")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Document Search Page")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("E2E")]
        public virtual void _04_VerifyTheDocumentSort()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("04. Verify the document sort", new string[] {
                        "E2E"});
#line 30
this.ScenarioSetup(scenarioInfo);
#line 31
 testRunner.When("user click on column name to sort the document in Ascending order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 32
 testRunner.Then("it should sort the document in ascending order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("08. Verify the document filter search")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Document Search Page")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("E2E")]
        public virtual void _08_VerifyTheDocumentFilterSearch()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("08. Verify the document filter search", new string[] {
                        "E2E"});
#line 35
this.ScenarioSetup(scenarioInfo);
#line 36
 testRunner.When("user clicks on column filter to filter the documents using keyword \'Test\' on My D" +
                    "ocuments", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 37
 testRunner.Then("it should filter the document based on filtered keyword", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 38
 testRunner.When("user clicks on column filter to filter the documents using keyword \'Test\' on All " +
                    "Documents", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 39
 testRunner.Then("it should filter the document based on filtered keyword", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("02. Verify the document Ecb menu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Document Search Page")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("E2E")]
        public virtual void _02_VerifyTheDocumentEcbMenu()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("02. Verify the document Ecb menu", new string[] {
                        "E2E"});
#line 42
this.ScenarioSetup(scenarioInfo);
#line 43
 testRunner.When("user clicks on ECB menu in document search page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 44
 testRunner.Then("a fly out should open", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 45
 testRunner.When("user clicks on open this document", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 46
 testRunner.Then("that document should open", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 47
 testRunner.When("user clicks on view matter details in fly out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 48
 testRunner.Then("user should be redirected to matter landing page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 49
    testRunner.When("user clicks on pin this document or unpin this document", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 50
 testRunner.Then("document should be pinned or unpinned", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("03. Verify the document fly out")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Document Search Page")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("E2E")]
        public virtual void _03_VerifyTheDocumentFlyOut()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("03. Verify the document fly out", new string[] {
                        "E2E"});
#line 53
this.ScenarioSetup(scenarioInfo);
#line 54
 testRunner.When("user clicks on document on document search page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 55
 testRunner.Then("a document fly out should open", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 56
 testRunner.When("user clicks on open this document in document fly out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 57
 testRunner.Then("that document should open when clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 58
 testRunner.When("user clicks on view document details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 59
 testRunner.Then("document landing page should open", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("09. Verify the document search box for managed search")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Document Search Page")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("E2E")]
        public virtual void _09_VerifyTheDocumentSearchBoxForManagedSearch()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("09. Verify the document search box for managed search", new string[] {
                        "E2E"});
#line 62
this.ScenarioSetup(scenarioInfo);
#line 63
  testRunner.When("user searches with keyword \'DocTitle:test\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 64
 testRunner.Then("it should display all the document which consist of \'test\' keyword", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("10. Verify no results on searching invalid text")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Document Search Page")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("E2E")]
        public virtual void _10_VerifyNoResultsOnSearchingInvalidText()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("10. Verify no results on searching invalid text", new string[] {
                        "E2E"});
#line 67
this.ScenarioSetup(scenarioInfo);
#line 68
 testRunner.When("user searches with random keywords on document search page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 69
 testRunner.Then("no results should be displayed on document search page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("11. Verify no results on searching invalid text on document filter")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Document Search Page")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("E2E")]
        public virtual void _11_VerifyNoResultsOnSearchingInvalidTextOnDocumentFilter()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("11. Verify no results on searching invalid text on document filter", new string[] {
                        "E2E"});
#line 72
this.ScenarioSetup(scenarioInfo);
#line 73
 testRunner.When("user clicks on column filter to filter the documents using random keyword", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 74
 testRunner.Then("no documents should be displayed inside the fly out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion