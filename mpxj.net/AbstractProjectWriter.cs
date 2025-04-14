using MPXJ.Net.Proxy;
using System.IO;

namespace MPXJ.Net
{
    public abstract class AbstractProjectWriter : IProjectWriter
    {
        public org.mpxj.writer.ProjectWriter JavaObject { get; }

        protected AbstractProjectWriter(org.mpxj.writer.AbstractProjectWriter writer)
        {
            JavaObject = writer;
        }

        public void Write(ProjectFile projectFile, string fileName) => JavaObject.write(projectFile.JavaObject, fileName);

        public void Write(ProjectFile projectFile, Stream outputStream) => JavaObject.write(projectFile.JavaObject, new ProxyOutputStream(outputStream));
    }
}
