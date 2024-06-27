using NUnit.Framework;

namespace MPXJ.Net
{
    public class StructuredTextRecordTest
    {
        [Test]
        public void MethodTest()
        {
            var sample = "(0||CalendarData()(\u007f\u007f  (0||DaysOfWeek()(\u007f\u007f    (0||1()())\u007f\u007f    (0||2()(\u007f\u007f      (0||0(s|06:00|f|16:00)())))\u007f\u007f    (0||3()(\u007f\u007f      (0||0(s|06:00|f|16:00)())))\u007f\u007f    (0||4()(\u007f\u007f      (0||0(s|06:00|f|16:00)())))\u007f\u007f    (0||5()(\u007f\u007f      (0||0(s|06:00|f|16:00)())))\u007f\u007f    (0||6()())\u007f\u007f    (0||7()())))\u007f\u007f  (0||VIEW(ShowTotal|N)())\u007f\u007f  (0||Exceptions()(\u007f\u007f    (0||0(d|38316)())\u007f\u007f    (0||1(d|38317)())\u007f\u007f    (0||2(d|38345)())\u007f\u007f    (0||3(d|38348)())\u007f\u007f    (0||4(d|38352)())))))";
            var record = new StructuredTextParser().Parse(sample);

            Assert.That(record.RecordNumber, Is.EqualTo("0"));
            Assert.That(record.RecordName, Is.EqualTo("CalendarData"));
            Assert.That(record.Children, Has.Count.EqualTo(3));
            Assert.That(record.GetChild("DaysOfWeek"), Is.Not.Null);
            Assert.That(record.Attributes, Has.Count.EqualTo(2));
        }
    }
}
