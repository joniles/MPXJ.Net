using System.Collections.Generic;

namespace MPXJ.Net
{
	public interface IChildTaskContainer
	{
        IList<Task> ChildTasks { get; }
         
        Task AddTask();
    }
}
