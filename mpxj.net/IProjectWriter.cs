using MPXJ.Net.Proxy;
using System.IO;

namespace MPXJ.Net
{
    public interface IProjectWriter : IJavaObjectProxy<net.sf.mpxj.writer.ProjectWriter>
    {
        void Write(ProjectFile projectFile, string fileName);

        void Write(ProjectFile projectFile, Stream outputStream);
    }
}
