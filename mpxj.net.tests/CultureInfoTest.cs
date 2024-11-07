using NUnit.Framework;
using System.Globalization;

namespace MPXJ.Net
{
    public class CultureInfoTest
    {
        [Test]
        public void ExtensionMethodsTest()
        {
            // Required to initialize the IKVM'd Java classes correctly
            // before accessing Charset. Be nice if this wasn't required...
            // ReSharper disable once UnusedVariable
            var project = new ProjectFile();

            Assert.That(java.util.Locale.ENGLISH.ConvertType(), Is.EqualTo(CultureInfo.GetCultureInfo("en")));

            Assert.That(new java.util.Locale("EN").ConvertType(), Is.EqualTo(CultureInfo.GetCultureInfo("en")));
            Assert.That(new java.util.Locale("DE").ConvertType(), Is.EqualTo(CultureInfo.GetCultureInfo("de")));
            Assert.That(new java.util.Locale("FR").ConvertType(), Is.EqualTo(CultureInfo.GetCultureInfo("fr")));
            Assert.That(new java.util.Locale("IT").ConvertType(), Is.EqualTo(CultureInfo.GetCultureInfo("it")));
            Assert.That(new java.util.Locale("PT").ConvertType(), Is.EqualTo(CultureInfo.GetCultureInfo("pt")));
            Assert.That(new java.util.Locale("SV").ConvertType(), Is.EqualTo(CultureInfo.GetCultureInfo("sv")));
            Assert.That(new java.util.Locale("ZH").ConvertType(), Is.EqualTo(CultureInfo.GetCultureInfo("zh")));
            Assert.That(new java.util.Locale("ES").ConvertType(), Is.EqualTo(CultureInfo.GetCultureInfo("es")));
            Assert.That(new java.util.Locale("RU").ConvertType(), Is.EqualTo(CultureInfo.GetCultureInfo("ru")));

            Assert.That(MPXReader.SupportedCultures, Has.Length.EqualTo(9));
        }
    }
}
