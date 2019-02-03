using AutoMapper;
using DbModelClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DbModelService
{
    public class DataCollectionClass
    {
        public List<Actor> actorsCollection;
        public List<Movie> moviesCollection;
        public List<Producer> producerCollection;


        public DataCollectionClass()
        {
            moviesCollection = new List<Movie>();
            actorsCollection = new List<Actor>();
            producerCollection = new List<Producer>();
            AddSomeRandomMovie();
            AddSomeRandomActor();
            AddSomeRandomProducer();
        }
    /******************** Work related to Movie like populate object, save, update and delete ***********************/

    // Give some movie data manually to show
        private void AddSomeRandomMovie()
        {
            for(int i=1;i<6;i++)
            {
                Movie movie = new Movie();
                movie.MovieId = i;
                movie.MovieName = "ABCD" + i;
                movie.YearOfRelease = 2000 + i;
                movie.ActorsNameList.Add("A" + i);
                movie.ProducerNameOfMovie = "PP" + i;
                movie.Plot = "Simple Story" + i;
                moviesCollection.Add(movie);

            }
        }

        public void SaveNewMovie(Movie NewMovieFromUser)
        {
            moviesCollection.Add(NewMovieFromUser);
        }


        public void UpdateMovie(TestParameterClass testParameterClass)
        {
            // Find Object with given Id to update
           
            Movie MovieWithSameId = moviesCollection.SingleOrDefault(x => x.MovieId == testParameterClass.MovieId);
            if (MovieWithSameId != null)
            {
                MovieWithSameId.MovieName = testParameterClass.MovieName;
                MovieWithSameId.YearOfRelease = testParameterClass.YearOfRelease;
                MovieWithSameId.Plot = testParameterClass.Plot;
                MovieWithSameId.ProducerIdInMovie = testParameterClass.ProducerIdInMovie;
                MovieWithSameId.ProducerNameOfMovie = testParameterClass.ProducerNameOfMovie;
                MovieWithSameId.ListOfActorsId = testParameterClass.ListOfActorsId;
                MovieWithSameId.ActorsNameList = testParameterClass.ActorsNameList;

                //MapperConfiguration config = new MapperConfiguration(cfg =>
                //{
                //    cfg.CreateMap<TestParameterClass, Movie>();
                //});

                //IMapper mapper = config.CreateMapper();
                //MovieWithSameId = mapper.Map<TestParameterClass, Movie>(testParameterClass);
            }

        }


        public void DeleteMovie(int MovieIdToDeleteMovie)
        {
            var item = moviesCollection.SingleOrDefault(x => x.MovieId == MovieIdToDeleteMovie);
            int PositionOfDeletedObject = item.MovieId - 1;
            if (item != null)
                moviesCollection.Remove(item);
            
            // Update Movie Id after deleting
            for(int i=PositionOfDeletedObject;i<moviesCollection.Count;i++)
            {
                moviesCollection.ElementAtOrDefault(i).MovieId--;
            }
            
        }


    /******************* Work related to Actor like populate object, save, update and delete ***********************/
        
        public void AddSomeRandomActor()
        {
            for(int i=1;i<6;i++)
            {
                Actor actor = new Actor();
                actor.ActorId = i;
                actor.Name = "A" + i;
                actor.DOB = DateTime.ParseExact("0"+i+"-01-2000", "dd-MM-yyyy", null);
                actor.Sex = (i % 2 == 0) ? "Male" : "Female";
                actor.Bio = "I am no-" + i + " Actor.";
                actor.ListOfMoviesActorWorkedIn.Add(moviesCollection.ElementAtOrDefault(i));

                actorsCollection.Add(actor);

            }
        }


    /******************* Work related to Producer like populate object, save, update and delete ***********************/

        public void AddSomeRandomProducer()
        {
            for (int i = 1; i < 6; i++)
            {
                Producer producer = new Producer();
                producer.ProducerId = i;
                producer.Name = "A" + i;
                producer.DOB = DateTime.ParseExact("0" + i + "-01-2000", "dd-MM-yyyy", null);
                producer.Sex = (i % 2 == 0) ? "Male" : "Female";
                producer.Bio = "I am no-" + i + " Actor.";
                producer.ListOfProducedMovies.Add(moviesCollection.ElementAtOrDefault(i));

                producerCollection.Add(producer);

            }
        }
    }
}
