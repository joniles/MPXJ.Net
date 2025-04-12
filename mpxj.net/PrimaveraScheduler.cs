using System;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class PrimaveraScheduler : IScheduler, IJavaObjectProxy<net.sf.mpxj.cpm.PrimaveraScheduler>
    {
        public net.sf.mpxj.cpm.PrimaveraScheduler JavaObject { get; } = new net.sf.mpxj.cpm.PrimaveraScheduler();

        public void Schedule(ProjectFile file, DateTime startDate)
        {
            JavaObject.schedule(file.JavaObject, startDate.ConvertType());
        }
    }
}