using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbModelClass
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public int YearOfRelease { get; set; }
        public string Plot { get; set; }
        public List<String> ActorsNameList { get; set; }
        public string ProducerNameOfMovie { get; set; }
       

        // for future use
        private List<Actor> ActorObjectList { get; set; }
        private Producer ProducerOfMovie { get; set; }
        public List<int> ListOfActorsId { get; set; }
        public int ProducerIdInMovie { get; set; }


        public Movie()
        {
            ActorsNameList = new List<string>();
            ActorObjectList = new List<Actor>();
            ProducerOfMovie = new Producer();
            ListOfActorsId = new List<int>();
        }
    }
}
