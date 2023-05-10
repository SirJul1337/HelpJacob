
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelpJacob.Interfaces;

namespace HelpJacob.MessageSenders
{
    public class SmptMessageSender : IMessageSender
    {
        public string SendMessage(Message m, IConvert converter)
        {
            m.Body = converter.ConvertMessage(m.Body);
            //calling method for smtp logic
            return Logic(m);
        }
        public string SendMessage(Message m)
        {
            //calling method for smtp logic
            return Logic(m);
        }
        private string Logic(Message m)
        {
            //her implementeres alt koden til at sende via Smtp
            //Return bliver brugt til at returnere dataen så den kan skrives i consollen, ellers vil der være logic istedet for return af string
            return $"To: {m.To}\ncc: {m.Cc}\nsubject: {m.Subject}\nbody:\n {m.Body}\nfrom: {m.From}";
        }

    }
}
