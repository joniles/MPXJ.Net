using NUnit.Framework;

namespace MPXJ.Net
{
    public class CurrencyTest
    {
        [Test]
        public void MethodTest()
        {
            var project = new ProjectFile();

            var currency = new Currency.Builder(project)
                .UniqueID(1)
                .Name("US Dollar")
                .DecimalSymbol(".")
                .Symbol("$")
                .CurrencyId("USD")
                .ExchangeRate(1.0)
                .DigitGroupingSymbol(",")
                .NegativeCurrencyFormat("(#1.1)")
                .PositiveCurrencyFormat("#1.1")
                .NumberOfDecimalPlaces(2)
                .Build();

            Assert.That(currency.UniqueID, Is.EqualTo(1));
            Assert.That(currency.Name, Is.EqualTo("US Dollar"));
            Assert.That(currency.DecimalSymbol, Is.EqualTo("."));
            Assert.That(currency.Symbol, Is.EqualTo("$"));
            Assert.That(currency.CurrencyId, Is.EqualTo("USD"));
            Assert.That(currency.ExchangeRate, Is.EqualTo(1.0));
            Assert.That(currency.DigitGroupingSymbol, Is.EqualTo(","));
            Assert.That(currency.NegativeCurrencyFormat, Is.EqualTo("(#1.1)"));
            Assert.That(currency.PositiveCurrencyFormat, Is.EqualTo("#1.1"));
            Assert.That(currency.NumberOfDecimalPlaces, Is.EqualTo(2));
            
            project.Currencies.Add(currency);
            Assert.That(project.Currencies, Has.Count.EqualTo(1));
        }
    }
}