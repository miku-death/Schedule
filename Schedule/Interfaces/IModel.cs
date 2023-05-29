namespace Schedule.Interfaces
{
    internal interface IModel
    {
        IPresenter Presenter { get; set; }

        void CreateNotebook();
        void LoadNotebookFromFile();
        void SaveNotebook();

        void CreateRecord(string place, DateTime when, string description);
        string ReadableNotebook();
        string SerializeNotebook();
    }
}
