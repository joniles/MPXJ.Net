namespace org.mpxj
{
	public class ProjectEntityWithIDContainer<N> : ProjectEntityContainer<N> where N : IProjectEntityWithID
    {
        internal ProjectEntityWithIDContainer(ProjectFile projectFile, net.sf.mpxj.ProjectEntityWithIDContainer javaObject) : base(projectFile, javaObject) { }

        public new net.sf.mpxj.ProjectEntityWithIDContainer JavaObject { get => (net.sf.mpxj.ProjectEntityWithIDContainer)base.JavaObject; }

        public N GetByID(java.lang.Integer id)
        {
            return (N)_projectFile.GenericProxyObject(JavaObject.getByID(id));
        }
    }
}

