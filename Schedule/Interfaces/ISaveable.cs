using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule.Interfaces
{
    internal interface ISaveable
    {
        public void Save(ISaveable o);
        public void SaveChanges(ISaveable o, string path);
    }
}
