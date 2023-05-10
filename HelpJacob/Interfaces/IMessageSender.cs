using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpJacob.Interfaces;

public interface IMessageSender
{
    public void SendMessage(Message m, IConvert converter);
    public void SendMessage(Message m);
}
