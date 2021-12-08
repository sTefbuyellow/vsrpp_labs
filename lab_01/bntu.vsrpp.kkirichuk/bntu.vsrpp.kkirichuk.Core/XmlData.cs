using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;


namespace bntu.vsrpp.kkirichuk.Core
{
    public class CustomXmlData
    {
        public XmlDocument XDoc { get; set; }
        public XmlNode RootXDoc { get; set; }
        public CustomXmlData(String path)
        {
            this.XDoc = new XmlDocument();
            XDoc.Load(path);
            RootXDoc = XDoc.DocumentElement;
        }
    }
}