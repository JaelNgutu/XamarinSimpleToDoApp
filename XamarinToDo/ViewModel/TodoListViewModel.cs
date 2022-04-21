using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
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
      
       

        public ICommand AddTodoCommand => new Command(AddTodoItem);
        public string NewTodoText { get; set; }

        void AddTodoItem()
        {
            TodoItems.Add(new TodoItem(NewTodoText, false));
        }
    }
}
