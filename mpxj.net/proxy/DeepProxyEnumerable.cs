using System;
using System.Collections;
using System.Collections.Generic;

namespace org.mpxj.proxy
{
	public class DeepProxyEnumerable<N> : IEnumerable<N>, IJavaObjectProxy<java.lang.Iterable>
    {
        public struct Enumerator : IEnumerator<N>, IDisposable, IEnumerator
        {
            private readonly DeepProxyEnumerable<N> _list;

            private java.util.Iterator _iter;

            private N _current;

            public N Current => _current;

            object IEnumerator.Current
            {
                get => _current;
            }

            internal Enumerator(DeepProxyEnumerable<N> list)
            {
                _list = list;
                _iter = list.JavaObject.iterator();
                _current = default(N);
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

                _current = (N)_list._proxyManager.GenericProxyObject(_iter.next());
                return true;
            }

            public void Reset()
            {
                _iter = _list.JavaObject.iterator();
                _current = default(N);
            }
        }

        internal readonly ProxyManager _proxyManager;
        public java.lang.Iterable JavaObject { get; }

        internal DeepProxyEnumerable(ProxyManager proxyManager, java.lang.Iterable javaObject)
        {
            _proxyManager = proxyManager;
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

