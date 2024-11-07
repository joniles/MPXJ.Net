using System;
using System.Collections;
using System.Collections.Generic;

namespace MPXJ.Net.Proxy
{
	public class ProxyEnumerable<M, N> : IEnumerable<N>, IJavaObjectProxy<java.lang.Iterable>
    {
        public struct Enumerator : IEnumerator<N>
        {
            private readonly ProxyEnumerable<M,N> _list;

            private java.util.Iterator _iter;

            public N Current { get; private set; }

            object IEnumerator.Current => Current;

            internal Enumerator(ProxyEnumerable<M, N> list)
            {
                _list = list;
                _iter = list.JavaObject.iterator();
                Current = default;
            }

            public void Dispose()
            {
            }

            public bool MoveNext()
            {
                if (!_iter.hasNext())
                {
                    return false;
                }

                Current = _list._fromJava((M)_iter.next());
                return true;
            }

            public void Reset()
            {
                _iter = _list.JavaObject.iterator();
                Current = default;
            }
        }

        internal readonly Func<M, N> _fromJava;
        internal readonly Func<N, M> _toJava;
        public java.lang.Iterable JavaObject { get; }

        internal ProxyEnumerable(Func<M, N> fromJava, Func<N, M> toJava, java.lang.Iterable javaObject)
        {
            _fromJava = fromJava;
            _toJava = toJava;
            JavaObject = javaObject;
        }

        public IEnumerator<N> GetEnumerator()
        {
            return new Enumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new Enumerator(this);
        }
    }
}

