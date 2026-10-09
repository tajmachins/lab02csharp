
using TemperaturConverter.Lib;
namespace TemperatureUtilsTests.Tests;
[TestClass]
public sealed class TemperatureUtilsTests
{
    [TestMethod]
    public void CelsiusToFahrenheit0to32()
    {
        double result = TemperatureUtils.CelsiusToFahrenheit(0);
        Assert.AreEqual(32, result);

    }
    [TestMethod]
    public void CelsiusToFahrenheit100to212()
    {
        double result = TemperatureUtils.CelsiusToFahrenheit(100);
        Assert.AreEqual(212, result);

    }
    [TestMethod]
    public void CelsiusToFahrenheitmin40tomin40()
    {
        double result = TemperatureUtils.CelsiusToFahrenheit(-40);
        Assert.AreEqual(-40, result);

    }
}

