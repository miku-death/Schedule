using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule.Interfaces
{
    internal interface ILoadable<T>
        where T : ISaveable
    {
        public T Load(string path);
    }
}
