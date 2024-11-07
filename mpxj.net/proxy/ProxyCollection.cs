using System;
using System.Collections.Generic;

namespace MPXJ.Net.Proxy
{
    public class ProxyCollection<M, N> : ProxyEnumerable<M, N>, ICollection<N>, IJavaObjectProxy<java.util.Collection>
    {
        public new java.util.Collection JavaObject => (java.util.Collection)base.JavaObject;

        public int Count => JavaObject.size();

        public bool IsReadOnly => false;

        internal ProxyCollection(Func<M, N> fromJava, Func<N, M> toJava, java.util.Collection javaObject) : base(fromJava, toJava, javaObject) { }

        public virtual void Add(N item)
        {
            JavaObject.add(_toJava(item));
        }

        public void Clear()
        {
            JavaObject.clear();
        }

        public bool Contains(N item)
        {
            return JavaObject.contains(_toJava(item));
        }

        public void CopyTo(N[] array, int arrayIndex)
        {
            foreach (var item in this)
            {
                array[arrayIndex++] = item;
            }
        }

        public bool Remove(N item)
        {
            return JavaObject.remove(_toJava(item));
        }
    }
}
