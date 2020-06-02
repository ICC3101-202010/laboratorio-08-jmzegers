using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    class Premise
    {
        string name;
        string owner;
        string id;
        string opening_hour;
        string closing_hour;
        
        public Premise(string name, string owner, string id, string opening_hour, string closing_hour)
        {
            this.Name = name;
            this.Owner = owner;
            this.ID = id;
            this.Opening_Hour = opening_hour;
            this.Closing_Hour = closing_hour;
        }

        public string Name { get => name; set => name = value; }
        public string Owner { get => owner; set => owner = value; }
        public string ID { get => id; set => id = value; }
        public string Opening_Hour { get => opening_hour; set => opening_hour = value; }
        public string Closing_Hour { get => closing_hour; set => closing_hour = value; }
    }
}
