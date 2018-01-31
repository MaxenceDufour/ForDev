using BusinessClassPortable;
using System;

namespace ForDev.ClassManager.ManagerLogin
{
    /// <summary>
    /// Custom EventArgs to transmit the person connect
    /// </summary>
    public class PersonConnectedEventArgs : EventArgs
    {
        public Person PersonConnected { get; set; }
    }
}
