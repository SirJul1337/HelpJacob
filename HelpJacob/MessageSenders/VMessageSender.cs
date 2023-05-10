using HelpJacob.Interfaces;

namespace HelpJacob.MessageSenders;

public class VMessageSender : IMessageSender
{
    public string SendMessage(Message m, IConvert converter)
    {
        m.Body = converter.ConvertMessage(m.Body);
        //Calling logic method
        return Logic(m);
    }
    public string SendMessage(Message m)
    {
        //Calling logic method
        return Logic(m);
    }
    private string Logic(Message m)
    {
        //logik for besked til VMessage
        return $"To: {m.To}\ncc: {m.Cc}\nSubject: {m.Subject}\nBody:\n {m.Body}\nFrom: {m.From}";
    }
}
