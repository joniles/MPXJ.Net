using System;
using org.mpxj.proxy;

namespace org.mpxj
{
	public class ProjectEntityContainer<M, N> : ProxyList<M, N>, IProjectEntityContainer<N>, IJavaObjectProxy<net.sf.mpxj.ProjectEntityContainer> where N : IJavaObjectProxy<M>
	{
        public new net.sf.mpxj.ProjectEntityContainer JavaObject => (net.sf.mpxj.ProjectEntityContainer)base.JavaObject;

        internal ProjectEntityContainer(Func<M, N> fromJava, Func<N, M> toJava, net.sf.mpxj.ProjectEntityContainer javaObject) : base(fromJava, toJava, javaObject) { }

        public N GetByUniqueID(java.lang.Integer id)
        {
            return _fromJava((M)JavaObject.getByUniqueID(id));    
        }

        public java.lang.Integer NextUniqueID => JavaObject.getNextUniqueID();

        public void UpdateUniqueIdCounter()
        {
            JavaObject.updateUniqueIdCounter();
        }
    }
}
