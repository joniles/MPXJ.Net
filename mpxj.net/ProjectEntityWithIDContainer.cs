using System;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
	public class ProjectEntityWithIDContainer<M, N> : ProjectEntityContainer<M, N> where N : IJavaObjectProxy<M>
    {
        internal ProjectEntityWithIDContainer(Func<M, N> fromJava, Func<N, M> toJava, net.sf.mpxj.ProjectEntityWithIDContainer javaObject) : base(fromJava, toJava, javaObject) { }

        public new net.sf.mpxj.ProjectEntityWithIDContainer JavaObject => (net.sf.mpxj.ProjectEntityWithIDContainer)base.JavaObject;

        public N GetByID(int id)
        {
            return _fromJava((M)JavaObject.getByID(id.ConvertType()));
        }

        public void RenumberIDs() => JavaObject.renumberIDs();
    }
}

