using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpJacob.Interfaces;

public interface IMessageSender
{
    public string SendMessage(Message m, IConvert converter);
    public string SendMessage(Message m);
}
