using HikoiArt.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace HikoiArt.ViewModel
{
    class TodoListViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<TodoItem> TodoItems { get; set; }
        public TodoListViewModel()
        {
            TodoItems = new ObservableCollection<TodoItem>();

            TodoItems.Add(new TodoItem("todo 1", false));
            TodoItems.Add(new TodoItem("todo 2", false));
            TodoItems.Add(new TodoItem("todo 3", false));
        }

        public ICommand AddTodoCommand => new Command(AddTodoItem);
        private string _newTodoInputValue;
        public string NewTodoInputValue
        {
            get => _newTodoInputValue;
            set
            {
                bool hasChanged = _newTodoInputValue != value;
                _newTodoInputValue = value;
                if (hasChanged && PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs("NewTodoInputValue"));
                }
            }
        }


        void AddTodoItem()
        {
            TodoItems.Add(new TodoItem(NewTodoInputValue, false));
            NewTodoInputValue = "";
        }

        public ICommand RemoveTodoCommand => new Command(RemoveTodoItem);
        void RemoveTodoItem(object o)
        {
            TodoItem todoItemBeingRemoved = o as TodoItem;
            Console.WriteLine("todoItemBeingRemoved.TodoText");
            TodoItems.Remove(todoItemBeingRemoved);
        }
    }
}
