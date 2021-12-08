using System;
using System.Collections.Generic;
using System.Windows.Forms;
using bntu.vsrpp.kkirichuk.Core;

namespace bntu.vsrpp.kkirichuk.lab01
{
    public partial class Form1 : Form
    {
        private CustomXmlData XmlData;
        private String sourceFileName;

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
            sourceFileName = fileName;
            XmlData = new CustomXmlData(fileName);
            List<String> digitData = XmlData.RootXDoc.GetNumericValuesList();
            List<String> charData = XmlData.RootXDoc.GetCharValuesList();
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

        private void saveRefactoredFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlData.RootXDoc.save(XmlData.XDoc, sourceFileName);
        }

        private void minDigitButton_Click(object sender, EventArgs e)
        {
            if (digitObjectsComboBox.SelectedItem == null)
            {
                MessageBox.Show("No values selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            String itemName = digitObjectsComboBox.SelectedItem.ToString();
            displayListBox.Items.Add("Min " + itemName + " value: " + XmlData.RootXDoc.GetMinValue(itemName));
        }

        private void averageDigitButton_Click(object sender, EventArgs e)
        {
            if (digitObjectsComboBox.SelectedItem == null)
            {
                MessageBox.Show("No values selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            String itemName = digitObjectsComboBox.SelectedItem.ToString();
            displayListBox.Items.Add("Average " + itemName + " value: " + XmlData.RootXDoc.GetAverage(itemName));
        }

        private void maxDigitButton_Click(object sender, EventArgs e)
        {
            if (digitObjectsComboBox.SelectedItem == null)
            {
                MessageBox.Show("No values selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            String itemName = digitObjectsComboBox.SelectedItem.ToString();
            displayListBox.Items.Add("Max " + itemName + " value: " + XmlData.RootXDoc.GetMaxValue(itemName));
        }

        private void minCharButton_Click(object sender, EventArgs e)
        {
            if (charObjectsComboBox.SelectedItem == null)
            {
                MessageBox.Show("No values selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            String itemName = charObjectsComboBox.SelectedItem.ToString();
            displayListBox.Items.Add("Min " + itemName + " length: " + XmlData.RootXDoc.GetMinLength(itemName));
        }

        private void averageCharButton_Click(object sender, EventArgs e)
        {
            if (charObjectsComboBox.SelectedItem == null)
            {
                MessageBox.Show("No values selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            String itemName = charObjectsComboBox.SelectedItem.ToString();
            displayListBox.Items.Add("Average " + itemName + " length: " + XmlData.RootXDoc.GetAverageLength(itemName));
        }

        private void maxCharButton_Click(object sender, EventArgs e)
        {
            if (charObjectsComboBox.SelectedItem == null)
            {
                MessageBox.Show("No values selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            String itemName = charObjectsComboBox.SelectedItem.ToString();
            displayListBox.Items.Add("Max " + itemName + " length: " + XmlData.RootXDoc.GetMaxLength(itemName));
        }
    }
}
