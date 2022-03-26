using OpenClosedP.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedP.Concrete
{
    internal class MailMessage : IMessage
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("Mail ile Yollanan mesaj: "+message);
        }
    }
}
