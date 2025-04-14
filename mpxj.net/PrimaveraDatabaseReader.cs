using System.Collections.Generic;
using System.Linq;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class PrimaveraDatabaseReader : AbstractProjectReader
    {
        internal PrimaveraDatabaseReader(org.mpxj.primavera.PrimaveraDatabaseReader reader) : base(reader) { }

        public PrimaveraDatabaseReader() : base(new org.mpxj.primavera.PrimaveraDatabaseReader()) { }

        public new org.mpxj.primavera.PrimaveraDatabaseReader JavaObject => (org.mpxj.primavera.PrimaveraDatabaseReader)base.JavaObject;

        public java.sql.Connection Connection
        {
            set => JavaObject.setConnection(value);
        }

        public javax.sql.DataSource DataSource
        {
            set => JavaObject.setDataSource(value);
        }

        public string Schema
        {
            get => JavaObject.getSchema();
            set => JavaObject.setSchema(value);
        }

        public int ProjectID
        {
            set => JavaObject.setProjectID(value);
        }

        public bool IgnoreErrors
        {
            get => JavaObject.getIgnoreErrors();
            set => JavaObject.setIgnoreErrors(value);
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

        public Dictionary<int, string> ListProjects()
        {
            var projects = JavaObject.listProjects();
            return new ProxyEnumerable<java.util.Map.Entry, java.util.Map.Entry>(m => m, m => m, projects.entrySet()).ToDictionary(e => ((java.lang.Integer)e.getKey()).intValue(), e => (string)e.getValue());
        }

        public EPS ListEPS() => new EPS(JavaObject.listEps());
        
        public ProjectFile Read() => Read(JavaObject.read());

        public IList<ProjectFile> ReadAll() => ReadAll(JavaObject.readAll());
    }
}
