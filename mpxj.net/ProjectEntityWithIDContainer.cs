using System;
using org.mpxj.proxy;

namespace org.mpxj
{
	public class ProjectEntityWithIDContainer<M, N> : ProjectEntityContainer<M, N> where N : IJavaObjectProxy<M>
    {
        internal ProjectEntityWithIDContainer(Func<M, N> fromJava, Func<N, M> toJava, net.sf.mpxj.ProjectEntityWithIDContainer javaObject) : base(fromJava, toJava, javaObject) { }

        public new net.sf.mpxj.ProjectEntityWithIDContainer JavaObject { get => (net.sf.mpxj.ProjectEntityWithIDContainer)base.JavaObject; }

        public N GetByID(java.lang.Integer id)
        {
            return _fromJava((M)JavaObject.getByID(id));
        }
    }
}

