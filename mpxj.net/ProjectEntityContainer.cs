using System;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
	public class ProjectEntityContainer<M, N> : ProxyList<M, N>, IProjectEntityContainer<N>, IJavaObjectProxy<org.mpxj.ProjectEntityContainer> where N : IJavaObjectProxy<M>
	{
        public new org.mpxj.ProjectEntityContainer JavaObject => (org.mpxj.ProjectEntityContainer)base.JavaObject;

        internal ProjectEntityContainer(Func<M, N> fromJava, Func<N, M> toJava, org.mpxj.ProjectEntityContainer javaObject) : base(fromJava, toJava, javaObject) { }

        public N GetByUniqueID(int? id)
        {
            return _fromJava((M)JavaObject.getByUniqueID(id.ConvertType()));    
        }
    }
}
