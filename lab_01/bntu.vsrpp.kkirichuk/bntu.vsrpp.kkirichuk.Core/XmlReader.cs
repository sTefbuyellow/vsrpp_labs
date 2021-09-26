using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;


namespace bntu.vsrpp.kkirichuk.Core
{
    public class CustomXmlReader
    {
        public XmlDocument XDoc { get; set; }
        public XmlNode RootXDoc { get; set; }
        public CustomXmlReader(String path)
        {
            this.XDoc = new XmlDocument();
            XDoc.Load(path);
            RootXDoc = XDoc.DocumentElement;
        }

        public double GetAverageLength(XmlNode xmlNode, String objectName)
        {
            return Math.Round(GetLengthSumm(xmlNode, objectName, 0) / GetCount(xmlNode, objectName, 0), 3);
        }
        public double GetLengthSumm(XmlNode xmlNode, String objectName, double startSumm)
        {
            foreach (XmlNode childXmlNode in xmlNode.ChildNodes)
            {
                if (objectName.Equals(xmlNode.Name))
                {
                    startSumm += xmlNode.InnerText.Length;
                }
                else
                {
                    startSumm = GetLengthSumm(childXmlNode, objectName, startSumm);
                }
            }
            return startSumm;
        }


        public double GetAverage(XmlNode xmlNode, String objectName)
        {
            return Math.Round(GetSumm(xmlNode, objectName, 0) / GetCount(xmlNode, objectName, 0), 3);
        }

        public double GetSumm(XmlNode xmlNode, String objectName, double startSumm)
        {
            foreach (XmlNode childXmlNode in xmlNode.ChildNodes)
            {
                if (objectName.Equals(xmlNode.Name))
                {
                    startSumm += Convert.ToDouble(xmlNode.InnerText);
                }
                else
                {
                    startSumm = GetSumm(childXmlNode, objectName, startSumm);
                }
            }
            return startSumm;
        }

        public int GetCount(XmlNode xmlNode, String objectName, int startCount)
        {
            foreach (XmlNode childXmlNode in xmlNode.ChildNodes)
            {
                if (objectName.Equals(xmlNode.Name))
                {
                    startCount++;
                }
                else
                {
                    startCount = GetCount(childXmlNode, objectName, startCount);
                }
            }
            return startCount;
        }

        public double GetMaxLength(XmlNode xmlNode, String objectName)
        {
            String str = GetStartValue(xmlNode, objectName);
            return CountMaxLength(xmlNode, objectName, str.Length);
        }

        public int CountMaxLength(XmlNode xmlNode, String objectName, int maxValue)
        {
            foreach (XmlNode childXmlNode in xmlNode)
            {
                if (objectName.Equals(xmlNode.Name))
                {
                    int currentValue = xmlNode.InnerText.Length;
                    if (currentValue > maxValue)
                    {
                        maxValue = currentValue;
                    }
                }
                else
                {
                    maxValue = CountMaxLength(childXmlNode, objectName, maxValue);
                }
            }
            return maxValue;
        }

        public double GetMinLength(XmlNode xmlNode, String objectName)
        {
            String str = GetStartValue(xmlNode, objectName);
            return CountMinLength(xmlNode, objectName, str.Length);
        }

        public int CountMinLength(XmlNode xmlNode, String objectName, int minValue)
        {
            foreach (XmlNode childXmlNode in xmlNode)
            {
                if (objectName.Equals(xmlNode.Name))
                {
                    int currentValue = xmlNode.InnerText.Length;
                    if (currentValue < minValue)
                    {
                        minValue = currentValue;
                    }
                }
                else
                {
                    minValue = CountMinLength(childXmlNode, objectName, minValue);
                }
            }
            return minValue;
        }
        public double GetMaxValue(XmlNode xmlNode, String objectName)
        {
            double maxValue = Convert.ToDouble(GetStartValue(xmlNode, objectName));
            return CountMaxValue(xmlNode, objectName, maxValue);
        }

        public double CountMaxValue(XmlNode xmlNode, String objectName, double maxValue)
        {
            foreach (XmlNode childXmlNode in xmlNode.ChildNodes)
            {
                if (objectName.Equals(xmlNode.Name))
                {
                    double currentValue = Convert.ToDouble(xmlNode.InnerText);
                    if (currentValue > maxValue)
                    {
                        maxValue = currentValue;
                    }
                }
                else
                {
                    maxValue = CountMaxValue(childXmlNode, objectName, maxValue);
                }
            }
            return maxValue;
        }

