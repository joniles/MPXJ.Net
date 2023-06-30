namespace org.mpxj
{
	public class ProjectEntity
	{
		public ProjectFile Parent { get; }

		public ProjectEntity(ProjectFile parent)
		{
			Parent = parent;
		}
	}
}

