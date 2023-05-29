using Schedule.Interfaces;

namespace Schedule
{
    internal class Notebook
    {
        List<Record> records;
        string name;


        public List<Record> Records { get { return records; } }
        public int Count { get { return records.Count; } }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Notebook(string name)
        {
            records = new List<Record>();

        }

        public override string ToString()
        {
            string result = "";
            foreach (var record in Records)
                result += record.ToString() + "\n";
            return result;
        }

        public void Add(Record record)
        {
            records.Add(record);
        }
        public void Insert(int index, Record record)
        {
            records.Insert(index, record);
        }
        public Record GetRecord(int index)
        {
            return records[index];
        }
        public bool Exists(Record record)
        {
            return records.Exists(f => f.Equals(record));
        }
        public bool Delete()
        {
            try
            {
                records.RemoveAt(records.Count - 1);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteAt(int index)
        {
            try
            {
                records.RemoveAt(index);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Record Pop()
        {
            if (Count > 0)
            {
                Record record = records[records.Count - 1];
                this.Delete();
                return record;
            }
            else throw new ArgumentOutOfRangeException();
        }
        public void SortByDate()
        {
            records.Sort(Record.SortYearAscending());
        }
    }
}
