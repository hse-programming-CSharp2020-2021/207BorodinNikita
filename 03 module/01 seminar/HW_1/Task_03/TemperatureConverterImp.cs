using System;
using System.Collections.Generic;
using System.Text;

namespace Task_03
{
    class TemperatureConverterImp
    {
        public double FromCelsToFahr(double temperatureC)
        {
            return 1.8 * temperatureC + 32;
        }

        public double FromFahrToCels(double temperatureF)
        {
            return 5 * (temperatureF - 32) / 9;
        }
    }
}
