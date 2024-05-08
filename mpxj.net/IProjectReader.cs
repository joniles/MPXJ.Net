using System.Collections.Generic;
using System.IO;

namespace MPXJ.Net
{
    public interface IProjectReader
    {
        ProjectFile Read(string fileName);

        IList<ProjectFile> ReadAll(string fileName);

        ProjectFile Read(Stream inputStream);

        IList<ProjectFile> ReadAll(Stream inputStream);
    }
}
