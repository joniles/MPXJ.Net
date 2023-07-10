using System.Collections.Generic;

namespace org.mpxj.proxy
{
	public class DeepProxyList<M, N> : DeepProxyCollection<M, N>, IList<N>, IJavaObjectProxy<java.util.List> where N : IJavaObjectProxy<M>
    {
        public new java.util.List JavaObject { get => (java.util.List)base.JavaObject; }

        internal DeepProxyList(ProxyManager proxyManager, java.util.List javaObject) : base(proxyManager, javaObject) { }

        public N this[int index]
        {
            get => (N)JavaObject.get(index);
            set => JavaObject.set(index, value);
        }
        public int IndexOf(N item)
        {
            return JavaObject.indexOf(item);
        }

        public void Insert(int index, N item)
        {
            JavaObject.set(index, item.JavaObject);
        }

        public void RemoveAt(int index)
        {
            JavaObject.remove(index);
        }
    }
}

