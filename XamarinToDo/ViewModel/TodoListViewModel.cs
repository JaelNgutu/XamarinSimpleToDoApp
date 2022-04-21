using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using XamarinToDo.Model;

namespace XamarinToDo.ViewModel
{
    public class TodoListViewModel
    {
        //view can observe can update
        public ObservableCollection<TodoItem> TodoItems { get; set; }

        public TodoListViewModel()
        {
            TodoItems = new ObservableCollection<TodoItem>();

            TodoItems.Add(new TodoItem("First Todo", true));
            TodoItems.Add(new TodoItem("First Todo", true));
            TodoItems.Add(new TodoItem("First Todo", true));
        }
    }
}
