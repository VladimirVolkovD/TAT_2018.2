using System;
using System.Text;
using System.Text.RegularExpressions;

namespace DEV_4
{
    class XmlParser
    {
        public static void Pars(string xmlString)
        {
            StringBuilder resault = new StringBuilder();
            Match element = Regex.Match(xmlString, @"<[^(/><)]+>");
            int counter = TagCounter(element);
            RemoveComments(ref xmlString);
            RemoveXmlDeclaration(ref xmlString);

            for (int i = counter / 2; i < 10; i++)
            {
                resault.Append(ExtractTagContents(ref xmlString) + "\n");
            }
            Console.Write(resault);
        }

        public static string ExtractTagContents(ref string xmlString)
        {
            StringBuilder resault = new StringBuilder();
            StringBuilder tagName = new StringBuilder();
            StringBuilder tagClosing = new StringBuilder();
            Match element = Regex.Match(xmlString, @"<[^(/><)]+>");
            string UnitTag = string.Empty;

            while (element.Success)
            {
                tagName.Append(element.Value);
                tagName.Replace("<", String.Empty);
                tagName.Replace(">", String.Empty);
                if (tagName.ToString().Contains(" "))
                {
                    tagName.Remove(tagName.ToString().IndexOf(" "),
                        tagName.ToString().LastIndexOf("\"") - tagName.ToString().IndexOf(" ") + 1);
                }

                tagClosing.Append(xmlString.Substring(xmlString.IndexOf("</" + tagName.ToString()), tagName.Length + 3));
                UnitTag = xmlString.Substring(xmlString.IndexOf(element.Value) + element.Value.Length - 1,
                    xmlString.IndexOf(tagClosing.ToString()) - (xmlString.IndexOf(element.Value) + element.Value.Length - 1));
                UnitTag = UnitTag.Trim();
                resault.Append(element.Value + " / ");
                string check = element.Value;
                element = Regex.Match(UnitTag, @"<[^(/><)]+>");
                if (!element.Success)
                {
                    xmlString = xmlString.Remove(xmlString.IndexOf(check),
                        xmlString.IndexOf(tagClosing.ToString()) - xmlString.IndexOf(tagName.ToString()) + tagName.Length + 4);
                }

                tagClosing.Clear();
                tagName.Clear();
            }
            resault.Append(UnitTag);
            resault.Replace("<", String.Empty);
            resault.Replace(">", String.Empty);
            return resault.ToString();
        }

        public static void RemoveComments(ref string xmlString)
        {
            while (xmlString.Contains("<!--"))
            {
                xmlString = xmlString.Remove(xmlString.IndexOf("<!--"), xmlString.IndexOf("-->") + 3 - xmlString.IndexOf("<!--")).Trim();
            }
        }

        public static void RemoveXmlDeclaration(ref string xmlString)
        {
            while (xmlString.Contains("<?"))
            {
                xmlString = xmlString.Remove(xmlString.IndexOf("<?"), xmlString.IndexOf("?>") + 2 - xmlString.IndexOf("<?")).Trim();
            }
        }

        public static int TagCounter(Match element)
        {
            int counter = 0;
            while (element.Success)
            {
                counter++;
                element = element.NextMatch();
            }

            return counter;
        }        
    }
}
