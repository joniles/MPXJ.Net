using System;
using System.Collections;
using System.Collections.Generic;

namespace org.mpxj
{
    public class ProxyList<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection, IReadOnlyList<T>, IReadOnlyCollection<T>, IJavaObjectProxy<java.util.List>
    {
        public struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator
        {
            private readonly ProxyList<T> _list;

            private java.util.Iterator _iter;

            private T _current;

            public T Current => _current;

            object IEnumerator.Current
            {
                get => _current;
            }

            internal Enumerator(ProxyList<T> list)
            {
                _list = list;
                _iter = list.JavaObject.iterator();
                _current = default(T);
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

                _current = (T)_iter.next();
                return true;
            }

            public void Reset()
            {
                _iter = _list.JavaObject.iterator();
                _current = default(T);
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
            var x = new List<int>();
        }

        public T this[int index]
        {
            get => (T)JavaObject.get(index);
            set => JavaObject.set(index, value);
        }

        object IList.this[int index]
        {
            get => JavaObject.get(index);
            set => JavaObject.set(index, value);
        }

        public int Count => JavaObject.size();

        public bool IsReadOnly => false;

        public bool IsFixedSize => false;

        public bool IsSynchronized => false;

        public object SyncRoot => throw new NotImplementedException();

        public void Add(T item)
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

        public bool Contains(T item)
        {
            return JavaObject.contains(item);
        }

        public bool Contains(object value)
        {
            return JavaObject.contains(value);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            foreach (T item in this)
            {
                array[arrayIndex++] = item;
            }
        }

        public void CopyTo(Array array, int index)
        {
            foreach (T item in this)
            {
                array.SetValue(item, index++);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new Enumerator(this);
        }

        public int IndexOf(T item)
        {
            return JavaObject.indexOf(item);
        }

        public int IndexOf(object value)
        {
            return JavaObject.indexOf(value);
        }

        public void Insert(int index, T item)
        {
            JavaObject.set(index, item);
        }

        public void Insert(int index, object value)
        {
            JavaObject.set(index, value);
        }

        public bool Remove(T item)
        {
            return JavaObject.remove(item);
        }

        public void Remove(object value)
        {
            JavaObject.remove(value);
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
