using bntu.vsrpp.kkirichuk.Core;

namespace bntu.vsrpp.kkirichuk.lab01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.displayListBox = new System.Windows.Forms.ListBox();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.FileItemMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveRefactoredFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openXMLDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.digitObjectsComboBox = new System.Windows.Forms.ComboBox();
            this.charObjectsComboBox = new System.Windows.Forms.ComboBox();
            this.minDigitButton = new System.Windows.Forms.Button();
            this.averageDigitButton = new System.Windows.Forms.Button();
            this.maxDigitButton = new System.Windows.Forms.Button();
            this.minCharButton = new System.Windows.Forms.Button();
            this.averageCharButton = new System.Windows.Forms.Button();
            this.maxCharButton = new System.Windows.Forms.Button();
            this.saveXMLDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // displayListBox
            // 
            this.displayListBox.FormattingEnabled = true;
            this.displayListBox.ItemHeight = 15;
            this.displayListBox.Location = new System.Drawing.Point(345, 43);
            this.displayListBox.Name = "displayListBox";
            this.displayListBox.Size = new System.Drawing.Size(184, 229);
            this.displayListBox.TabIndex = 0;
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem1});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(546, 24);
            this.MenuStrip.TabIndex = 1;
            this.MenuStrip.Text = "File";
            // 
            // FileMenuItem1
            // 
            this.FileMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileItemMenuItem1,
            this.saveRefactoredFileToolStripMenuItem});
            this.FileMenuItem1.Name = "FileMenuItem1";
            this.FileMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.FileMenuItem1.Text = "File";
            // 
            // FileItemMenuItem1
            // 
            this.FileItemMenuItem1.Name = "FileItemMenuItem1";
            this.FileItemMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.FileItemMenuItem1.Text = "LoadXml";
            this.FileItemMenuItem1.Click += new System.EventHandler(this.FileItemMenuItem1_Click);
            // 
            // saveRefactoredFileToolStripMenuItem
            // 
            this.saveRefactoredFileToolStripMenuItem.Name = "saveRefactoredFileToolStripMenuItem";
            this.saveRefactoredFileToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.saveRefactoredFileToolStripMenuItem.Text = "SaveRefactoredFile";
            this.saveRefactoredFileToolStripMenuItem.Click += new System.EventHandler(this.saveRefactoredFileToolStripMenuItem_Click);
            // 
            // openXMLDialog1
            // 
            this.openXMLDialog1.FileName = "openFileDialog1";
            // 
            // digitObjectsComboBox
            // 
            this.digitObjectsComboBox.Enabled = false;
            this.digitObjectsComboBox.FormattingEnabled = true;
            this.digitObjectsComboBox.Location = new System.Drawing.Point(12, 106);
            this.digitObjectsComboBox.Name = "digitObjectsComboBox";
            this.digitObjectsComboBox.Size = new System.Drawing.Size(172, 23);
            this.digitObjectsComboBox.TabIndex = 2;
            // 
            // charObjectsComboBox
            // 
            this.charObjectsComboBox.Enabled = false;
            this.charObjectsComboBox.FormattingEnabled = true;
            this.charObjectsComboBox.Location = new System.Drawing.Point(12, 166);
            this.charObjectsComboBox.Name = "charObjectsComboBox";
            this.charObjectsComboBox.Size = new System.Drawing.Size(172, 23);
            this.charObjectsComboBox.TabIndex = 3;
            // 
            // minDigitButton
            // 
            this.minDigitButton.Location = new System.Drawing.Point(190, 105);
            this.minDigitButton.Name = "minDigitButton";
            this.minDigitButton.Size = new System.Drawing.Size(40, 23);
            this.minDigitButton.TabIndex = 4;
            this.minDigitButton.Text = "min";
            this.minDigitButton.UseVisualStyleBackColor = true;
            this.minDigitButton.Click += new System.EventHandler(this.minDigitButton_Click);
            // 
            // averageDigitButton
            // 
            this.averageDigitButton.Location = new System.Drawing.Point(236, 105);
            this.averageDigitButton.Name = "averageDigitButton";
            this.averageDigitButton.Size = new System.Drawing.Size(40, 23);
            this.averageDigitButton.TabIndex = 5;
            this.averageDigitButton.Text = "avg";
            this.averageDigitButton.UseVisualStyleBackColor = true;
            this.averageDigitButton.Click += new System.EventHandler(this.averageDigitButton_Click);
            // 
            // maxDigitButton
            // 
            this.maxDigitButton.Location = new System.Drawing.Point(283, 106);
            this.maxDigitButton.Name = "maxDigitButton";
            this.maxDigitButton.Size = new System.Drawing.Size(40, 22);
            this.maxDigitButton.TabIndex = 6;
            this.maxDigitButton.Text = "max";
            this.maxDigitButton.UseVisualStyleBackColor = true;
            this.maxDigitButton.Click += new System.EventHandler(this.maxDigitButton_Click);
            // 
            // minCharButton
            // 
            this.minCharButton.Location = new System.Drawing.Point(190, 166);
            this.minCharButton.Name = "minCharButton";
            this.minCharButton.Size = new System.Drawing.Size(40, 23);
            this.minCharButton.TabIndex = 7;
            this.minCharButton.Text = "min";
            this.minCharButton.UseVisualStyleBackColor = true;
            this.minCharButton.Click += new System.EventHandler(this.minCharButton_Click);
            // 
            // averageCharButton
            // 
            this.averageCharButton.Location = new System.Drawing.Point(236, 166);
            this.averageCharButton.Name = "averageCharButton";
            this.averageCharButton.Size = new System.Drawing.Size(40, 23);
            this.averageCharButton.TabIndex = 8;
            this.averageCharButton.Text = "avg";
            this.averageCharButton.UseVisualStyleBackColor = true;
            this.averageCharButton.Click += new System.EventHandler(this.averageCharButton_Click);
            // 
            // maxCharButton
            // 
            this.maxCharButton.Location = new System.Drawing.Point(283, 165);
            this.maxCharButton.Name = "maxCharButton";
            this.maxCharButton.Size = new System.Drawing.Size(40, 24);
            this.maxCharButton.TabIndex = 9;
            this.maxCharButton.Text = "max";
            this.maxCharButton.UseVisualStyleBackColor = true;
            this.maxCharButton.Click += new System.EventHandler(this.maxCharButton_Click);
            // 
            // saveXMLDialog1
            // 
            this.saveXMLDialog1.InitialDirectory = "D://";
            this.saveXMLDialog1.Tag = "xml";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 284);
            this.Controls.Add(this.maxCharButton);
            this.Controls.Add(this.averageCharButton);
            this.Controls.Add(this.minCharButton);
            this.Controls.Add(this.maxDigitButton);
            this.Controls.Add(this.averageDigitButton);
            this.Controls.Add(this.minDigitButton);
            this.Controls.Add(this.charObjectsComboBox);
            this.Controls.Add(this.digitObjectsComboBox);
            this.Controls.Add(this.displayListBox);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox displayListBox;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem FileItemMenuItem1;
        private System.Windows.Forms.OpenFileDialog openXMLDialog1;
        private System.Windows.Forms.ComboBox digitObjectsComboBox;
        private System.Windows.Forms.ComboBox charObjectsComboBox;
        private System.Windows.Forms.Button minDigitButton;
        private System.Windows.Forms.Button averageDigitButton;
        private System.Windows.Forms.Button maxDigitButton;
        private System.Windows.Forms.Button minCharButton;
        private System.Windows.Forms.Button averageCharButton;
        private System.Windows.Forms.Button maxCharButton;
        private System.Windows.Forms.ToolStripMenuItem saveRefactoredFileToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveXMLDialog1;
    }
}

