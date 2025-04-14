using System;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class MicrosoftScheduler: IScheduler, IJavaObjectProxy<org.mpxj.cpm.MicrosoftScheduler>
    {
        public org.mpxj.cpm.MicrosoftScheduler JavaObject { get; } = new org.mpxj.cpm.MicrosoftScheduler();

        public void Schedule(ProjectFile file, DateTime startDate)
        {
            JavaObject.schedule(file.JavaObject, startDate.ConvertType());
        }
    }
}