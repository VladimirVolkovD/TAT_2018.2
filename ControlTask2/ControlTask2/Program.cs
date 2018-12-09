using System;

namespace ControlTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new Program();
            string d =(test.GetLink(args[0]));
            Console.WriteLine(d);
            Console.WriteLine("Validation: " +test.Validate(d));            
        }

        public string GetLink(string input)
        {
            String link;
            if (input.IndexOf("http") >= 0)
            {
                link = input.Substring(input.IndexOf("http"), ".com".Length + input.IndexOf(".com") - input.IndexOf("http"));
                return link;
            }
            else
            {
                return null;
            }            
        }

        public  bool Validate(string link)
        {
            Uri url;
            return (Uri.TryCreate(link, UriKind.RelativeOrAbsolute, out url) &&
                    (url.Scheme == Uri.UriSchemeHttp || url.Scheme == Uri.UriSchemeHttps));
        }
    }
}
