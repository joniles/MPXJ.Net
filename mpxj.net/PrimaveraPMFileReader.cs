using System.IO;
using System.Collections.Generic;
using System.Linq;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class PrimaveraPMFileReader : AbstractProjectReader
    {
        internal PrimaveraPMFileReader(net.sf.mpxj.primavera.PrimaveraPMFileReader reader) : base(reader) { }

        public PrimaveraPMFileReader() : base(new net.sf.mpxj.primavera.PrimaveraPMFileReader()) { }

        public new net.sf.mpxj.primavera.PrimaveraPMFileReader JavaObject => (net.sf.mpxj.primavera.PrimaveraPMFileReader)base.JavaObject;

        public int ProjectID
        {
            set => JavaObject.setProjectID(value);
        }

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
            var projects = JavaObject.listProjects(stream.ConvertType());
            return new ProxyEnumerable<java.util.Map.Entry, java.util.Map.Entry>(m => m, m => m, projects.entrySet()).ToDictionary(e => ((java.lang.Integer)e.getKey()).intValue(), e => (string)e.getValue());
        }
    }
}
