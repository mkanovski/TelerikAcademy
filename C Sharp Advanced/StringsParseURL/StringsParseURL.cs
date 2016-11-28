using System;
using System.Text;


namespace StringsParseURL
{
    class StringsParseURL
    {
        static void Main()
        {
            string url = Console.ReadLine();

            string protocol = "";
            string server = "";
            string resource = "";

            protocol = url.Substring(0, url.IndexOf(':'));
            resource = url.Substring(url.IndexOf('/', url.IndexOf('.')));
            server = url.Substring(url.IndexOf(':') + 3);
            server = server.Replace(resource, "");


            Console.WriteLine("[protocol] = {0}", protocol);
            Console.WriteLine("[server] = {0}", server);
            Console.WriteLine("[resource] = {0}", resource);

        }
    }
}
