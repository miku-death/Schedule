using Schedule.Interfaces;
using Schedule.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule
{
    internal class Model : IModel
    {
        public IPresenter Presenter { get; set; }
        Notebook Notebook { get; set; }

        public Model(IPresenter presenter) 
        {
            Presenter = presenter;
        }

        public void CreateNotebook(string name)
        {
            Notebook = new Notebook(name);
        }

        public void LoadNotebookFromFile(string path)
        {
            throw new NotImplementedException();
        }

        public void SaveNotebook(Notebook notebook)
        {
            throw new NotImplementedException();
        }

        public void SaveChangesToNotebook(Notebook notebook, string path)
        {
            throw new NotImplementedException();
        }

        public void CreateRecord(string place, DateTime when, string description)
        {
            Record appointment = new Appointment(when, description, place);
            Notebook.Add(appointment);
        }
    }
}
