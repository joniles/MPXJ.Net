using System.Collections;

namespace org.mpxj;

public class ProxyList<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection, IReadOnlyList<T>, IReadOnlyCollection<T>
{
    public struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator
    {
        private readonly ProxyList<T> _list;

        private java.util.Iterator _iter;

        private T _current;

        public T Current => _current;

        object? IEnumerator.Current
        {
            get => _current;
        }

        internal Enumerator(ProxyList<T> list)
        {
            _list = list;
            _iter = list._proxy.iterator();
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
            _iter = _list._proxy.iterator();
            _current = default(T);
        }
    }

    internal readonly java.util.List _proxy;

    public ProxyList()
    {
        _proxy = new java.util.ArrayList();
    }

    internal ProxyList(java.util.List proxy)
    {
        _proxy = proxy;
        var x = new List<int>();
    }

    public T this[int index]
    {
        get => (T)_proxy.get(index);
        set => _proxy.set(index, value);
    }

    object? IList.this[int index]
    {
        get => _proxy.get(index);
        set => _proxy.set(index, value);
    }

    public int Count => _proxy.size();

    public bool IsReadOnly => false;

    public bool IsFixedSize => false;

    public bool IsSynchronized => false;

    public object SyncRoot => throw new NotImplementedException();

    public void Add(T item)
    {
        _proxy.add(item);
    }

    public int Add(object? value)
    {
        _proxy.add(value);
        return _proxy.size() - 1;
    }

    public void Clear()
    {
        _proxy.clear();
    }

    public bool Contains(T item)
    {
        return _proxy.contains(item);
    }

    public bool Contains(object? value)
    {
        return _proxy.contains(value);
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
        return _proxy.indexOf(item);
    }

    public int IndexOf(object? value)
    {
        return _proxy.indexOf(value);
    }

    public void Insert(int index, T item)
    {
        _proxy.set(index, item);
    }

    public void Insert(int index, object? value)
    {
        _proxy.set(index, value);
    }

    public bool Remove(T item)
    {
        return _proxy.remove(item);
    }

    public void Remove(object? value)
    {
        _proxy.remove(value);
    }

    public void RemoveAt(int index)
    {
        _proxy.remove(index);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return new Enumerator(this);
    }
}
