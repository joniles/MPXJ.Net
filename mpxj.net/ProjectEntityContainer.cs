using net.sf.mpxj;

namespace org.mpxj
{
	public class ProjectEntityContainer<N> : IProjectEntityContainer<N>, IJavaObjectProxy<net.sf.mpxj.ProjectEntityContainer>
	{
        internal readonly ProjectFile _projectFile;
        public ProjectEntityContainer JavaObject { get; }

        internal ProjectEntityContainer(ProjectFile projectFile, net.sf.mpxj.ProjectEntityContainer javaObject)
		{
            _projectFile = projectFile;
            JavaObject = javaObject;
		}

        public N GetByUniqueID(java.lang.Integer id)
        {
            return (N)_projectFile.GenericProxyObject(JavaObject.getByUniqueID(id));    
        }
    }
}

