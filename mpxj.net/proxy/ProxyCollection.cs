using System.Collections.Generic;

namespace org.mpxj.proxy
{
    public class ProxyCollection<M, N> : ProxyEnumerable<N>, ICollection<N>, IJavaObjectProxy<java.util.Collection> where N : IJavaObjectProxy<M>
    {
        public new java.util.Collection JavaObject { get => (java.util.Collection)base.JavaObject; }

        public int Count => JavaObject.size();

        public bool IsReadOnly => false;

        internal ProxyCollection(ProxyManager proxyManager, java.util.Collection javaObject) : base(proxyManager, javaObject) { }

        public void Add(N item)
        {
            JavaObject.add(item.JavaObject);
        }

        public void Clear()
        {
            JavaObject.clear();
        }

        public bool Contains(N item)
        {
            return JavaObject.contains(item.JavaObject);
        }

        public void CopyTo(N[] array, int arrayIndex)
        {
            foreach (N item in this)
            {
                array[arrayIndex++] = item;
            }
        }

        public bool Remove(N item)
        {
            return JavaObject.remove(item.JavaObject);
        }
    }
}
