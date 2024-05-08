using MPXJ.Net.Proxy;
using System.Collections.Generic;
using System.IO;

namespace MPXJ.Net
{
    public abstract class AbstractProjectReader : IProjectReader
    {
        public net.sf.mpxj.reader.AbstractProjectReader JavaObject { get; set; }

        public ProjectFile Read(string name) => Read(JavaObject.read(name));

        public ProjectFile Read(Stream stream) => Read(JavaObject.read(new ProxyInputStream(stream)));

        public IList<ProjectFile> ReadAll(string name) => ReadAll(JavaObject.readAll(name));

        public IList<ProjectFile> ReadAll(Stream stream) => ReadAll(JavaObject.readAll(new ProxyInputStream(stream)));

        private ProjectFile Read(net.sf.mpxj.ProjectFile file)
        {
            return file == null ? null : new ProjectFile(file);
        }

        private IList<ProjectFile> ReadAll(java.util.List projects)
        {
            var list = new List<ProjectFile>();
            foreach (var file in projects.toArray())
            {
                list.Add(new ProjectFile((net.sf.mpxj.ProjectFile)file));
            }
            return list;
        }

    }
}
