using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.ViewModels
{
    public class StudentPageViewModel
    {
        Random rand = new Random();

        public ObservableCollection<Model.ManagerStudent> Students { get; private set; }
        = new ObservableCollection<Model.ManagerStudent>();

        public StudentPageViewModel()
        {
            for (int i = 0; i < 100; i++)
            {
                var item = new Model.ManagerStudent()
                {
                    id = i,
                    name = string.Format("Task name {0}", i),
                    gpa = 10*(float)this.rand.NextDouble()
                };
                this.Students.Add(item);
            }

        }
    }
}
