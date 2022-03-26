// See https://aka.ms/new-console-template for more information

using OpenClosedP.Concrete;

var messageManager = new MessageManager(new MailMessage());
messageManager.Send("İndirim Mesajı");
messageManager = new MessageManager(new SmsMessage());
messageManager.Send("İndirim Mesajı");