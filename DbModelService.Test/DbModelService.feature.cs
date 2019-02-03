// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace DbModelService.Test
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class DbModelClassTestFeature : Xunit.IClassFixture<DbModelClassTestFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "DbModelService.feature"
#line hidden
        
        public DbModelClassTestFeature(DbModelClassTestFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "DbModelClassTest", "\tIn order to have movies, actors and producers details\r\n\tAs a admin\r\n\tI want to d" +
                    "o CRUD operation on data", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute(DisplayName="Add a Movie")]
        [Xunit.TraitAttribute("FeatureTitle", "DbModelClassTest")]
        [Xunit.TraitAttribute("Description", "Add a Movie")]
        [Xunit.TraitAttribute("Category", "addMovie")]
        public virtual void AddAMovie()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add a Movie", null, new string[] {
                        "addMovie"});
#line 7
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
 testRunner.Given("I have movie Id 6, Name \"ABCD6\", Year of Release 2006, Plot \"Simple Story6\", Acto" +
                    "rs \"A6\", Producer \"PP6\", ActorsId \"6\", ProducerId 6", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.When("I press AddMovie", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
 testRunner.Then("If Id present throw ThisIdAlreadyExist exception", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 11
 testRunner.And("Do Name Validation", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
 testRunner.And("Check for DataDuplicacy", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
 testRunner.And("I must save this to IMDBDb Database", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Movie Id",
                        "Movie Name",
                        "YoR",
                        "Plot",
                        "Actors",
                        "Producer"});
            table1.AddRow(new string[] {
                        "1",
                        "ABCD1",
                        "2001",
                        "Simple Story1",
                        "A1",
                        "PP1"});
            table1.AddRow(new string[] {
                        "2",
                        "ABCD2",
                        "2002",
                        "Simple Story2",
                        "A2",
                        "PP2"});
            table1.AddRow(new string[] {
                        "3",
                        "ABCD3",
                        "2003",
                        "Simple Story3",
                        "A3",
                        "PP3"});
            table1.AddRow(new string[] {
                        "4",
                        "ABCD4",
                        "2004",
                        "Simple Story4",
                        "A4",
                        "PP4"});
            table1.AddRow(new string[] {
                        "5",
                        "ABCD5",
                        "2005",
                        "Simple Story5",
                        "A5",
                        "PP5"});
            table1.AddRow(new string[] {
                        "6",
                        "ABCD6",
                        "2006",
                        "Simple Story6",
                        "A6",
                        "PP6"});
#line 14
 testRunner.And("the List of movies is like:", ((string)(null)), table1, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Update a Movie")]
        [Xunit.TraitAttribute("FeatureTitle", "DbModelClassTest")]
        [Xunit.TraitAttribute("Description", "Update a Movie")]
        [Xunit.TraitAttribute("Category", "UpdateMovie")]
        public virtual void UpdateAMovie()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Update a Movie", null, new string[] {
                        "UpdateMovie"});
#line 26
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 27
 testRunner.Given("I have movie Id 5, Name \"ABCD55\", Year of Release 2055, Plot \"Simple Story55\", Ac" +
                    "tors \"A5,A7\", Producer \"PP55\", ActorsId \"5 7\", ProducerId 5", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 28
 testRunner.When("I press UpdateMovie", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 29
 testRunner.Then("If Id is not present throw ThisIdNotFound exception", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 30
 testRunner.And("Update this to IMDBDb Database", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Movie Id",
                        "Movie Name",
                        "YoR",
                        "Plot",
                        "Actors",
                        "Producer"});
            table2.AddRow(new string[] {
                        "1",
                        "ABCD1",
                        "2001",
                        "Simple Story1",
                        "A1",
                        "PP1"});
            table2.AddRow(new string[] {
                        "2",
                        "ABCD2",
                        "2002",
                        "Simple Story2",
                        "A2",
                        "PP2"});
            table2.AddRow(new string[] {
                        "3",
                        "ABCD3",
                        "2003",
                        "Simple Story3",
                        "A3",
                        "PP3"});
            table2.AddRow(new string[] {
                        "4",
                        "ABCD4",
                        "2004",
                        "Simple Story4",
                        "A4",
                        "PP4"});
            table2.AddRow(new string[] {
                        "5",
                        "ABCD55",
                        "2055",
                        "Simple Story55",
                        "A5,A7",
                        "PP55"});
#line 31
 testRunner.And("the List of movies is like:", ((string)(null)), table2, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Delete a Movie")]
        [Xunit.TraitAttribute("FeatureTitle", "DbModelClassTest")]
        [Xunit.TraitAttribute("Description", "Delete a Movie")]
        [Xunit.TraitAttribute("Category", "deleteMovie")]
        public virtual void DeleteAMovie()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Delete a Movie", null, new string[] {
                        "deleteMovie"});
#line 43
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 44
 testRunner.Given("I have movie Id 5", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 45
 testRunner.When("I press DeleteMovie", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 46
 testRunner.Then("If Id is not present throw ThisIdNotFound exception", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 47
 testRunner.And("Delete movie data from IMDBDb Database", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Movie Id",
                        "Movie Name",
                        "YoR",
                        "Plot",
                        "Actors",
                        "Producer"});
            table3.AddRow(new string[] {
                        "1",
                        "ABCD1",
                        "2001",
                        "Simple Story1",
                        "A1",
                        "PP1"});
            table3.AddRow(new string[] {
                        "2",
                        "ABCD2",
                        "2002",
                        "Simple Story2",
                        "A2",
                        "PP2"});
            table3.AddRow(new string[] {
                        "3",
                        "ABCD3",
                        "2003",
                        "Simple Story3",
                        "A3",
                        "PP3"});
            table3.AddRow(new string[] {
                        "4",
                        "ABCD4",
                        "2004",
                        "Simple Story4",
                        "A4",
                        "PP4"});
#line 48
 testRunner.And("the List of movies is like:", ((string)(null)), table3, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                DbModelClassTestFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                DbModelClassTestFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
