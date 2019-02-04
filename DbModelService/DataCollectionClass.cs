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
        DbSetup dbSetup;


        public DataCollectionClass()
        {
            moviesCollection = new List<Movie>();
            actorsCollection = new List<Actor>();
            producerCollection = new List<Producer>();
            dbSetup = new DbSetup();

            moviesCollection=dbSetup.AddSomeRandomMovie();
            actorsCollection=dbSetup.AddSomeRandomActor();
            producerCollection=dbSetup.AddSomeRandomProducer();
        }


        public void SaveNewMovie(Movie NewMovieFromUser)
        {
            moviesCollection.Add(NewMovieFromUser);
        }


        public void UpdateMovie(Movie testParameterClass)
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

        public void CheckIfIdNotExist(int MovieIdIfNotExist)
        {
            int FlagForIdCheck = 0;
            foreach (var TempVarForMovie in moviesCollection)

            {
                if (TempVarForMovie.MovieId == MovieIdIfNotExist)
                {
                    FlagForIdCheck = 1;
                }
            }
            if (FlagForIdCheck == 0)
            {
                throw new CustomException("Inavalid ID Exception. Enter valid ID to update.");
            }
        }

        public void IsValidName(string MovieName)
        {

            if (MovieName == "")
            {
                throw new CustomException("Enter the name of movie.");
            }
        }

        public void CheckForExistingId(int MovieIdForCheck)
        {
            foreach (var TempVarForMovie in 
moviesCollection)
            {
                if (TempVarForMovie.MovieId == MovieIdForCheck)
                {
                    throw new CustomException("This Id is already present in the database. Please use another Id");

                }
            }
        }


    }
}
