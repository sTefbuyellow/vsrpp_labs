using System;
using System.Collections.Generic;
using System.Windows.Forms;
using bntu.vsrpp.kkirichuk.Core;

namespace bntu.vsrpp.kkirichuk.lab01
{
    public partial class Form1 : Form
    {
        private CustomXmlReader XmlReader;

        public Form1()
        {
            InitializeComponent();
        }

        private void FileItemMenuItem1_Click(object sender, EventArgs e)
        {
            openXMLDialog1.ShowDialog();
            var fileName = openXMLDialog1.FileName;
            if(fileName == null)
            {
                return;
            }
            XmlReader = new CustomXmlReader(fileName);
            List<String> data = XmlReader.GetDocumentData(XmlReader.RootXDoc);

            List<String> digitData = XmlReader.GetNumericValuesList(XmlReader.RootXDoc);
            List<String> charData = XmlReader.GetCharValuesList(XmlReader.RootXDoc);
            if (digitData.Count > 0) {
                digitObjectsComboBox.Enabled = true;
                this.digitObjectsComboBox.Items.AddRange(digitData.ToArray());
            }
            else
            {
                digitObjectsComboBox.Enabled = false;
            }
            if (charData.Count > 0)
            {
                charObjectsComboBox.Enabled = true;
                this.charObjectsComboBox.Items.AddRange(charData.ToArray());
            }
            else
            {
                charObjectsComboBox.Enabled = false;
            }
        }

        private void minDigitButton_Click(object sender, EventArgs e)
        {
            if (digitObjectsComboBox.SelectedItem == null)
            {
                MessageBox.Show("No values selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            String itemName = digitObjectsComboBox.SelectedItem.ToString();
            displayListBox.Items.Add("Min " + itemName + " value: " + XmlReader.GetMinValue(XmlReader.RootXDoc, itemName));
        }

        private void averageDigitButton_Click(object sender, EventArgs e)
        {
            if (digitObjectsComboBox.SelectedItem == null)
            {
                MessageBox.Show("No values selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            String itemName = digitObjectsComboBox.SelectedItem.ToString();
            displayListBox.Items.Add("Average " + itemName + " value: " + XmlReader.GetAverage(XmlReader.RootXDoc, itemName));
        }

        private void maxDigitButton_Click(object sender, EventArgs e)
        {
            if (digitObjectsComboBox.SelectedItem == null)
            {
                MessageBox.Show("No values selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            String itemName = digitObjectsComboBox.SelectedItem.ToString();
            displayListBox.Items.Add("Max " + itemName + " value: " + XmlReader.GetMaxValue(XmlReader.RootXDoc, itemName));
        }

        private void minCharButton_Click(object sender, EventArgs e)
        {
            if (charObjectsComboBox.SelectedItem == null)
            {
                MessageBox.Show("No values selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            String itemName = charObjectsComboBox.SelectedItem.ToString();
            displayListBox.Items.Add("Min " + itemName + " length: " + XmlReader.GetMinLength(XmlReader.RootXDoc, itemName));
        }

        private void averageCharButton_Click(object sender, EventArgs e)
        {
            if (charObjectsComboBox.SelectedItem == null)
            {
                MessageBox.Show("No values selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            String itemName = charObjectsComboBox.SelectedItem.ToString();
            displayListBox.Items.Add("Average " + itemName + " length: " + XmlReader.GetAverageLength(XmlReader.RootXDoc, itemName));
        }

        private void maxCharButton_Click(object sender, EventArgs e)
        {
            if (charObjectsComboBox.SelectedItem == null)
            {
                MessageBox.Show("No values selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            String itemName = charObjectsComboBox.SelectedItem.ToString();
            displayListBox.Items.Add("Max " + itemName + " length: " + XmlReader.GetMaxLength(XmlReader.RootXDoc, itemName));
        }
    }
}
