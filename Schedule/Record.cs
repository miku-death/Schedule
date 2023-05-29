using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Schedule
{
    internal abstract class Record
    {
        protected DateTime when;
        protected string description;

        public DateTime When
        {
            get { return when; }
            set { when = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public Record(DateTime when, string description)
        {
            this.when = when;
            this.description = description;
        }

        public override string ToString()
        {
            return $"[{when.ToString("g")}] {description}";
        }
        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;

            try
            {
                Record other = obj as Record;
                return this.when == other.When && this.description == other.Description;
            }
            catch
            {
                return false;
            }
        }
    }
}
