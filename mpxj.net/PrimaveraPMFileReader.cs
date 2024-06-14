using System.IO;
using System.Collections.Generic;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class PrimaveraPMFileReader : AbstractProjectReader
    {
        internal PrimaveraPMFileReader(net.sf.mpxj.primavera.PrimaveraPMFileReader reader) : base(reader) { }

        public PrimaveraPMFileReader() : base(new net.sf.mpxj.primavera.PrimaveraPMFileReader()) { }

        public new net.sf.mpxj.primavera.PrimaveraPMFileReader JavaObject => (net.sf.mpxj.primavera.PrimaveraPMFileReader)base.JavaObject;

        public IBaselineStrategy BaselineStrategy
        {      
            // TODO: implement proxy?
            //get => JavaObject.getBaselineStrategy();
            set => JavaObject.setBaselineStrategy(value.JavaObject);
        }

        public bool LinkCrossProjectRelations
        {
            get => JavaObject.getLinkCrossProjectRelations();
            set => JavaObject.setLinkCrossProjectRelations(value);
        }

        public Dictionary<int, string> ListProjects(Stream stream)
        {
            var projects = JavaObject.listProjects(new ProxyInputStream(stream));
            var result = new Dictionary<int, string>();
            foreach (var e in new ProxyEnumerable<java.util.Map.Entry, java.util.Map.Entry>(m => m, m => m, projects.entrySet()))
            {
                result.Add(((java.lang.Integer)e.getKey()).intValue(), (string)e.getValue());
            }
            return result;
        }
    }
}
