using MPXJ.Net;

namespace Samples
{
    public class Convert
    {
        public void Execute()
        {            
            var project = new UniversalProjectReader().Read("example.mpp");
            new UniversalProjectWriter(FileFormat.MPX).Write(project, "example.mpx");
        }
    }
}
