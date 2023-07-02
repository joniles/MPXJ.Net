using System;
using System.Collections;
using System.Collections.Generic;

namespace org.mpxj
{
    public class ProxyList<M> : IList<M>, IJavaObjectProxy<java.util.List>
    {
        public struct Enumerator : IEnumerator<M>, IDisposable, IEnumerator
        {
            private readonly ProxyList<M> _list;

            private java.util.Iterator _iter;

            private M _current;

            public M Current => _current;

            object IEnumerator.Current
            {
                get => _current;
            }

            internal Enumerator(ProxyList<M> list)
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

        public java.util.List JavaObject { get; }

        public ProxyList()
        {
            JavaObject = new java.util.ArrayList();
        }

        internal ProxyList(java.util.List javaObject)
        {
            JavaObject = javaObject;
        }

        public M this[int index]
        {
            get => (M)JavaObject.get(index);
            set => JavaObject.set(index, value);
        }

        public int Count => JavaObject.size();

        public bool IsReadOnly => false;

        public void Add(M item)
        {
            JavaObject.add(item);
        }

        public int Add(object value)
        {
            JavaObject.add(value);
            return JavaObject.size() - 1;
        }

        public void Clear()
        {
            JavaObject.clear();
        }

        public bool Contains(M item)
        {
            return JavaObject.contains(item);
        }

        public void CopyTo(M[] array, int arrayIndex)
        {
            foreach (M item in this)
            {
                array[arrayIndex++] = item;
            }
        }

        public IEnumerator<M> GetEnumerator()
        {
            return new Enumerator(this);
        }

        public int IndexOf(M item)
        {
            return JavaObject.indexOf(item);
        }

        public void Insert(int index, M item)
        {
            JavaObject.set(index, item);
        }

        public bool Remove(M item)
        {
            return JavaObject.remove(item);
        }

        public void RemoveAt(int index)
        {
            JavaObject.remove(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new Enumerator(this);
        }
    }
}
