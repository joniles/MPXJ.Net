using System.Collections.Generic;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class MPDFileReader : AbstractProjectReader
    {
        public MPDFileReader() : base(new net.sf.mpxj.mpd.MPDFileReader()) { }

        public new net.sf.mpxj.mpd.MPDFileReader JavaObject => (net.sf.mpxj.mpd.MPDFileReader)base.JavaObject;

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
