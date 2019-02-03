using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbModelClass
{
    public class Actor : IPerson
    {
        public int ActorId { get; set; }
        public List<Movie> ListOfMoviesActorWorkedIn { get; set; }

        public Actor()
        {
            ListOfMoviesActorWorkedIn = new List<Movie>();
        }

        // Implementation of Person Interface
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public string Sex { get; set; }
        public string Bio { get; set; }



    }


}
