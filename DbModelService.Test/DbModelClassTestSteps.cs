using AutoMapper;
using DbModelClass;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using Xunit;

namespace DbModelService.Test
{
    [Binding]
    public class DbModelClassTestSteps
    {

        TestParameterClass testParameterClass;

        Movie movieForCRUD;

        DataCollectionClass dataCollectionClass;

        // Constructor to initialize object
        public DbModelClassTestSteps()
        {
            testParameterClass = new TestParameterClass();
            movieForCRUD = new Movie();
            dataCollectionClass = new DataCollectionClass();
        }


        [Given(@"I have movie Id (.*), Name ""(.*)"", Year of Release (.*), Plot ""(.*)"", Actors ""(.*)"", Producer ""(.*)"", ActorsId ""(.*)"", ProducerId (.*)")]
        public void GivenIHaveMovieIdNameYearOfReleasePlotActorsProducerActorsIdProducerId(int MovieId, string MovieName, int YearOfRelease, string Plot, string ActorListString, string ProducerInMovie, string ActorsIdinMovie, int ProducerIdinMovie)
        {
            // I will call a function with all this parameter
            testParameterClass.MovieId = MovieId;
            testParameterClass.MovieName = MovieName;
            testParameterClass.YearOfRelease = YearOfRelease;
            testParameterClass.Plot = Plot;

            testParameterClass.ActorsNameList = new List<string>(ActorListString.Split(','));

            testParameterClass.ProducerNameOfMovie = ProducerInMovie;

            //Converting string array into int array
            testParameterClass.ListOfActorsId = new List<int>(Array.ConvertAll(ActorsIdinMovie.Split(' '), s=> int.Parse(s)));

            testParameterClass.ProducerIdInMovie = ProducerIdinMovie;

            
        }

        [Given(@"I have movie Id (.*)")]
        public void GivenIHaveMovieId(int MovieId)
        {
            testParameterClass.MovieId = MovieId;
        }
        
        [When(@"I press AddMovie")]
        public void WhenIPressAddMovie()
        {
            //addMovie.AddNewMovieIfAllGiven(testParameterClass);
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<TestParameterClass, Movie>();
            });

            IMapper mapper = config.CreateMapper();
            movieForCRUD = mapper.Map<TestParameterClass, Movie>(testParameterClass);
        }
        
        [When(@"I press UpdateMovie")]
        public void WhenIPressUpdateMovie()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<TestParameterClass, Movie>();
            });

            IMapper mapper = config.CreateMapper();
            movieForCRUD = mapper.Map<TestParameterClass, Movie>(testParameterClass);
        }
        
        [When(@"I press DeleteMovie")]
        public void WhenIPressDeleteMovie()
        {
            // function has just one line in remove db part
        }
        
        [Then(@"If Id present throw ThisIdAlreadyExist exception")]
        public void ThenIfIdPresentThrowThisIdAlreadyExistException()
        {
           try
            {
           dataCollectionClass.CheckForExistingId(testParameterClass.MovieId);
           }
           catch (CustomException ex) { Assert.Equal("Success",ex.Message); }
        }
        
        [Then(@"Do Name Validation")]
        public void ThenDoNameValidation()
        {
            try
            {
            dataCollectionClass.IsValidName(testParameterClass.MovieName);
            }
            catch (CustomException ex) { Assert.Equal("Success",ex.Message); }
        }
        
        //[Then(@"Check for DataDuplicacy")]
        //public void ThenCheckForDataDuplicacy()
        //{
        //    // see u later
        //}
        
        [Then(@"I must save this to IMDBDb Database")]
        public void ThenIMustSaveThisToIMDBDbDatabase()
        {
            dataCollectionClass.SaveNewMovie(movieForCRUD);
        }
        
        [Then(@"the List of movies is like:")]
        public void ThenTheListOfMoviesIsLike(Table table)
        {
            //List<DTOforMovieAndTableCompare> dto = new List<DTOforMovieAndTableCompare>();
            //dto = dataCollectionClass.moviesCollection;

            //var person = table.CreateInstance<DataCollectionClass>();
            //table.CompareToInstance<DataCollectionClass>(person);

            ////Assert.Equal(p, dataCollectionClass.moviesCollection);


            //need different code here... this is just for debugging
            for (int i = 0; i < table.Rows.Count; i++)
            {
                // string i= rows["Movie Name"];
                Assert.StrictEqual<int>(Int32.Parse(table.Rows[i]["Movie Id"]), dataCollectionClass.moviesCollection[i].MovieId);
                Assert.Equal(table.Rows[i]["Movie Name"], dataCollectionClass.moviesCollection[i].MovieName);
                Assert.StrictEqual<int>(Int32.Parse(table.Rows[i]["YoR"]), dataCollectionClass.moviesCollection[i].YearOfRelease);
                Assert.Equal(table.Rows[i]["Plot"], dataCollectionClass.moviesCollection[i].Plot);
                Assert.Equal(table.Rows[i]["Actors"], String.Join(",", dataCollectionClass.moviesCollection[i].ActorsNameList));
                Assert.Equal(table.Rows[i]["Producer"], dataCollectionClass.moviesCollection[i].ProducerNameOfMovie);


            }
        }
        
        [Then(@"If Id is not present throw ThisIdNotFound exception")]
        public void ThenIfIdIsNotPresentThrowThisIdNotFoundException()
        {
            try
            {
                dataCollectionClass.CheckIfIdNotExist(testParameterClass.MovieId);
            }
            catch (CustomException ex) { Assert.Equal("Success", ex.Message); }
            
        }
        
        [Then(@"Update this to IMDBDb Database")]
        public void ThenUpdateThisToIMDBDbDatabase()
        {
            dataCollectionClass.UpdateMovie(movieForCRUD);      
        }
        
        [Then(@"Delete movie data from IMDBDb Database")]
        public void ThenDeleteMovieDataFromIMDBDbDatabase()
        {
            dataCollectionClass.DeleteMovie(testParameterClass.MovieId);
        }
    }
}
