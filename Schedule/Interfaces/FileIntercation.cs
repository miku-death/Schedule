using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule.Interfaces
{
    internal interface FileIntercation
    {
        public void Save(Notebook n, string path);
        public void SaveChanges(Notebook n, string path);
        public void Load(string path);
    }
}
