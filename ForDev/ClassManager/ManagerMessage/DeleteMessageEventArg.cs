using System;

namespace ForDev
{
    /// <summary>
    /// Custom EventArgs to forward the last deleted message
    /// </summary>
    public class DeleteMessageEventArg : EventArgs
    {
        public UcMessage UcMessage { get; set; }
        public int TopicId { get; set; }
    }
}
