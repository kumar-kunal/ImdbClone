using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbModelClass
{
    interface IPerson
    {
        string Name { get; set; }
        DateTime DOB { get; set; }
        string Sex { get; set; }
        string Bio { get; set; }
    }
}
