using Schedule.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule
{
    internal class Presenter : IPresenter
    {
        IView view;
        IModel model;

        public bool Started { get; set; }

        public Presenter() 
        {
            view = new View(this);
            model = new Model(this);
            Started = false;
        }        

        public void Start()
        {
            view.Start();
            Started = true;
        }

        public void CreateNotebook(string name)
        {
            model.CreateNotebook(name);
            view.AddRecord();
        }

        public void LoadNotebook(string path)
        {
            throw new NotImplementedException();
        }

        public void CreateRecord(string place, DateTime when, string description)
        {
            model.CreateRecord(place, when, description);
        }

        public string PrintNotebook()
        {
            return model.SerializeNotebook();
        }
    }
}
