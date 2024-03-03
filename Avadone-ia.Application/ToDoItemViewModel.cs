using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avadone_ia.Domain;

namespace Avadone_ia.Application
{
    public class ToDoItemViewModel
    {
        public ToDoItem ToDoItem { get; private set; }

        public ToDoItemViewModel(ToDoItem toDoItem)
        {
            ToDoItem = toDoItem;
        }

        public void CreateToDoItem()
        {

        }

        public void UpdateToDoItem()
        {

        }

        public void SaveToDoItem()
        {

        }

        public void DeleteToDoItem()
        {

        }

        public void AddSubTask()
        {

        }

        public void DeleteSubTask(ToDoItem subtask)
        {

        }
    }
}
