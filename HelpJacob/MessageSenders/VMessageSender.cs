using HelpJacob.Interfaces;

namespace HelpJacob.MessageSenders;

public class VMessageSender : IMessageSender
{
    public void SendMessage(Message m, IConvert converter)
    {
        m.Body = converter.ConvertMessage(m.Body);
        //logik for besked til VMessage
        Logic();
    }
    public void SendMessage(Message m)
    {

        //logik for besked til VMessage
    }
    private void Logic()
    {

    }
}
