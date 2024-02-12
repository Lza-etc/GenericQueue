using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class ChatMessage
    {
        int MessageId;
        string Content;
        DateTime TimeStamp;
        int SourceId;
        int lastmsg = 100;
        public ChatMessage(string content, int sourceId)
        {
            MessageId = lastmsg++;
            Content = content;
            TimeStamp = DateTime.Now;
            SourceId = sourceId;
        }
        public ChatMessage() { }    
    }
}
