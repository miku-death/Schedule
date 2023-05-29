using Schedule.Interfaces;

namespace Schedule
{
    internal class View : IView
    {
        public IPresenter Presenter { get; set; }
        public bool Started { get; set; }

        public View(Presenter presenter)
        {
            Presenter = presenter;
            Started = false;
        }        

        public void Start()
        {
            Started = true;
            int choice = 0;
            while (choice != 3)
            {
                Console.WriteLine("what do you want to do?");
                Console.WriteLine("1. create notebook");
                Console.WriteLine("2. load notebook");
                Console.WriteLine("3. exit");
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Presenter.CreateNotebook();
                            break;
                        case 2:
                            Console.WriteLine(Presenter.LoadNotebook());
                            break;
                        case 3:
                            break;
                        default:
                            Console.WriteLine("invalid input. try again");
                            break;
                    }
                }
                else
                    Console.WriteLine("invalid input. try again");
            }
            SaveNotebook();
        }

        public void AddRecord()
        {
            Console.WriteLine("add record? [any_key / n]");

            while (Console.ReadLine() != "n")
            {
                Console.WriteLine("where?");
                string place = Console.ReadLine();
                Console.WriteLine("when?");
                DateTime when = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("description?");
                string description = Console.ReadLine();
                Presenter.CreateRecord(place, when, description);
                Console.WriteLine("add record? [any_key / n]");
            }
        }

        public void SaveNotebook()
        {
            Console.WriteLine("save to file? [any_key / n]");

            if (Console.ReadLine() != "n")
            {
                Presenter.SaveNotebook();
            }
        }
    }
}
