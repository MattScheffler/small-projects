using System;
using System.Windows.Forms;

namespace TemperatureConverter
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        //conversion formulas
        public static double fahrenheitToCelsius(double temp)
        {
            return ((temp - 32.0) * (5.0 / 9.0));
        }

        public static double celsiusToFahrenheit(double temp)
        {
            return (temp * (9.0/5.0) + 32.0);
        }

        public static double celsiusToKelvin(double temp)
        {
            return (temp + 273.15);
        }

        public static double kelvinToCelsius(double temp)
        {
            return (temp - 273.15);
        }

        public static double kelvinToFahrenheit(double temp)
        {
            return (celsiusToFahrenheit(kelvinToCelsius(temp)));
        }

        public static double fahrenheitToKelvin(double temp)
        {
            return (celsiusToKelvin(fahrenheitToCelsius(temp)));
        }
    }
}
