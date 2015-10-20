using System;
using System.Xml;

namespace Homework.Framework.Core
{
    public static class RunConfigurator
    {
        private static XmlDocument xmlDoc = new XmlDocument(); // Create an XML document object

        private static String GetValue(String tag)
        {
            xmlDoc.Load("../../Resources/run.xml"); // Load the XML document from the specified file
            XmlNodeList browser = xmlDoc.GetElementsByTagName(tag);
            return browser[0].InnerText;
        }
        public static String GetLogin() {
            return GetValue("username");
        }
        public static String GetPassword()
        {
            return GetValue("password");
        }
    }
}
