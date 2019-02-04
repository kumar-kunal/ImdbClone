using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbModelClass
{
    public interface IPerson
    {
        string name { get; set; }
        DateTime dob { get; set; }
        string sex { get; set; }
        string bio { get; set; }
    }
}
