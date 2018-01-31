using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserEditor;

namespace ForDev.ClassManager.ManagerRichTextBox
{
    /// <summary>
    /// Customized EventArgs to pass the topic id
    /// </summary>
    public class AddMessageEventArgs : EventArgs
    {
        public int TopicId { get; set; }
    }
}
