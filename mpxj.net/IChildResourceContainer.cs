using System.Collections.Generic;

namespace MPXJ.Net
{
	public interface IChildResourceContainer
	{
        IList<Resource> ChildResources { get; }

        Resource AddResource();
    }
}
