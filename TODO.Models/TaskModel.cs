using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODO.Helpers;

namespace TODO.Models
{
    public class TaskModel : NotifyPropertyChangedImplementation
    {
        private String _description;

        public String Description
        {
            get { return _description; }
            set { _description = value; }
        }

    }
}
