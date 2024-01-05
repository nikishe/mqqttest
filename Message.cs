using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MqqtTest.Classes
{
    public class Message
    {
        public Message()
        {

        }
    }

    public class MessageList<TM> where TM : Message
    {
        public readonly List<TM> Messages;

        public MessageList()
        {
            Messages = new List<TM>();
        }

        public void OnMessageReceived(object sender, TM message)
        {
            Messages.Add(message);
        }

        public void Clear()
        {
            Messages.Clear();
        }

    }
}
