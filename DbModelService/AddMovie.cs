using AutoMapper;
using DbModelClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace DbModelService
{
    public class AddMovie
    {
        public Movie MovieObjectForAdding;
        public AddMovie()
        {
            MovieObjectForAdding = new Movie();
        }
        public void AddNewMovieIfAllGiven(TestParameterClass testParameterClass)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<TestParameterClass, Movie>();
            });

            IMapper mapper = config.CreateMapper();
            MovieObjectForAdding = mapper.Map<TestParameterClass, Movie>(testParameterClass);

            //MovieObjectForAdding.MovieId = testParameterClass.MovieId;
            //MovieObjectForAdding.MovieName = testParameterClass.MovieName;
            //MovieObjectForAdding.YearOfRelease = testParameterClass.YearOfRelease;
            //MovieObjectForAdding.Plot = testParameterClass.Plot;
            //MovieObjectForAdding.ActorsNameList = testParameterClass.ActorsNameList;
            //MovieObjectForAdding.ProducerNameOfMovie = testParameterClass.ProducerNameOfMovie;
            //MovieObjectForAdding.ListOfActorsId = testParameterClass.ListOfActorsId;
            //MovieObjectForAdding.ProducerIdWorkedInMovie = testParameterClass.ProducerIdInMovie;
        }

    }
}
