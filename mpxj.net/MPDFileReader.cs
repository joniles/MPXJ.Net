using System.Collections.Generic;
using System.Linq;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class MPDFileReader : AbstractProjectReader
    {
        internal MPDFileReader(net.sf.mpxj.mpd.MPDFileReader reader) : base(reader) { }

        public MPDFileReader() : base(new net.sf.mpxj.mpd.MPDFileReader()) { }

        public new net.sf.mpxj.mpd.MPDFileReader JavaObject => (net.sf.mpxj.mpd.MPDFileReader)base.JavaObject;

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
