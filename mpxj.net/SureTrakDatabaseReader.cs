using System.Collections.Generic;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class SureTrakDatabaseReader : AbstractProjectReader
    {
        internal SureTrakDatabaseReader(org.mpxj.primavera.suretrak.SureTrakDatabaseReader reader) : base(reader) { }

        public SureTrakDatabaseReader() : base(new org.mpxj.primavera.suretrak.SureTrakDatabaseReader()) { }

        public new org.mpxj.primavera.suretrak.SureTrakDatabaseReader JavaObject => (org.mpxj.primavera.suretrak.SureTrakDatabaseReader)base.JavaObject;

        public string ProjectName
        {
            set => JavaObject.setProjectName(value);
        }

        public static ProjectFile SetProjectNameAndRead(string directory)
        {
            return new ProjectFile(org.mpxj.primavera.suretrak.SureTrakDatabaseReader.setProjectNameAndRead(new java.io.File(directory)));
        }

        public static IList<string> ListProjectNames(string directory)
        {
            return new ProxyList<string, string>(n => n, n => n, org.mpxj.primavera.suretrak.SureTrakDatabaseReader.listProjectNames(directory));
        }
    }
}
