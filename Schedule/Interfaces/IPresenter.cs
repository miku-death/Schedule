using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule.Interfaces
{
    internal interface IPresenter
    {
        public bool Started { get; set; }

        void Start();
        void CreateNotebook(string name);
        void LoadNotebook(string path);

        void CreateRecord(string place, DateTime when, string description);
    }
}
