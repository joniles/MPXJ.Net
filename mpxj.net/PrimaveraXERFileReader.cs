using System.Text;
using System.Collections.Generic;
using System.IO;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class PrimaveraXERFileReader : AbstractProjectReader
    {
        internal PrimaveraXERFileReader(net.sf.mpxj.primavera.PrimaveraXERFileReader reader) : base(reader) { }

        public PrimaveraXERFileReader() : base(new net.sf.mpxj.primavera.PrimaveraXERFileReader()) { }

        public new net.sf.mpxj.primavera.PrimaveraXERFileReader JavaObject => (net.sf.mpxj.primavera.PrimaveraXERFileReader)base.JavaObject;

        public Encoding Encoding
        {
            get => JavaObject.getCharset().ConvertType();
            set => JavaObject.setCharset(value.ConvertType());
        }

        public bool IgnoreErrors
        {
            get => JavaObject.getIgnoreErrors();
            set => JavaObject.setIgnoreErrors(value);
        }

        public bool LinkCrossProjectRelations
        {
            get => JavaObject.getLinkCrossProjectRelations();
            set => JavaObject.setLinkCrossProjectRelations(value);
        }

        public bool MatchPrimaveraWBS
        {
            get => JavaObject.getMatchPrimaveraWBS();
            set => JavaObject.setMatchPrimaveraWBS(value);
        }

        public bool WbsIsFullPath
        {
            get => JavaObject.getWbsIsFullPath();
            set => JavaObject.setWbsIsFullPath(value);
        }

        public int ProjectID
        {
            set => JavaObject.setProjectID(value);
        }

        public Dictionary<int, string> ListProjects(Stream stream)
        {
            var projects = JavaObject.listProjects(stream.ConvertType());
            var result = new Dictionary<int, string>();
            foreach (var e in new ProxyEnumerable<java.util.Map.Entry, java.util.Map.Entry>(m => m, m => m, projects.entrySet()))
            {
                result.Add(((java.lang.Integer)e.getKey()).intValue(), (string)e.getValue());
            }
            return result;
        }
    }
}
