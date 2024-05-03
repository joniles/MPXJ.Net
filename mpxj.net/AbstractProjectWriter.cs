using MPXJ.Net.Proxy;
using System.IO;

namespace MPXJ.Net
{
    public class AbstractProjectWriter : IProjectWriter<net.sf.mpxj.writer.AbstractProjectWriter>
    {
        public net.sf.mpxj.writer.AbstractProjectWriter JavaObject { get; }

        public void Write(ProjectFile projectFile, string fileName) => JavaObject.write(projectFile.JavaObject, fileName);

        public void Write(ProjectFile projectFile, Stream outputStream) => JavaObject.write(projectFile.JavaObject, new ProxyOutputStream(outputStream));
    }
}
