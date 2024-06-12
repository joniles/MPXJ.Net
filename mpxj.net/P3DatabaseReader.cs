using System.Collections.Generic;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class P3DatabaseReader : AbstractProjectReader
    {
        public P3DatabaseReader() : base(new net.sf.mpxj.primavera.p3.P3DatabaseReader()) { }

        public new net.sf.mpxj.primavera.p3.P3DatabaseReader JavaObject => (net.sf.mpxj.primavera.p3.P3DatabaseReader)base.JavaObject;

        public string ProjectName
        {
            set => JavaObject.setProjectName(value);
        }

        public static ProjectFile SetProjectNameAndRead(string directory)
        {
            return new ProjectFile(net.sf.mpxj.primavera.p3.P3DatabaseReader.setProjectNameAndRead(new java.io.File(directory)));
        }

        public static IList<string> ListProjectNames(string directory)
        {
            return new ProxyList<string, string>(n => n, n=> n, net.sf.mpxj.primavera.p3.P3DatabaseReader.listProjectNames(directory));
        }
    }
}
