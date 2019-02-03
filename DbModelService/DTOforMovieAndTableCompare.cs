using System;
using System.Collections.Generic;
using System.Text;

namespace DbModelService
{
    public class DTOforMovieAndTableCompare
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public int YearOfRelease { get; set; }
        public string Plot { get; set; }
        public List<String> ActorsNameInMovie { get; set; }
        public string ProducerNameOfMovie { get; set; }

        public DTOforMovieAndTableCompare()
        {
            
        }
    }
}
