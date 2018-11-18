using System;
using System.IO;

namespace DEV_4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string xmlString = File.ReadAllText(@args[0]);
                XmlParser.Pars(xmlString);
            }
            catch (Exception error)
            {
                Console.WriteLine("Error: " + error.Message);
            }
        }        
    }
}
        

    


