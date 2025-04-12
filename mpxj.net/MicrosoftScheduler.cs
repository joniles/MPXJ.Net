using System;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class MicrosoftScheduler: IScheduler, IJavaObjectProxy<net.sf.mpxj.cpm.MicrosoftScheduler>
    {
        public net.sf.mpxj.cpm.MicrosoftScheduler JavaObject { get; } = new net.sf.mpxj.cpm.MicrosoftScheduler();

        public void Schedule(ProjectFile file, DateTime startDate)
        {
            JavaObject.schedule(file.JavaObject, startDate.ConvertType());
        }
    }
}