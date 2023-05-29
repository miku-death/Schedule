using System.Collections;

namespace Schedule
{
    internal abstract class Record : ISaveable, ILoadable, IComparable
    {
        DateTime when;
        string description;

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

        // TODO
        public void Save(ISaveable o)
        {
            throw new NotImplementedException();
        }
        public void SaveChanges(ISaveable o, string path)
        {
            throw new NotImplementedException();
        }
        public object Load(string path)
        {
            throw new NotImplementedException();
        }

        private class DateSortHelper : IComparer<Record>
        {
            public int Compare(Record? x, Record? y)
            {
                if (x is null || y is null)
                    return 0;
                return x.When.CompareTo(y.When);
            }
        }
        public int CompareTo(object? obj)
        {
            if (obj is null)
                return 1;
            return when.CompareTo((obj as Record).when);
        }
        public static IComparer<Record> SortYearAscending()
        {
            return new DateSortHelper();
        }
    }
}
