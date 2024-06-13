using System.Collections.Generic;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class PrimaveraDatabaseFileReader : AbstractProjectReader
    {
        internal PrimaveraDatabaseFileReader(net.sf.mpxj.primavera.PrimaveraDatabaseFileReader reader) : base(reader) { }

        public PrimaveraDatabaseFileReader() : base(new net.sf.mpxj.primavera.PrimaveraDatabaseFileReader()) { }

        public new net.sf.mpxj.primavera.PrimaveraDatabaseFileReader JavaObject => (net.sf.mpxj.primavera.PrimaveraDatabaseFileReader)base.JavaObject;

        public int ProjectID
        {
            set => JavaObject.setProjectID(value);
        }

        public Dictionary<int, string> ListProjects(string name)
        {
            var projects = JavaObject.listProjects(new java.io.File(name));
            var result = new Dictionary<int, string>();
            foreach (var e in new ProxyEnumerable<java.util.Map.Entry, java.util.Map.Entry>(m => m, m => m, projects.entrySet()))
            {
                result.Add(((java.lang.Integer)e.getKey()).intValue(), (string)e.getValue());
            }
            return result;
        }
    }
}
