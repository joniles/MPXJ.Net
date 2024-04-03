using System;
using System.Collections.Generic;

namespace org.mpxj.proxy
{
	public class ProxyList<M, N> : ProxyCollection<M, N>, IList<N>, IJavaObjectProxy<java.util.List>
    {
        public new java.util.List JavaObject { get => (java.util.List)base.JavaObject; }

        internal ProxyList(Func<M, N> fromJava, Func<N, M> toJava, java.util.List javaObject) : base(fromJava, toJava, javaObject) { }

        public N this[int index]
        {
            get => _fromJava((M)JavaObject.get(index));
            set => JavaObject.set(index, _toJava(value));
        }

        public int IndexOf(N item)
        {
            return JavaObject.indexOf(_toJava(item));
        }

        public void Insert(int index, N item)
        {
            JavaObject.add(index, _toJava(item));
        }

        public void RemoveAt(int index)
        {
            JavaObject.remove(index);
        }
    }
}

