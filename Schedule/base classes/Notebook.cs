namespace Schedule
{
    internal class Notebook<T>
        where T : Record
    {
        List<T> records;

        public List<T> Records { get { return records; } }
        public int Count { get { return records.Count; } }

        public Notebook()
        {
            records = new List<T>();
        }

        public override string ToString()
        {
            string result = "";
            foreach (var record in Records)
                result += record.ToString() + "\n";
            return result;
        }

        public void Add(T record)
        {
            records.Add(record);
        }
        public void Insert(int index, T record)
        {
            records.Insert(index, record);
        }
        public T GetRecord(int index)
        {
            return records[index];
        }
        public bool Exists(T record)
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
        public T Pop()
        {
            if (Count > 0)
            {
                T record = records[records.Count - 1];
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
