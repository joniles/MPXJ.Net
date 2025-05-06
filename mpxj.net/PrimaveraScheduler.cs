using System;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class PrimaveraScheduler : IScheduler, IJavaObjectProxy<org.mpxj.cpm.PrimaveraScheduler>
    {
        public org.mpxj.cpm.PrimaveraScheduler JavaObject { get; } = new org.mpxj.cpm.PrimaveraScheduler();

        public void Schedule(ProjectFile file, DateTime startDate)
        {
            JavaObject.schedule(file.JavaObject, startDate.ConvertType());
        }
    }
}