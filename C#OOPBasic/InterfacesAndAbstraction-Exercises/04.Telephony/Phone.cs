
using System.Linq;

public class Phone : ICallOtherPhones,IBrowseInTheWorldWideWeb
{
    public string Browsing(string url)
    {
        if (url.Any(char.IsDigit))
        {
            return "Invalid URL!";
        }
        else
        {
            return $"Browsing: {url}!";
        }
    }

    public string Calling(string numb)
    {
        if (numb.Any(char.IsDigit) == false)
        {
            return "Invalid number!";
        }
        else
        {
            return $"Calling... {numb}";
        }
    }
}

