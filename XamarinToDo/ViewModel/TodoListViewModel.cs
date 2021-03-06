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
            TodoItems = new ObservableCollection<TodoItem>
            {
                new TodoItem("First Todo", true),
                new TodoItem("First Todo", true),
                new TodoItem("First Todo", false)
            };
        }
      
       

        public ICommand AddTodoCommand => new Command(AddTodoItem);
        public string NewTodoText { get; set; }

        void AddTodoItem()
        {
            TodoItems.Add(new TodoItem(NewTodoText, false));
        }

        public ICommand RemoveTodoCommand => new Command(RemoveTodoItem);
        void RemoveTodoItem(object o)
        {
            TodoItem todoItemBeingRemoved = o as TodoItem;
            TodoItems.Remove(todoItemBeingRemoved);
        }
    }
}
