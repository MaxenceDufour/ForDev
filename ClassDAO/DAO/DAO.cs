using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOClass
{
    /// <summary>
    /// Dao abstract class to initialize behavior common to all child classes
    /// </summary>
    public abstract class DAO
    {
        public string ConnectionString { get; set; }
    }
}
