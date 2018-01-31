using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForDev
{
    /// <summary>
    /// Customized EventArgs to pass the user control rubric
    /// </summary>
    public class LoadRubricEventArgs : EventArgs
    {
        public UcRubric UcRubric { get; set; }
    }
}