        public double GetMinValue(XmlNode xmlNode, String objectName)
        {
            double minValue = Convert.ToDouble(GetStartValue(xmlNode, objectName));
            return CountMinValue(xmlNode, objectName, minValue);
        }

        public double CountMinValue(XmlNode xmlNode, String objectName, double minValue)
        {
            foreach (XmlNode childXmlNode in xmlNode.ChildNodes)
            {
                if (objectName.Equals(xmlNode.Name))
                {
                    double currentValue = Convert.ToDouble(xmlNode.InnerText);
                    if (currentValue < minValue)
                    {
                        minValue = currentValue;
                    }
                }
                else
                {
                    minValue = CountMinValue(childXmlNode, objectName, minValue);
                }
            }
            return minValue;
        }

        public string GetStartValue(XmlNode xmlNode, String objectName)
        {
            if (xmlNode.FirstChild.FirstChild.HasChildNodes)
            {
                return GetStartValue(xmlNode.FirstChild, objectName);
            }
            else
            {
                foreach (XmlNode childNide in xmlNode.ChildNodes)
                {
                    if (objectName.Equals(childNide.Name))
                    {
                        return childNide.InnerText;
                    }
                }
            }
            return "";
        }

        public List<String> GetDocumentData(XmlNode xml)
        {
            List<String> data = new List<String>();
            FillList(xml, data);
            return data;
        }

        private void FillList(XmlNode xmlNode, List<String> list)
        {
            if (xmlNode.HasChildNodes)
            {
                foreach (XmlNode childXmlNode in xmlNode.ChildNodes)
                {
                    FillList(childXmlNode, list);
                }
            }
            else
            {
                list.Add(xmlNode.InnerText);
            }
        }

        public List<String> GetNumericValuesList(XmlNode xml)
        {
            
            List<String> numericValues = new List<String>();
            FillNumericObjectsList(xml, numericValues);
            return getSameObjectsList(xml, numericValues);
        }

        private void FillNumericObjectsList(XmlNode xmlNode, List<String> list)
        {
            if (xmlNode.HasChildNodes)
            {
                foreach (XmlNode childXmlNode in xmlNode.ChildNodes)
                {
                    FillNumericObjectsList(childXmlNode, list);
                }
            }
            else
            {
                double res;
                bool isDigit = Double.TryParse(xmlNode.InnerText, out res);
                if(isDigit){
                    if (list.BinarySearch(xmlNode.ParentNode.Name) < 0)
                    {
                        list.Add(xmlNode.ParentNode.Name);
                    }
                }
            }
        }

        public List<String> GetCharValuesList(XmlNode xml)
        {

            List<String> charValues = new List<String>();
            FillCharObjectsList(xml, charValues);
            return getSameObjectsList(xml, charValues);
        }

        private void FillCharObjectsList(XmlNode xmlNode, List<String> list)
        {
            list.Sort();
            if (xmlNode.HasChildNodes)
            {
                foreach (XmlNode childXmlNode in xmlNode.ChildNodes)
                {
                    FillCharObjectsList(childXmlNode, list);
                }
            }
            else
            {
                double res;
                bool isDigit = Double.TryParse(xmlNode.InnerText, out res);
                if (!isDigit)
                {
                    if (list.BinarySearch(xmlNode.ParentNode.Name) < 0)
                    {
                        list.Add(xmlNode.ParentNode.Name);
                    }
                }
            }
        }

       
        private List<String> getSameObjectsList(XmlNode xmlNode, List<String> values)
        {
            List<String> resultList = values.ToList();
            foreach (XmlNode childXmlNode in xmlNode.ChildNodes)
            {
                List<String> tempValues = values.ToList();
                foreach (XmlNode childChildXmlNode in childXmlNode.ChildNodes)
                {
                    int count = tempValues.BinarySearch(childChildXmlNode.Name);
                    if (count >= 0)
                    {
                        tempValues.RemoveAt(count);
                    }
                }
                resultList = resultList.Except(tempValues).ToList();
            }
            return resultList;
        }

        public XmlDocument refactor(XmlNode xmlNode, XmlDocument xmlDocument)
        {
            List<String> elementsList = new List<String> {"FirstName", "LastName", "Surname", "Score", "Email"};
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
                        tempValues.AddRange(new string[] { "FirstName", "LastName", "Surname"});
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
                        if ("Score".Equals(name)){
                            nameText = xmlDocument.CreateTextNode("0");
                        }
                        else{
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
    }
}
