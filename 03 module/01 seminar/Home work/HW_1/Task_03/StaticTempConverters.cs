using System;
using System.Collections.Generic;
using System.Text;

namespace Task_03
{
    class StaticTempConverters
    {
        public static double FromCelsToKelv(double temperatureC)
        {
            return temperatureC + 273;
        }

        public static double FromKelvToCels(double temperatureK)
        {
            return temperatureK - 273;
        }

        public static double FromCelsToRa(double temperatureC)
        {
            return FromCelsToKelv(temperatureC) * 1.8;
        }

        public static double FromRaToCels(double temperatureRa)
        {
            return FromKelvToCels(temperatureRa / 1.8);
        }

        public static double FromCelsToRe(double temperatureC)
        {
            return temperatureC * 0.8;
        }

        public static double FromReToCels(double temperatureR)
        {
            return temperatureR * 1.25;
        }
    }
}
