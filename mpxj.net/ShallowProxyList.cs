using System.Collections.Generic;

namespace org.mpxj
{
    public class ShallowProxyList<M> : ShallowProxyEnumerable<M>, IList<M>, IJavaObjectProxy<java.util.List>
    {
        public new java.util.List JavaObject { get => (java.util.List)base.JavaObject; }

        public ShallowProxyList() : base(new java.util.ArrayList()) { }

        internal ShallowProxyList(java.util.List javaObject) : base(javaObject) { }

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
    }
}
