using Schedule.Interfaces;

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

        public void CreateNotebook()
        {
            model.CreateNotebook();
            view.AddRecord();
        }

        public string LoadNotebook()
        {
            model.LoadNotebookFromFile();
            return model.ReadableNotebook();

        }

        public void CreateRecord(string place, DateTime when, string description)
        {
            model.CreateRecord(place, when, description);
        }

        public string PrintNotebook()
        {
            return model.ReadableNotebook();
        }

        public void SaveNotebook()
        {
            model.SaveNotebook();
        }
    }
}
