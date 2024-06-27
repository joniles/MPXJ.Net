using System.Collections.Generic;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class StructuredTextRecord : IJavaObjectProxy<net.sf.mpxj.primavera.StructuredTextRecord>
    {
        public net.sf.mpxj.primavera.StructuredTextRecord JavaObject { get; }

        internal StructuredTextRecord(net.sf.mpxj.primavera.StructuredTextRecord javaObject)
        {
            JavaObject = javaObject;
        }

        public StructuredTextRecord()
        {
            JavaObject = new net.sf.mpxj.primavera.StructuredTextRecord();
        }
        public StructuredTextRecord(Dictionary<string, string> attributes, List<StructuredTextRecord> children)
        {
            JavaObject = new net.sf.mpxj.primavera.StructuredTextRecord(attributes.ConvertType(), children.ConvertType());
        }

        public string RecordName => JavaObject.getRecordName();

        public string RecordNumber => JavaObject.getRecordNumber();

        public string GetAttribute(string name) => JavaObject.getAttribute(name);

        public Dictionary<string, string> Attributes
        {
            get
            {
                var result = new Dictionary<string, string>();
                foreach (var e in new ProxyEnumerable<java.util.Map.Entry, java.util.Map.Entry>(m => m, m => m, JavaObject.getAttributes().entrySet()))
                {
                    result.Add((string)e.getKey(), (string)e.getValue());
                }
                return result;
            }
        }

        public IList<StructuredTextRecord> Children => new ProxyList<net.sf.mpxj.primavera.StructuredTextRecord, StructuredTextRecord>(v => new StructuredTextRecord(v), v => v.JavaObject, JavaObject.getChildren());

        public StructuredTextRecord GetChild(string name)
        {
            var result = JavaObject.getChild(name);
            return result == null ? null : new StructuredTextRecord(result);
        }

        public void AddAttribute(string name, string value) => JavaObject.addAttribute(name, value);

        public void AddChild(StructuredTextRecord child) => JavaObject.addChild(child.JavaObject);
    }
}
