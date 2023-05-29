using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule
{
    internal interface ILoadable<T>
        where T : ISaveable
    {
        public T Load(string path);
    }
}
