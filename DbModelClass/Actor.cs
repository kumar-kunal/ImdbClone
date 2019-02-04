using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbModelClass
{
    public class Actor : IPerson
    {
        public int actorId { get; set; }
        public List<Movie> listOfMoviesActorWorkedIn { get; set; }

        public Actor()
        {
            listOfMoviesActorWorkedIn = new List<Movie>();
        }

        // Implementation of Person Interface
        public string name { get; set; }
        public DateTime dob { get; set; }
        public string sex { get; set; }
        public string bio { get; set; }



    }


}
