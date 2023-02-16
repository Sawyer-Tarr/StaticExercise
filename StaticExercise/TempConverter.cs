using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double temp1) 
        {
            return (temp1 - 32) * .5556;
        }
        public static double CelsiusToFahrenheit(double temp2) 
        {
            return (temp2 * 1.8) + 32;
        }


    }
}
