using OpenClosedP.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedP.Concrete
{
    internal class MessageManager
    {
        IMessage _message;

        public MessageManager(IMessage message)
        {
            _message = message;
        }
        public void Send(string message)
        {
            _message.SendMessage(message);
        }
    }
}
