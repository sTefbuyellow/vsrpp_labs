
namespace bntu.vsrpp.kkirichuk.lab2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loadCurrenciesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromComboBox = new System.Windows.Forms.ComboBox();
            this.toComboBox = new System.Windows.Forms.ComboBox();
            this.fromLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.fromTextBox = new System.Windows.Forms.TextBox();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.currenciesComboBox = new System.Windows.Forms.ComboBox();
            this.plotView = new OxyPlot.WindowsForms.PlotView();
            this.minLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.avLabel = new System.Windows.Forms.Label();
            this.minValLabel = new System.Windows.Forms.Label();
            this.avValLabel = new System.Windows.Forms.Label();
            this.maxValLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadCurrenciesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(836, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loadCurrenciesToolStripMenuItem
            // 
            this.loadCurrenciesToolStripMenuItem.Name = "loadCurrenciesToolStripMenuItem";
            this.loadCurrenciesToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.loadCurrenciesToolStripMenuItem.Text = "Load Currencies";
            this.loadCurrenciesToolStripMenuItem.Click += new System.EventHandler(this.loadCurrenciesToolStripMenuItem_Click);
            // 
            // fromComboBox
            // 
            this.fromComboBox.FormattingEnabled = true;
            this.fromComboBox.Location = new System.Drawing.Point(220, 66);
            this.fromComboBox.Name = "fromComboBox";
            this.fromComboBox.Size = new System.Drawing.Size(154, 23);
            this.fromComboBox.TabIndex = 1;
            this.fromComboBox.SelectedIndexChanged += new System.EventHandler(this.fromComboBox_SelectedIndexChanged);
            // 
            // toComboBox
            // 
            this.toComboBox.FormattingEnabled = true;
            this.toComboBox.Location = new System.Drawing.Point(463, 66);
            this.toComboBox.Name = "toComboBox";
            this.toComboBox.Size = new System.Drawing.Size(153, 23);
            this.toComboBox.TabIndex = 2;
            this.toComboBox.SelectedIndexChanged += new System.EventHandler(this.toComboBox_SelectedIndexChanged);
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(220, 45);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(35, 15);
            this.fromLabel.TabIndex = 3;
            this.fromLabel.Text = "From";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(463, 45);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(19, 15);
            this.toLabel.TabIndex = 4;
            this.toLabel.Text = "To";
            // 
            // fromTextBox
            // 
            this.fromTextBox.Location = new System.Drawing.Point(220, 95);
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.Size = new System.Drawing.Size(154, 23);
            this.fromTextBox.TabIndex = 5;
            this.fromTextBox.TextChanged += new System.EventHandler(this.fromTextBox_TextChanged);
            this.fromTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fromTextBox_KeyPress);
            // 
            // toTextBox
            // 
            this.toTextBox.Location = new System.Drawing.Point(463, 96);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new System.Drawing.Size(153, 23);
            this.toTextBox.TabIndex = 6;
            this.toTextBox.TextChanged += new System.EventHandler(this.toTextBox_TextChanged);
            this.toTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toTextBox_KeyPress);
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.startDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDateTimePicker.Location = new System.Drawing.Point(133, 167);
            this.startDateTimePicker.MinDate = new System.DateTime(1991, 1, 1, 0, 0, 0, 0);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.startDateTimePicker.TabIndex = 8;
            this.startDateTimePicker.Value = new System.DateTime(2021, 10, 20, 23, 0, 1, 0);
            this.startDateTimePicker.ValueChanged += new System.EventHandler(this.startDateTimePicker_ValueChanged);
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDateTimePicker.Location = new System.Drawing.Point(466, 167);
            this.endDateTimePicker.MinDate = new System.DateTime(1991, 1, 2, 0, 0, 0, 0);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.endDateTimePicker.TabIndex = 9;
            this.endDateTimePicker.ValueChanged += new System.EventHandler(this.endDateTimePicker_ValueChanged);
            // 
            // currenciesComboBox
            // 
            this.currenciesComboBox.FormattingEnabled = true;
            this.currenciesComboBox.Location = new System.Drawing.Point(339, 167);
            this.currenciesComboBox.Name = "currenciesComboBox";
            this.currenciesComboBox.Size = new System.Drawing.Size(121, 23);
            this.currenciesComboBox.TabIndex = 11;
            this.currenciesComboBox.SelectedIndexChanged += new System.EventHandler(this.currenciesComboBox_SelectedIndexChanged);
            // 
            // plotView
            // 
            this.plotView.Location = new System.Drawing.Point(33, 220);
            this.plotView.Name = "plotView";
            this.plotView.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView.Size = new System.Drawing.Size(782, 321);
            this.plotView.TabIndex = 12;
            this.plotView.Text = "plotView1";
            this.plotView.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(133, 556);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(28, 15);
            this.minLabel.TabIndex = 13;
            this.minLabel.Text = "Min";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Location = new System.Drawing.Point(627, 548);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(30, 15);
            this.maxLabel.TabIndex = 14;
            this.maxLabel.Text = "Max";
            // 
            // avLabel
            // 
            this.avLabel.AutoSize = true;
            this.avLabel.Location = new System.Drawing.Point(335, 547);
            this.avLabel.Name = "avLabel";
            this.avLabel.Size = new System.Drawing.Size(50, 15);
            this.avLabel.TabIndex = 15;
            this.avLabel.Text = "Average";
            // 
            // minValLabel
            // 
            this.minValLabel.AutoSize = true;
            this.minValLabel.Location = new System.Drawing.Point(168, 555);
            this.minValLabel.Name = "minValLabel";
            this.minValLabel.Size = new System.Drawing.Size(0, 15);
            this.minValLabel.TabIndex = 16;
            // 
            // avValLabel
            // 
            this.avValLabel.AutoSize = true;
            this.avValLabel.Location = new System.Drawing.Point(392, 546);
            this.avValLabel.Name = "avValLabel";
            this.avValLabel.Size = new System.Drawing.Size(0, 15);
            this.avValLabel.TabIndex = 17;
            // 
            // maxValLabel
            // 
            this.maxValLabel.AutoSize = true;
            this.maxValLabel.Location = new System.Drawing.Point(664, 548);
            this.maxValLabel.Name = "maxValLabel";
            this.maxValLabel.Size = new System.Drawing.Size(0, 15);
            this.maxValLabel.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 583);
            this.Controls.Add(this.maxValLabel);
            this.Controls.Add(this.avValLabel);
            this.Controls.Add(this.minValLabel);
            this.Controls.Add(this.avLabel);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.plotView);
            this.Controls.Add(this.currenciesComboBox);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.toTextBox);
            this.Controls.Add(this.fromTextBox);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.toComboBox);
            this.Controls.Add(this.fromComboBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loadCurrenciesToolStripMenuItem;
        private System.Windows.Forms.ComboBox fromComboBox;
        private System.Windows.Forms.ComboBox toComboBox;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.TextBox fromTextBox;
        private System.Windows.Forms.TextBox toTextBox;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.ComboBox currenciesComboBox;
        private OxyPlot.WindowsForms.PlotView plotView;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label avLabel;
        private System.Windows.Forms.Label minValLabel;
        private System.Windows.Forms.Label avValLabel;
        private System.Windows.Forms.Label maxValLabel;
    }
}

