using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace WpfApplication1.ViewModels
{
    public class StudentVM : PersonVM
    {
        public StudentVM() { }
        public StudentVM(String firstName, String lastName, String age) : 
            base(firstName, lastName, age) { }

    }
}
