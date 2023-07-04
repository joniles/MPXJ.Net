using System.Collections.Generic;

namespace org.mpxj
{
	public interface IChildTaskContainer
	{
        IList<Task> ChildTasks { get; }
         
        Task AddTask();
    }
}
