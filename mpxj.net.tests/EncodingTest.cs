﻿using System.Text;
using NUnit.Framework;

namespace MPXJ.Net
{
    public class EncodingTest
    {
        [Test]
        public void ExtensionTest()
        {
#if NETCOREAPP
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
#endif
            // Required to initialize the IKVM'd Java classes correctly
            // before accessing Charset. Be nice if this wasn't required...
            // ReSharper disable once UnusedVariable
            var project = new ProjectFile();


            Assert.That(Encoding.UTF8.ConvertType(), Is.EqualTo(org.mpxj.common.CharsetHelper.UTF8));
            Assert.That(org.mpxj.common.CharsetHelper.UTF8.ConvertType(), Is.EqualTo(Encoding.UTF8));

            Assert.That(Encoding.Unicode.ConvertType(), Is.EqualTo(org.mpxj.common.CharsetHelper.UTF16));
            Assert.That(org.mpxj.common.CharsetHelper.UTF16.ConvertType(), Is.EqualTo(Encoding.Unicode));

            Assert.That(Encoding.GetEncoding(850).ConvertType(), Is.EqualTo(org.mpxj.common.CharsetHelper.CP850));
            Assert.That(org.mpxj.common.CharsetHelper.CP850.ConvertType(), Is.EqualTo(Encoding.GetEncoding(850)));

            Assert.That(Encoding.GetEncoding(1251).ConvertType(), Is.EqualTo(org.mpxj.common.CharsetHelper.CP1251));
            Assert.That(org.mpxj.common.CharsetHelper.CP1251.ConvertType(), Is.EqualTo(Encoding.GetEncoding(1251)));

            Assert.That(Encoding.GetEncoding(1252).ConvertType(), Is.EqualTo(org.mpxj.common.CharsetHelper.CP1252));
            Assert.That(org.mpxj.common.CharsetHelper.CP1252.ConvertType(), Is.EqualTo(Encoding.GetEncoding(1252)));

            Assert.That(Encoding.GetEncoding(437).ConvertType(), Is.EqualTo(org.mpxj.common.CharsetHelper.CP437));
            Assert.That(org.mpxj.common.CharsetHelper.CP437.ConvertType(), Is.EqualTo(Encoding.GetEncoding(437)));

            Assert.That(Encoding.GetEncoding("GB2312").ConvertType(), Is.EqualTo(org.mpxj.common.CharsetHelper.GB2312));
            Assert.That(org.mpxj.common.CharsetHelper.GB2312.ConvertType(), Is.EqualTo(Encoding.GetEncoding("GB2312")));

        }
    }
}
