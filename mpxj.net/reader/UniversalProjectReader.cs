using System.Collections.Generic;
using System.IO;
using net.sf.mpxj.MpxjUtilities;
using org.mpxj.proxy;

namespace org.mpxj.reader
{
    // TODO: implement more rader classes as required
    public class UniversalProjectReader : IJavaObjectProxy<net.sf.mpxj.reader.UniversalProjectReader>
    {
        public net.sf.mpxj.reader.UniversalProjectReader JavaObject { get; }  = new net.sf.mpxj.reader.UniversalProjectReader();

        // TODO: handle Properties argument
        // public ProjectReader setProperties(Properties props);

        public ProjectFile Read(string name) => Read(JavaObject.read(name));

        public ProjectFile Read(Stream stream) => Read(JavaObject.read(new DotNetInputStream(stream)));

        public List<ProjectFile> ReadAll(string name) => ReadAll(JavaObject.readAll(name));

        public List<ProjectFile> ReadAll(Stream stream) => ReadAll(JavaObject.readAll(new DotNetInputStream(stream)));

        private ProjectFile Read(net.sf.mpxj.ProjectFile file)
        {
            return file == null ? null : new ProjectFile(file);
        }

        private List<ProjectFile> ReadAll(java.util.List projects)
        {
            var list = new List<ProjectFile>();
            foreach (var file in projects.ToIEnumerable<net.sf.mpxj.ProjectFile>())
            {
                list.Add(new ProjectFile(file));
            }
            return list;
        }
    }
}

