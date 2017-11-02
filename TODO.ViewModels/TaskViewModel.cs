using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TODO.Helpers;
using TODO.Models;
using TODO.ViewModels.Code;

namespace TODO.ViewModels
{
    public class TaskViewModel : NotifyPropertyChangedImplementation
    {
        private bool _canExecute = true;

        private bool _isVisible;

        private ICommand _clickCommand;
        public ICommand ClickCommand
        {
            get
            {
                return _clickCommand;
            }
        }
        public bool IsVisible
        {
            get { return _isVisible; }
            set { _isVisible = value;
                OnPropertyChanged();
            }
        }

        private String _actualTask;

        public String ActualTask
        {
            get { return _actualTask; }
            set { _actualTask = value;
                OnPropertyChanged();
                if (!string.IsNullOrEmpty(ActualTask))
                    IsVisible = true;
                else
                    IsVisible = false;
            }
        }

        void AddTodo()
        {
            List.Add(new TaskModel
            {
                Description = ActualTask
            });
            
        }


        private ObservableCollection<TaskModel> _list;

        public ObservableCollection<TaskModel> List
        {
            get { return _list; }
            set { _list = value;
                OnPropertyChanged();
            }
        }

        public TaskViewModel()
        {
            List = new ObservableCollection<TaskModel>();
            _clickCommand = new CommandHandler(() => AddTodo(), _canExecute);
        }


    }
}
