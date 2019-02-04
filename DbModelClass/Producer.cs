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
        public string name { get; set; }
        public DateTime dob { get; set; }
        public string sex { get; set; }
        public string bio { get; set; }
    }
}
