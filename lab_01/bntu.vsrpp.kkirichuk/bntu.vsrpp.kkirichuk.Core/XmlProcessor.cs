using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace bntu.vsrpp.kkirichuk.Core
{
    public static class CustomXmlProcessor
    {

        public static double GetAverageLength(this XmlNode xmlNode, String objectName)
        {
            return Math.Round(GetLengthSumm(xmlNode, objectName, 0) / GetCount(xmlNode, objectName, 0), 3);
        }
        public static double GetLengthSumm(this XmlNode xmlNode, String objectName, double startSumm)
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


        public static double GetAverage(this XmlNode xmlNode, String objectName)
        {
            return Math.Round(GetSumm(xmlNode, objectName, 0) / GetCount(xmlNode, objectName, 0), 3);
        }

        public static double GetSumm(this XmlNode xmlNode, String objectName, double startSumm)
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

        public static int GetCount(this XmlNode xmlNode, String objectName, int startCount)
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

        public static double GetMaxLength(this XmlNode xmlNode, String objectName)
        {
            String str = GetStartValue(xmlNode, objectName);
            return CountMaxLength(xmlNode, objectName, str.Length);
        }

        public static int CountMaxLength(this XmlNode xmlNode, String objectName, int maxValue)
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

        public static double GetMinLength(this XmlNode xmlNode, String objectName)
        {
            String str = GetStartValue(xmlNode, objectName);
            return CountMinLength(xmlNode, objectName, str.Length);
        }

        public static int CountMinLength(this XmlNode xmlNode, String objectName, int minValue)
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
        public static double GetMaxValue(this XmlNode xmlNode, String objectName)
        {
            double maxValue = Convert.ToDouble(GetStartValue(xmlNode, objectName));
            return CountMaxValue(xmlNode, objectName, maxValue);
        }

        public static double CountMaxValue(this XmlNode xmlNode, String objectName, double maxValue)
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

        public static double GetMinValue(this XmlNode xmlNode, String objectName)
        {
            double minValue = Convert.ToDouble(GetStartValue(xmlNode, objectName));
            return CountMinValue(xmlNode, objectName, minValue);
        }

        public static double CountMinValue(this XmlNode xmlNode, String objectName, double minValue)
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

        public static string GetStartValue(this XmlNode xmlNode, String objectName)
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

        public static List<String> GetDocumentData(XmlNode xml)
        {
            List<String> data = new List<String>();
            FillList(xml, data);
            return data;
        }

        private static void FillList(this XmlNode xmlNode, List<String> list)
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

        public static List<String> GetNumericValuesList(this XmlNode xml)
        {
            List<String> numericValues = new List<String>();
            FillNumericObjectsList(xml, numericValues);
            return getSameObjectsList(xml, numericValues);
        }

        private static void FillNumericObjectsList(this XmlNode xmlNode, List<String> list)
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
                if (isDigit)
                {
                    if (list.BinarySearch(xmlNode.ParentNode.Name) < 0)
                    {
                        list.Add(xmlNode.ParentNode.Name);
                    }
                }
            }
        }

        public static List<String> GetCharValuesList(this XmlNode xml)
        {

            List<String> charValues = new List<String>();
            FillCharObjectsList(xml, charValues);
            return getSameObjectsList(xml, charValues);
        }

        private static void FillCharObjectsList(this XmlNode xmlNode, List<String> list)
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


        private static List<String> getSameObjectsList(this XmlNode xmlNode, List<String> values)
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
    }
}