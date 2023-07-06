using System;
using System.Collections;
using System.Collections.Generic;

namespace org.mpxj.proxy
{
	public class ShallowProxyEnumerable<M> : IEnumerable<M>, IJavaObjectProxy<java.lang.Iterable>
    {
        public struct Enumerator : IEnumerator<M>, IDisposable, IEnumerator
        {
            private readonly ShallowProxyEnumerable<M> _list;

            private java.util.Iterator _iter;

            private M _current;

            public M Current => _current;

            object IEnumerator.Current
            {
                get => _current;
            }

            internal Enumerator(ShallowProxyEnumerable<M> list)
            {
                _list = list;
                _iter = list.JavaObject.iterator();
                _current = default(M);
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

                _current = (M)_iter.next();
                return true;
            }

            public void Reset()
            {
                _iter = _list.JavaObject.iterator();
                _current = default(M);
            }
        }

        public java.lang.Iterable JavaObject { get; }

        public ShallowProxyEnumerable()
        {
            JavaObject = new java.util.ArrayList();
        }

        internal ShallowProxyEnumerable(java.lang.Iterable javaObject)
        {
            JavaObject = javaObject;
        }

        public IEnumerator<M> GetEnumerator()
        {
            return new Enumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new Enumerator(this);
        }
    }
}

