using Schedule.Interfaces;
using Schedule.model;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Schedule
{
    internal class Model : IModel
    {
        public IPresenter Presenter { get; set; }
        Notebook<Appointment> Notebook { get; set; }

        public Model(IPresenter presenter) 
        {
            Presenter = presenter;
        }

        public void CreateNotebook()
        {
            Notebook = new Notebook<Appointment>();
        }

        public void LoadNotebookFromFile()
        {
            string[] files = Directory.GetFiles(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location));
            foreach (string file in files)
            {
                string extension = Path.GetExtension(file);
                if(extension == ".notebook")
                {
                    string json = "";
                    using(FileStream fs = File.OpenRead(file))
                    {
                        byte[] data = new byte[fs.Length];
                        fs.Read(data, 0, data.Length);
                        json = Encoding.Default.GetString(data);
                    }
                    if (!String.IsNullOrEmpty(json))
                        Notebook = JsonSerializer.Deserialize<Notebook<Appointment>>(json);
                }
            }
        }

        public async void SaveNotebook()
        {
            using(FileStream fs = new FileStream("notebook.notebook", FileMode.OpenOrCreate))
            {
                byte[] buffer = Encoding.Default.GetBytes(SerializeNotebook());
                await fs.WriteAsync(buffer, 0, buffer.Length);
            }
        }

        public void CreateRecord(string place, DateTime when, string description)
        {
            Appointment appointment = new Appointment(when, description, place);
            Notebook.Add(appointment);
        }

        public string ReadableNotebook()
        {
            Notebook.SortByDate();
            return Notebook.ToString();
        }

        public string SerializeNotebook()
        {
            Notebook.SortByDate();
            return JsonSerializer.Serialize(Notebook);
        }
    }
}
