using System.IO;
using System.Text;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class StructuredTextParser : IJavaObjectProxy<org.mpxj.primavera.StructuredTextParser>
    {
        public org.mpxj.primavera.StructuredTextParser JavaObject { get; }

        public StructuredTextParser()
        {
            JavaObject = new org.mpxj.primavera.StructuredTextParser();
        }

        public bool RaiseExceptionOnParseError
        {
            set => JavaObject.setRaiseExceptionOnParseError(value);
        }

        public StructuredTextRecord Parse(string input) => new StructuredTextRecord(JavaObject.parse(input));

        public StructuredTextRecord Parse(Stream input) => new StructuredTextRecord(JavaObject.parse(input.ConvertType()));

        public StructuredTextRecord Parse(Stream input, Encoding encoding) => new StructuredTextRecord(JavaObject.parse(input.ConvertType(), encoding.ConvertType()));
    }
}
