using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class ChatMessage
    {
        public int MessageId { get; set; }
        public string Content {get; set;}
        public DateTime TimeStamp {  get; set;}
        public int SourceId {  get; set; }

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
