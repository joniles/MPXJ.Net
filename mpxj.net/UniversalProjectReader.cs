using net.sf.mpxj;
using net.sf.mpxj.MpxjUtilities;

namespace org.mpxj;

public class UniversalProjectReader
{
    private readonly net.sf.mpxj.reader.UniversalProjectReader _proxy = new();

    public ProjectFile? Read(string name)
    {
        var result = _proxy.read(name);
        return result == null ? null : new ProjectFile(result);
    }

    public ProjectFile? Read(Stream stream)
    {
        var result = _proxy.read(new DotNetInputStream(stream));
        return result == null ? null : new ProjectFile(result);
    }
}

