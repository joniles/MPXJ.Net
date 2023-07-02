using System.Collections.Generic;

namespace org.mpxj
{
	public interface IChildResourceContainer
	{
        IList<Resource> ChildResources { get; }

        Resource AddResource();
    }
}
