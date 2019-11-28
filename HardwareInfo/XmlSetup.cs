using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace HardwareInfo
{
    class XmlSetup
    {
        public static List<string> GetWMIs(string WMIClassName)
        {
            string xmlFilePath = @"..\..\XmlSetup.xml";
            List<string> alPropertyNames = new List<string>();
            XmlDocument xmldoc = new System.Xml.XmlDocument();
            xmldoc.Load(xmlFilePath);
            XmlNode properties = xmldoc.SelectSingleNode("//" + WMIClassName);

            for (int i = 0; i < properties.ChildNodes.Count; i++)
                alPropertyNames.Add(properties.ChildNodes[i].InnerText);
            return alPropertyNames;
        }
    }
}
