using DbModelClass;
using System;
using System.Collections.Generic;
using System.Text;
using Unity;
using Unity.Lifetime;

namespace DbModelService
{
    public class DbSetup
    {
        public UnityContainer objContainer = new UnityContainer();
        

        List<Movie> initialMovies = new List<Movie>();
        List<Actor> initialActors = new List<Actor>();
        List<Producer> initialProducers = new List<Producer>();

        public DbSetup()
        {
            objContainer.RegisterType<Movie>();
            objContainer.RegisterType<IPerson,Actor>();
            objContainer.RegisterType<IPerson,Actor>();
        }

        // Give some movie data manually to show

        public List<Movie> AddSomeRandomMovie()
        {
            for (int i = 1; i < 6; i++)
            {
                Movie movie = objContainer.Resolve<Movie>();
                movie.MovieId = i;
                movie.MovieName = "ABCD" + i;
                movie.YearOfRelease = 2000 + i;
                movie.ActorsNameList.Add("A" + i);
                movie.ProducerNameOfMovie = "PP" + i;
                movie.Plot = "Simple Story" + i;
                initialMovies.Add(movie);

            }
            return initialMovies;
        }

        public List<Actor> AddSomeRandomActor()
        {
            for (int i = 1; i < 6; i++)
            {
                Actor actor = objContainer.Resolve<Actor>();
                actor.actorId = i;
                actor.name = "A" + i;
                actor.dob = DateTime.ParseExact("0" + i + "-01-2000", "dd-MM-yyyy", null);
                actor.sex = (i % 2 == 0) ? "Male" : "Female";
                actor.bio = "I am no-" + i + " Actor.";
                //actor.listOfMoviesActorWorkedIn.Add(moviesCollection.ElementAtOrDefault(i));

                initialActors.Add(actor);
            }
            return initialActors;
        }

        public List<Producer> AddSomeRandomProducer()
        {
            for (int i = 1; i < 6; i++)
            {
                Producer producer = objContainer.Resolve<Producer>();
                producer.ProducerId = i;
                producer.name = "A" + i;
                producer.dob = DateTime.ParseExact("0" + i + "-01-2000", "dd-MM-yyyy", null);
                producer.sex = (i % 2 == 0) ? "Male" : "Female";
                producer.bio = "I am no-" + i + " Actor.";
                //producer.ListOfProducedMovies.Add(moviesCollection.ElementAtOrDefault(i));

                initialProducers.Add(producer);
            }
            return initialProducers;
        }


        public static void Main(string[] args){}
    }
}
