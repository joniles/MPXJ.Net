using System.Collections.Generic;
using System.Linq;
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
            return new ProxyEnumerable<java.util.Map.Entry, java.util.Map.Entry>(m => m, m => m, projects.entrySet()).ToDictionary(e => ((java.lang.Integer)e.getKey()).intValue(), e => (string)e.getValue());
        }
    }
}
