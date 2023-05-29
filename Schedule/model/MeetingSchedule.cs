using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule.model
{
    internal class MeetingSchedule : Notebook
    {
        public MeetingSchedule() { }

        public Record Next()
        {
            SortByDate();
            for (int i = 0; i < Count; i++)
                if (Records[i].When > DateTime.Now)
                    return Records[i];
            return null;
        }
    }
}
