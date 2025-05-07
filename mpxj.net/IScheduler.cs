using System;

namespace MPXJ.Net
{
    public interface IScheduler
    {
        void Schedule(ProjectFile file, DateTime startDate);
    }
}