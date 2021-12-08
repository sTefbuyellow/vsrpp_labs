using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.Json;
using System.Windows.Forms;
using bntu.vsrpp.kkirichuk.Core;
using OxyPlot;
using OxyPlot.Series;

namespace bntu.vsrpp.kkirichuk.lab2
{
    public partial class Form1 : Form
    {
        Rate fromRate;
        Rate toRate;
        private List<Rate> rates;
        private List<Currency> currencies;
        CurrencyController currencyController;
        private Char separator;

        public Form1()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            currencyController = new CurrencyController();
            try
            {
                rates = currencyController.getRates("0").Result;
                rates.AddRange(currencyController.getRates("1").Result);
                currencies = currencyController.getCurrencies().Result;
            }
            catch(System.AggregateException)
            {
                MessageBox.Show("Offline");
                return;
            }

            toComboBox.Items.AddRange(rates.ToArray());
            fromComboBox.Items.AddRange(rates.ToArray());
            currenciesComboBox.Items.AddRange(rates.ToArray());
            Rate byn = new Rate(rates.Count, "BYN", 1, "Белорусских рублей", 1);
            rates.Add(byn);
            fromComboBox.Items.Add(byn);
            toComboBox.Items.Add(byn);
            separator = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];
            setDefaultRate();
        }

        private void loadCurrenciesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currencyController = new CurrencyController();
            try
            {
                rates = currencyController.getRates("0").Result;
                rates.AddRange(currencyController.getRates("1").Result);
                currencies = currencyController.getCurrencies().Result;
            }
            catch(System.AggregateException)
            {
                MessageBox.Show("Offline");
                return;
            }

            toComboBox.Items.AddRange(rates.ToArray());
            fromComboBox.Items.AddRange(rates.ToArray());
            currenciesComboBox.Items.AddRange(rates.ToArray());
            Rate byn = new Rate(rates.Count, "BYN", 1, "Белорусских рублей", 1);
            rates.Add(byn);
            fromComboBox.Items.Add(byn);
            toComboBox.Items.Add(byn);
            separator = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];
            setDefaultRate();
        }

        private void setDefaultRate()
        {
            fromRate = rates[26]; //BYN
            toRate = rates[5]; //USD
            fromTextBox.Text = "1,0000";
            fromComboBox.SelectedIndex = rates.Count-1; //BYN
            toComboBox.SelectedIndex = 5; //USD
            currenciesComboBox.SelectedIndex = 5;
            startDateTimePicker.Value = DateTime.Now.AddDays(-5);
            startDateTimePicker.MaxDate = DateTime.Now.AddDays(-1);
            endDateTimePicker.MaxDate = DateTime.Now;
        }

        private void fromComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            fromRate = rates[fromComboBox.SelectedIndex];
            decimal fromValue = string.IsNullOrEmpty(fromTextBox.Text) ? 0 : decimal.Parse(fromTextBox.Text);
            decimal ratedValue = fromValue * fromRate.Cur_OfficialRate * toRate.Cur_Scale / toRate.Cur_OfficialRate;
            ratedValue = Math.Round(ratedValue, 3);
            toTextBox.Text = ratedValue.ToString();
        }

        private void toComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            toRate = rates[toComboBox.SelectedIndex];
            decimal toValue = string.IsNullOrEmpty(toTextBox.Text) ? 0 : decimal.Parse(toTextBox.Text);
            decimal ratedValue = toValue * toRate.Cur_OfficialRate * fromRate.Cur_Scale / fromRate.Cur_OfficialRate;
            ratedValue = Math.Round(ratedValue, 3);
            fromTextBox.Text = ratedValue.ToString();
        }

        private async void startDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            getRateShorts();
        }

        private async void endDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            getRateShorts();
        }

        private void fromTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.KeyChar) || ((e.KeyChar == separator) && (DS_Count(((TextBox)sender).Text) < 1)) || e.KeyChar == 8);
            if (fromTextBox.Text.Length >= 8 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void toTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.KeyChar) || ((e.KeyChar == separator) && (DS_Count(((TextBox)sender).Text) < 1)) || e.KeyChar == 8);
            if (toTextBox.Text.Length >= 8 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void fromTextBox_TextChanged(object sender, EventArgs e)
        {
            toTextBox.TextChanged -= toTextBox_TextChanged;
            var fromValue = string.IsNullOrEmpty(fromTextBox.Text) ? 0 : decimal.Parse(fromTextBox.Text);
            var ratedValue = fromValue * fromRate.Cur_OfficialRate * toRate.Cur_Scale / toRate.Cur_OfficialRate;
            ratedValue = Math.Round(ratedValue, 3);
            toTextBox.Text = ratedValue.ToString();
            toTextBox.TextChanged += toTextBox_TextChanged;
        }

        private void toTextBox_TextChanged(object sender, EventArgs e)
        {
            fromTextBox.TextChanged -= fromTextBox_TextChanged;
            decimal toValue = string.IsNullOrEmpty(toTextBox.Text) ? 0 : decimal.Parse(toTextBox.Text);
            decimal ratedValue = toValue * toRate.Cur_OfficialRate * fromRate.Cur_Scale / fromRate.Cur_OfficialRate;
            ratedValue = Math.Round(ratedValue, 3);
            fromTextBox.Text = ratedValue.ToString();
            fromTextBox.TextChanged += fromTextBox_TextChanged;
        }

        private void currenciesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            getRateShorts();
        }
        private int DS_Count(string s)
        {
            string substr = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0].ToString();
            int count = (s.Length - s.Replace(substr, "").Length) / substr.Length;
            return count;
        }

        private void getRateShorts()
        {
            List<RateShort> rateShorts = new List<RateShort>();
            string startDate = startDateTimePicker.Text;
            string endDate = endDateTimePicker.Text;
            if (startDate == "")
            {
                startDate = DateTime.Now.AddDays(-5).ToString("yyyy-MM-dd");
            }
            if (endDate == "")
            {
                endDate = DateTime.Now.ToString("yyyy-MM-dd");
            }
            string abbreviation = rates[currenciesComboBox.SelectedIndex].Cur_Abbreviation;
            foreach (Currency currency in currencies)
            {
                if (currency.Cur_Abbreviation == abbreviation)
                {
                    DateTime curStartDate = DateTime.ParseExact(currency.Cur_DateStart, "yyyy-MM-ddTHH:mm:ss",
                        System.Globalization.CultureInfo.InvariantCulture);
                    DateTime selStartDate = DateTime.ParseExact(startDate, "yyyy-MM-dd",
                        System.Globalization.CultureInfo.InvariantCulture);
                    DateTime curEndDate = DateTime.ParseExact(currency.Cur_DateEnd, "yyyy-MM-ddTHH:mm:ss",
                        System.Globalization.CultureInfo.InvariantCulture);
                    if (DateTime.Compare(selStartDate, curEndDate) < 0)
                    {
                        rateShorts.AddRange(currencyController.getRateShorts(startDate, endDate, currency.Cur_ID).Result);
                    }
                }
            }
            
            var model = new PlotModel { Title = "Rates: " + startDate + " - " + endDate };
            var series1 = new LineSeries
            {
                MarkerType = MarkerType.Circle,
                MarkerSize = 4,
                MarkerStroke = OxyColors.White
            };
            int i = 0;
            double max = 0;
            double sum = 0;
            double min = 0;
            foreach (RateShort rateShort in rateShorts)
            {
                double value = rateShort.Cur_OfficialRate;
                if (i == 0)
                {
                    max = value;
                    min = value;
                }
                else
                {
                    if (max < value)
                        max = value;
                    if (min > value)
                        min = value;
                }

                sum += value;
                series1.Points.Add(new DataPoint(i++, rateShort.Cur_OfficialRate));
            }
            minValLabel.Text = min.ToString();
            maxValLabel.Text = max.ToString();
            avValLabel.Text = (sum / i).ToString();
            model.Series.Add(series1);
            plotView.Model = model;
        }
    }
}
