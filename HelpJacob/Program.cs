using HelpJacob.Converters;
using HelpJacob.MessageSenders;

namespace HelpJacob;
public class Program
{
    public static void Main()
    {
        Queue<string> queue = new Queue<string>();
        MessageSender sender = new MessageSender();
        SmptMessageSender smptMessageSender = new SmptMessageSender();
        VMessageSender vMessageSender = new VMessageSender();
        HtmlConverter htmlConverter = new HtmlConverter();
        Message message = new("Karsten", "Peter", "Hey med dig Karsten", "Første besked", "Chef");
        queue.Enqueue(sender.SendMessage(smptMessageSender, htmlConverter, message));


        Message message1 = new("Peter", "Karsten", "Jeg tester message system uden converter", "Plain text", "Chef");
        queue.Enqueue(sender.SendMessage(vMessageSender, message1));
        while (queue.Count > 0)
        {
            Console.WriteLine($"____________\n{queue.Dequeue()}\n____________");
           
        }
    }
}