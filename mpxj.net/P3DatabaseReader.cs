using System.Collections.Generic;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class P3DatabaseReader : AbstractProjectReader
    {
        internal P3DatabaseReader(org.mpxj.primavera.p3.P3DatabaseReader reader) : base(reader) { }

        public P3DatabaseReader() : base(new org.mpxj.primavera.p3.P3DatabaseReader()) { }

        public new org.mpxj.primavera.p3.P3DatabaseReader JavaObject => (org.mpxj.primavera.p3.P3DatabaseReader)base.JavaObject;

        public string ProjectName
        {
            set => JavaObject.setProjectName(value);
        }

        public static ProjectFile SetProjectNameAndRead(string directory)
        {
            return new ProjectFile(org.mpxj.primavera.p3.P3DatabaseReader.setProjectNameAndRead(new java.io.File(directory)));
        }

        public static IList<string> ListProjectNames(string directory)
        {
            return new ProxyList<string, string>(n => n, n=> n, org.mpxj.primavera.p3.P3DatabaseReader.listProjectNames(directory));
        }
    }
}
