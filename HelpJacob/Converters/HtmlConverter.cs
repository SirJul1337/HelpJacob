using HelpJacob.Interfaces;
namespace HelpJacob.Converters;

public class HtmlConverter : IConvert
{
    public string ConvertMessage(string body)
    {
        return "<html><body>" + body + "</html></body>";
    }
}
