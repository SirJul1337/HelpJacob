using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelpJacob.Interfaces;

namespace HelpJacob
{
    public class MessageSender
    {
        public void SendMessageToAll(IMessageSender sender,string[] to, Message m, IConvert converter)
        {
            foreach (var recipient in to)
            {
                var message = new Message(recipient, m.From, m.Body, m.Subject, m.Cc);
                SendMessage(sender, converter, message);
                
            }
        }
        public string SendMessage(IMessageSender sender, IConvert converter, Message message)
        {
            return sender.SendMessage(message, converter);
        }
        public string SendMessage(IMessageSender sender, Message message)
        {
           return sender.SendMessage(message);
        }
    }
}
