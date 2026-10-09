using TemperaturConverter.Lib;
using System;

double[] temperatures = { -20, 0, 20, 100 };

foreach(double t in temperatures)
{
    double fahrenheit = TemperatureUtils.CelsiusToFahrenheit(t);
    Console.WriteLine($"{t} in fahrenheit is {fahrenheit}");
}