using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace WpfApplication1.ViewModels
{
    public class PersonCreationVM : PersonVM
    {
        public PersonCreationVM() { }

        public PersonCreationVM(String firstName, String lastName, String age) : 
            base(firstName, lastName, age) { }

        private Exception _exception;

        public Exception Exception
        {
            get { return _exception; }
            set
            {
                _exception = value;
                OnPropertyChanged("Exception");
            }
        }

    }

}
