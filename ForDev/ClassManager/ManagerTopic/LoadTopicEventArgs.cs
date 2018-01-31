using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForDev
{
    /// <summary>
    /// Customized EventArgs to pass the user control topic
    /// </summary>
    public class LoadTopicEventArgs : EventArgs
    {
        public UcTopic UcTopic { get; set; }
    }
}
