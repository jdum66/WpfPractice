using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1.ViewModels
{
    public class PersonVM : INotifyPropertyChanged, IEditableObject
    {
        public PersonVM() { }
        public PersonVM(String fname, String lname, String age) 
        {
            _firstName = fname;
            _lastName = lname;
            _age = age;
        }

        private String _firstName;

        public String FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                OnPropertyChanged("FirstName");
            }
        }

        private String _lastName;

        public String LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                OnPropertyChanged("LastName");
            }
        }

        private String _age;

        public String Age
        {
            get { return _age; }
            set
            {
                _age = value;
                OnPropertyChanged("Age");
            }
        }

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

        public void BeginEdit() { }

        public void CancelEdit() { }
          
        public void EndEdit() { }

        public event PropertyChangedEventHandler PropertyChanged;
    }  


}
