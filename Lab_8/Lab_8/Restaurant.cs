using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    class Restaurant : Premise
    {
        bool hasExclusiveTables;

        public Restaurant(string name, string owner, string id, string opening_hour, string closing_hour) : 
            base(name, owner, id, opening_hour, closing_hour)
        {
            this.HasExclusiveTables = hasExclusiveTables;
        }

        public bool HasExclusiveTables { get => hasExclusiveTables; set => hasExclusiveTables = value; }

    }
}
