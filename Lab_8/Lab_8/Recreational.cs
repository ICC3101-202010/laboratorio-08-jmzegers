using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    class Recreational : Premise
    {
        public Recreational(string name, string owner, string id, string opening_hour, string closing_hour) : 
            base(name, owner, id, opening_hour, closing_hour)
        {

        }
    }
}
