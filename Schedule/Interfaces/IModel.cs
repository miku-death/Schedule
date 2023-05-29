using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule.Interfaces
{
    internal interface IModel
    {
        IPresenter Presenter { get; set; }

        void CreateNotebook(string name);
        void LoadNotebookFromFile(string path);
        void SaveNotebook(Notebook notebook);
        void SaveChangesToNotebook(Notebook notebook, string path);

        void CreateRecord(string place, DateTime when, string description);
        string SerializeNotebook();
    }
}
