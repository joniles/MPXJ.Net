using System;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
	public class ProjectEntityContainer<M, N> : ProxyList<M, N>, IProjectEntityContainer<N>, IJavaObjectProxy<net.sf.mpxj.ProjectEntityContainer> where N : IJavaObjectProxy<M>
	{
        public new net.sf.mpxj.ProjectEntityContainer JavaObject => (net.sf.mpxj.ProjectEntityContainer)base.JavaObject;

        internal ProjectEntityContainer(Func<M, N> fromJava, Func<N, M> toJava, net.sf.mpxj.ProjectEntityContainer javaObject) : base(fromJava, toJava, javaObject) { }

        public N GetByUniqueID(int? id)
        {
            return _fromJava((M)JavaObject.getByUniqueID(id.ConvertType()));    
        }
    }
}
