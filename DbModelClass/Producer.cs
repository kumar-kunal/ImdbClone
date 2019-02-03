using System;
using System.Collections.Generic;

namespace DbModelClass
{
    public class Producer : IPerson
    {

        public int ProducerId { get; set; }
        public List<Movie> ListOfProducedMovies { get; set; }

        public Producer()
        {
            ListOfProducedMovies = new List<Movie>();
        }


        // Implementation of IPerson inteface methods
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public string Sex { get; set; }
        public string Bio { get; set; }
    }
}
