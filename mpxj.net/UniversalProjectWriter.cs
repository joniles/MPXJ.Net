using MPXJ.Net.Proxy;
using System.IO;

namespace MPXJ.Net
{
    public class UniversalProjectWriter : IProjectWriter
    {
        public org.mpxj.writer.ProjectWriter JavaObject { get; }

        public UniversalProjectWriter(FileFormat format)
        {
            JavaObject = new org.mpxj.writer.UniversalProjectWriter(format.ConvertType());
        }

        public void Write(ProjectFile projectFile, string fileName) => JavaObject.write(projectFile.JavaObject, fileName);

        public void Write(ProjectFile projectFile, Stream outputStream) => JavaObject.write(projectFile.JavaObject, new ProxyOutputStream(outputStream));
    }
}
