using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace bntu.vsrpp.kkirichuk.Core
{
    public static class CustomXmlWriter
    {
        public static XmlDocument refactor(this XmlNode xmlNode, XmlDocument xmlDocument)
        {
            List<String> elementsList = new List<String>();
            List<String> charValues = CustomXmlProcessor.GetCharValuesList(xmlNode);
            int count1 = charValues.BinarySearch("FirstName");
            int count2 = charValues.BinarySearch("SecondName");
            int count3 = charValues.BinarySearch("Surname");

            if (count1 < 0)
                charValues.Add("FirstName");
            if (count2 < 0)
                charValues.Add("SecondName");
            if (count3 < 0)
                charValues.Add("Surname");

            List<String> numeriValues = CustomXmlProcessor.GetNumericValuesList(xmlNode);
            elementsList.AddRange(charValues);
            elementsList.AddRange(numeriValues);

            foreach (XmlNode childXmlNode in xmlNode.ChildNodes)
            {
                List<String> tempValues = new List<string>();
                XmlNode needsToBeDeleted = null;
                foreach (XmlNode childChildXmlNode in childXmlNode.ChildNodes)
                {
                    if ("FullName".Equals(childChildXmlNode.Name))
                    {
                        int nameCount = 0;
                        string[] names = childChildXmlNode.InnerText.Split(" ");
                        foreach (String name in names)
                        {
                            XmlElement element = xmlDocument.CreateElement(elementsList.ElementAt(nameCount++));
                            XmlText nameText = xmlDocument.CreateTextNode(name);
                            element.AppendChild(nameText);
                            childXmlNode.InsertBefore(element, childChildXmlNode);
                        }
                        tempValues.AddRange(new string[] { "FirstName", "LastName", "Surname" });
                        needsToBeDeleted = childChildXmlNode;
                    }
                    else
                    {
                        tempValues.Add(childChildXmlNode.Name);
                    }
                }
                tempValues = elementsList.Except(tempValues).ToList();
                if (tempValues.Count > 0)
                {
                    foreach (String name in tempValues)
                    {
                        XmlElement element = xmlDocument.CreateElement(name);
                        XmlText nameText;
                        int count = numeriValues.BinarySearch(name);
                        if (count > 0)
                        {
                            nameText = xmlDocument.CreateTextNode("0");
                        }
                        else
                        {
                            nameText = xmlDocument.CreateTextNode("NA");
                        }
                        element.AppendChild(nameText);
                        childXmlNode.AppendChild(element);
                    }
                }
                if (needsToBeDeleted != null)
                {
                    childXmlNode.RemoveChild(needsToBeDeleted);
                }
            }
            return xmlDocument;
        }

        public static void save(this XmlNode xmlNode, XmlDocument xmlDocument, String sourceFileName)
        {
            XmlDocument newXmlDocument = refactor(xmlNode, xmlDocument);
            xmlDocument.Save(sourceFileName.Substring(0, sourceFileName.Length - 4) + "_output.xml");
        }
    }

}