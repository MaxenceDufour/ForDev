using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForDev
{
    public class MyEventArgs : EventArgs
    {
        public MyEventArgs() { }
        public UcRubric EventArgsRubric { get; set; }
        public UcTopic EventArgsTopic { get; set; }
    }
}
