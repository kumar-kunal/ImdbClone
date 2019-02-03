using System;
using System.Collections.Generic;
using System.Text;

namespace DbModelService
{

    public class TestParameterClass
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public int YearOfRelease { get; set; }
        public string Plot { get; set; }
        public List<string> ActorsNameList { get; set; } = new List<string>();
        public string ProducerNameOfMovie { get; set; }
        public List<int> ListOfActorsId { get; set; } = new List<int>();
        public int ProducerIdInMovie { get; set; }

    }
}
