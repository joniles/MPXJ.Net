using MPXJ.Net.Proxy;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MPXJ.Net
{
    public abstract class AbstractProjectReader : IProjectReader
    {
        protected net.sf.mpxj.reader.AbstractProjectReader JavaObject { get; }

        protected AbstractProjectReader(net.sf.mpxj.reader.AbstractProjectReader javaObject)
        {
            JavaObject = javaObject;
        }

        public ProjectFile Read(string name) => Read(JavaObject.read(name));

        public ProjectFile Read(Stream stream) => Read(JavaObject.read(stream.ConvertType()));

        public IList<ProjectFile> ReadAll(string name) => ReadAll(JavaObject.readAll(name));

        public IList<ProjectFile> ReadAll(Stream stream) => ReadAll(JavaObject.readAll(stream.ConvertType()));

        protected ProjectFile Read(net.sf.mpxj.ProjectFile file)
        {
            return file == null ? null : new ProjectFile(file);
        }

        protected IList<ProjectFile> ReadAll(java.util.List projects)
        {
            // ensure that all ProjectFile instances returned by ReadAll share the same proxy manager
            var proxyManager = new ProxyManager();
            return projects.toArray().Select(file => new ProjectFile(proxyManager, (net.sf.mpxj.ProjectFile)file)).ToList();
        }

    }
}
