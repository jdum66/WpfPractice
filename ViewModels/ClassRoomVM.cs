using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Diagnostics;

namespace WpfApplication1.ViewModels
{
    public class ClassRoomVM : INotifyPropertyChanged
    {
        private ObservableCollection<StudentVM> _students = new ObservableCollection<StudentVM>();
        
        public ObservableCollection<StudentVM> Students
        {
            get { return _students; }
        }
        
        public void Add(StudentVM student)
        {
            Students.Add(student);
            onPropertyChanged("Students");
        }

        public void Remove(StudentVM student)
        {
            bool x = Students.Remove(student);
            onPropertyChanged("Students");
        }

        private ICommand _clickCommand;
        public ICommand ClickSubmitCommand
        {
            get { return _clickCommand = new AddCommand(this); }
        }
        public ICommand ClickDeleteCommand
        {
            get { return _clickCommand = new DeleteCommand(this); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void onPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }

    public class AddCommand : Command 
    {
        public AddCommand(ClassRoomVM classRoom) : base(classRoom) { }

        protected override void CommandExecute(object parameter)
        {
            PersonVM person = (parameter as PersonVM);

            if (person.FirstName == null || person.LastName == null || person.Age == null)
            {
                MessageBox.Show("Values cannot be null");
                return;
            }

            StudentVM student = new StudentVM(person.FirstName, person.LastName, person.Age);

            try
            {
                var valid = _Validate(student);
                ClassRoomVM.Add(student);
                return;
            }
            catch (Exception e)
            {
                Debug.WriteLine("there was an error");
                MessageBox.Show(e.Message);
                student.Exception = e;
                
                return;
            }     
        }

        Boolean _Validate(StudentVM student)
        {
            Regex validName = new Regex("^[A-Za-z]+$");
            Regex validAge = new Regex(@"^\d+$");
            if (!validName.IsMatch(student.FirstName) || !validName.IsMatch(student.LastName))
            {
                throw new Exception("Enter a valid name");
            }
            else if (!validAge.IsMatch(student.Age))
            {
                throw new Exception("Enter a valid age");
            }
            return true;
        }        
    }

    public class DeleteCommand: Command
    {
        public DeleteCommand(ClassRoomVM classRoom) : base(classRoom) { }
        
        protected override void CommandExecute(object parameter)
        {
            StudentVM student = parameter as StudentVM;
            ClassRoomVM.Remove(student);
        }
    }

    public class Command : ICommand
    {
        protected ClassRoomVM ClassRoomVM;
        public Command(ClassRoomVM classRoom)
        {
            ClassRoomVM = classRoom;
        }

        public bool CanExecute(object parameter)
        {
            return CommandCanExecute(parameter);
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            CommandExecute(parameter);
        }

        protected virtual bool CommandCanExecute(object parameter)
        {
            return true;
        }

        protected virtual void CommandExecute(object parameter)
        {
            
        }
    }
}
