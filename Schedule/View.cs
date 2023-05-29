using Schedule.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine("welcome!");
            Console.WriteLine("what do you want to do?");
            Console.WriteLine("1. create notebook");
            Console.WriteLine("2. load notebook");
            Console.WriteLine("3. exit");
            int choice = 0;
            while (choice != 3)
            {
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch(choice)
                    {
                        case 1:
                            Console.WriteLine("name your notebook");
                            Presenter.CreateNotebook(Console.ReadLine());
                            break;
                        case 2:
                            Console.WriteLine("enter path to the saved notebook");
                            Presenter.LoadNotebook(Console.ReadLine());
                            break;
                        case 3:
                            Console.WriteLine("goodbye");
                            break;
                        default:
                            Console.WriteLine("invalid input. try again");
                            break;
                    }
                }
                else
                    Console.WriteLine("invalid input. try again");
            }
        }

        public void AddRecord()
        {
            Console.WriteLine("where?");
            string place = Console.ReadLine();
            Console.WriteLine("when?");
            DateTime when = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("description?");
            string description = Console.ReadLine();
            Presenter.CreateRecord(place, when, description);
        }
    }
}
