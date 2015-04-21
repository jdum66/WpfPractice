using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1.ViewModels
{
    public class StudentVM : PersonVM
    {
        public StudentVM() { }
        public StudentVM(String firstName, String lastName, String age) : 
            base(firstName, lastName, age) { }

        private Exception _exception;

        public Exception Exception
        {
            get { return _exception; }
            set
            {
                if (_exception == value) { return; }
                System.Diagnostics.Debug.WriteLine("in student.exception");
                _exception = value;
                OnPropertyChanged("Exception");
                System.Diagnostics.Debug.WriteLine("after on property changed");

            }
        }

    }
}
