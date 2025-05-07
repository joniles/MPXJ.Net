using System;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
	public class ProjectEntityWithIDContainer<M, N> : ProjectEntityContainer<M, N> where N : IJavaObjectProxy<M>
    {
        internal ProjectEntityWithIDContainer(Func<M, N> fromJava, Func<N, M> toJava, org.mpxj.ProjectEntityWithIDContainer javaObject) : base(fromJava, toJava, javaObject) { }

        protected new org.mpxj.ProjectEntityWithIDContainer JavaObject => (org.mpxj.ProjectEntityWithIDContainer)base.JavaObject;

        public N GetByID(int id)
        {
            return _fromJava((M)JavaObject.getByID(id.ConvertType()));
        }

        public void RenumberIDs() => JavaObject.renumberIDs();
    }
}

