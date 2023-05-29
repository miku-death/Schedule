namespace Schedule.model
{
    internal class MeetingSchedule : Notebook<Appointment>
    {
        public MeetingSchedule() : base()
        {
        }

        public Record? Next()
        {
            SortByDate();
            for (int i = 0; i < Count; i++)
                if (Records[i].When > DateTime.Now)
                    return Records[i];
            return null;
        }
    }
}
