using System;
using System.Windows.Forms;

namespace TemperatureConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxConvertFrom.SelectedIndex)
                {
                    //Different cases for which temperature scales are selected
                    case 0:
                        if (comboBoxConvertTo.SelectedIndex == 0)
                            textBoxConvertResult.Text = (double.Parse(textBoxInput.Text)).ToString();
                        else if (comboBoxConvertTo.SelectedIndex == 1)
                            textBoxConvertResult.Text = (Program.fahrenheitToCelsius(double.Parse(textBoxInput.Text))).ToString();
                        else if (comboBoxConvertTo.SelectedIndex == 2)
                            textBoxConvertResult.Text = (Program.fahrenheitToKelvin(double.Parse(textBoxInput.Text))).ToString();
                        break;
                    case 1:
                        if (comboBoxConvertTo.SelectedIndex == 0)
                            textBoxConvertResult.Text = (Program.celsiusToFahrenheit(double.Parse(textBoxInput.Text))).ToString();
                        else if (comboBoxConvertTo.SelectedIndex == 1)
                            textBoxConvertResult.Text = (double.Parse(textBoxInput.Text)).ToString();
                        else if (comboBoxConvertTo.SelectedIndex == 2)
                            textBoxConvertResult.Text = (Program.celsiusToKelvin(double.Parse(textBoxInput.Text))).ToString();
                        break;
                    case 2:
                        if (comboBoxConvertTo.SelectedIndex == 0)
                            textBoxConvertResult.Text = (Program.kelvinToFahrenheit(double.Parse(textBoxInput.Text))).ToString();
                        else if (comboBoxConvertTo.SelectedIndex == 1)
                            textBoxConvertResult.Text = (Program.kelvinToCelsius(double.Parse(textBoxInput.Text))).ToString();
                        else if (comboBoxConvertTo.SelectedIndex == 2)
                            textBoxConvertResult.Text = (double.Parse(textBoxInput.Text)).ToString();
                        break;
                }
            }
            catch (Exception)
            {
                //If the user enters something other than numbers, display nothing
                textBoxConvertResult.Text = "";
            }

        }

        //The theme selected is saved as a user setting to be displayed when the application is opened again.
        //None is 0, Sky is 1, and Nebula is 2
        private void noneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            Properties.Settings.Default["Theme"] = 0;
            Properties.Settings.Default.Save();
        }

        private void skyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.SkyTheme;
            Properties.Settings.Default["Theme"] = 1;
            Properties.Settings.Default.Save();
        }

        private void nebulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.NebulaTheme;
            Properties.Settings.Default["Theme"] = 2;
            Properties.Settings.Default.Save();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if ((int)Properties.Settings.Default["Theme"] == 1)
                this.BackgroundImage = Properties.Resources.SkyTheme;
            if ((int)Properties.Settings.Default["Theme"] == 2)
                this.BackgroundImage = Properties.Resources.NebulaTheme;
        }
    }
}
