using System;
using System.Collections;
using System.Collections.Generic;

namespace org.mpxj
{
	public class DeepProxyList<M, N> : IList<N>, IJavaObjectProxy<java.util.List> where N : IJavaObjectProxy<M>
    {
        public struct Enumerator<ME, NE> : IEnumerator<NE>, IDisposable, IEnumerator where NE : IJavaObjectProxy<ME>
        {
            private readonly DeepProxyList<ME, NE> _list;

            private java.util.Iterator _iter;

            private NE _current;

            public NE Current { get => _current; }

            object IEnumerator.Current
            {
                get => _current;
            }

            internal Enumerator(DeepProxyList<ME, NE> list)
            {
                _list = list;
                _iter = list.JavaObject.iterator();
                _current = default(NE);
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

                _current = (NE)_list._projectFile.GenericProxyObject(_iter.next());
                return true;
            }

            public void Reset()
            {
                _iter = _list.JavaObject.iterator();
                _current = default(NE);
            }
        }

        internal readonly ProjectFile _projectFile;
        public java.util.List JavaObject { get; }

        public DeepProxyList(ProjectFile projectFile)
        {
            _projectFile = projectFile;
            JavaObject = new java.util.ArrayList();
        }

        internal DeepProxyList(ProjectFile projectFile, java.util.List javaObject)
        {
            _projectFile = projectFile;
            JavaObject = javaObject;
        }

        public N this[int index]
        {
            get => (N)JavaObject.get(index);
            set => JavaObject.set(index, value);
        }

        public int Count => JavaObject.size();

        public bool IsReadOnly => false;

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

        public IEnumerator<N> GetEnumerator()
        {
            return new Enumerator<M, N>(this);
        }

        public int IndexOf(N item)
        {
            return JavaObject.indexOf(item);
        }

        public void Insert(int index, N item)
        {
            JavaObject.set(index, item.JavaObject);
        }

        public bool Remove(N item)
        {
            return JavaObject.remove(item.JavaObject);
        }

        public void RemoveAt(int index)
        {
            JavaObject.remove(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new Enumerator<M, N>(this);
        }
    }
}

