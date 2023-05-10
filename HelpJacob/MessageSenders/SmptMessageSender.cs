
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
        public void SendMessage(Message m, IConvert converter)
        {
            m.Body = converter.ConvertMessage(m.Body);
            //her implementeres alt koden til at sende via Smtp
        }
        public void SendMessage(Message m)
        {
            //her implementeres alt koden til at sende via Smtp
        }

    }
}
