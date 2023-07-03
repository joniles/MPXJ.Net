using net.sf.mpxj;

namespace org.mpxj
{
	public class ProjectEntityContainer<M, N> : DeepProxyList<M, N>, IProjectEntityContainer<N>, IJavaObjectProxy<net.sf.mpxj.ProjectEntityContainer> where N : IJavaObjectProxy<M>
	{
        public new net.sf.mpxj.ProjectEntityContainer JavaObject { get => (net.sf.mpxj.ProjectEntityContainer)base.JavaObject; }

        internal ProjectEntityContainer(ProjectFile projectFile, net.sf.mpxj.ProjectEntityContainer javaObject) : base(projectFile, javaObject) { }

        public N GetByUniqueID(java.lang.Integer id)
        {
            return (N)_projectFile.GenericProxyObject(JavaObject.getByUniqueID(id));    
        }
    }
}

