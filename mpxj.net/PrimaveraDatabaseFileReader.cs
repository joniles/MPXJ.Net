using System.Collections.Generic;
using System.Linq;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class PrimaveraDatabaseFileReader : AbstractProjectReader
    {
        internal PrimaveraDatabaseFileReader(org.mpxj.primavera.PrimaveraDatabaseFileReader reader) : base(reader) { }

        public PrimaveraDatabaseFileReader() : base(new org.mpxj.primavera.PrimaveraDatabaseFileReader()) { }

        public new org.mpxj.primavera.PrimaveraDatabaseFileReader JavaObject => (org.mpxj.primavera.PrimaveraDatabaseFileReader)base.JavaObject;

        public int ProjectID
        {
            set => JavaObject.setProjectID(value);
        }

        public Dictionary<int, string> ListProjects(string name)
        {
            var projects = JavaObject.listProjects(new java.io.File(name));
            return new ProxyEnumerable<java.util.Map.Entry, java.util.Map.Entry>(m => m, m => m, projects.entrySet()).ToDictionary(e => ((java.lang.Integer)e.getKey()).intValue(), e => (string)e.getValue());
        }

        public EPS ListEPS(string name) => new EPS(JavaObject.listEps(new java.io.File(name)));
    }
}
