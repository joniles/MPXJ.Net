using System.IO;
using net.sf.mpxj.MpxjUtilities;

namespace org.mpxj
{
    public class UniversalProjectReader : IJavaObjectProxy<net.sf.mpxj.reader.UniversalProjectReader>
    {
        public net.sf.mpxj.reader.UniversalProjectReader JavaObject { get; }  = new net.sf.mpxj.reader.UniversalProjectReader();

        public ProjectFile Read(string name)
        {
            var result = JavaObject.read(name);
            return result == null ? null : new ProjectFile(result);
        }

        public ProjectFile Read(Stream stream)
        {
            var result = JavaObject.read(new DotNetInputStream(stream));
            return result == null ? null : new ProjectFile(result);
        }
    }
}

