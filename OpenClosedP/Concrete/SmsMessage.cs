using OpenClosedP.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedP.Concrete
{
    internal class SmsMessage : IMessage
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("Sms ile Yollanan mesaj: "+message);
        }
    }
}
