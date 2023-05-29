using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule.model
{
    internal class Appointment : Record
    {
        string place;

        public string Place
        {
            get { return place; }
            set { place = value; }
        }

        public Appointment(DateTime when, string description, string place) : base(when, description)
        {
            When = when;
            Description = description;
            Place = place;
        }
    }
}
