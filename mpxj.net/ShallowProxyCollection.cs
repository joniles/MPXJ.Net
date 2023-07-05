using System.Collections.Generic;

namespace org.mpxj
{
    public class ShallowProxyCollection<M> : ShallowProxyEnumerable<M>, ICollection<M>, IJavaObjectProxy<java.util.Collection>
    {
        public new java.util.Collection JavaObject { get => (java.util.Collection)base.JavaObject; }

        public int Count => throw new System.NotImplementedException();

        public bool IsReadOnly => throw new System.NotImplementedException();

        public ShallowProxyCollection() : base(new java.util.ArrayList()) { }

        internal ShallowProxyCollection(java.util.Collection javaObject) : base(javaObject) { }

        public void Add(M item)
        {
            JavaObject.add(item);
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

        public bool Remove(M item)
        {
            return JavaObject.remove(item);
        }
    }
}
