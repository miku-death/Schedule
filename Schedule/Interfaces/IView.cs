using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule.Interfaces
{
    internal interface IView
    {
        IPresenter Presenter { get; set; }
        public void Start();
        public void AddRecord();
        public void SaveNotebook();
    }
}
