using MPXJ.Net.Proxy;
using System.IO;

namespace MPXJ.Net
{
    public abstract class AbstractProjectWriter : IProjectWriter
    {
        public net.sf.mpxj.writer.ProjectWriter JavaObject { get; set; }

        public AbstractProjectWriter(net.sf.mpxj.writer.AbstractProjectWriter writer)
        {
            JavaObject = writer;
        }

        public void Write(ProjectFile projectFile, string fileName) => JavaObject.write(projectFile.JavaObject, fileName);

        public void Write(ProjectFile projectFile, Stream outputStream) => JavaObject.write(projectFile.JavaObject, new ProxyOutputStream(outputStream));
    }
}
