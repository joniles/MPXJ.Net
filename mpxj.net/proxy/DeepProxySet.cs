using System;
using System.Collections.Generic;

namespace org.mpxj.proxy
{
    // TODO: implement incomplete methods
	public class DeepProxySet<M, N> : DeepProxyCollection<M, N>, ISet<N>, IJavaObjectProxy<java.util.Set> where N : IJavaObjectProxy<M>
    {
        public new java.util.Set JavaObject { get => (java.util.Set)base.JavaObject; }

        internal DeepProxySet(ProxyManager proxyManager, java.util.Set javaObject) : base(proxyManager, javaObject) { }

        bool ISet<N>.Add(N item)
        {
            return JavaObject.add(item.JavaObject);
        }

        public void UnionWith(IEnumerable<N> other)
        {
            if (other == null)
            {
                throw new ArgumentNullException();
            }

            foreach (N item in other)
            {
                JavaObject.add(item.JavaObject);
            }
        }

        public void IntersectWith(IEnumerable<N> other)
        {
            if (other == null)
            {
                throw new ArgumentNullException();
            }

            if (Count == 0 || other == this)
            {
                return;
            }

            ICollection<N> collection = other as ICollection<N>;
            if (collection != null)
            {
                if (collection.Count == 0)
                {
                    Clear();
                    return;
                }
            }

            var otherSet = new java.util.HashSet();
            foreach(N item in other)
            {
                otherSet.add(item.JavaObject);
            }

            JavaObject.retainAll(otherSet);
        }

        public void ExceptWith(IEnumerable<N> other)
        {
            if (other == null)
            {
                throw new ArgumentNullException();
            }

            if (Count == 0)
            {
                return;
            }

            if (other == this)
            {
                Clear();
                return;
            }

            foreach (N item in other)
            {
                Remove(item);
            }
        }

        public void SymmetricExceptWith(IEnumerable<N> other)
        {
            throw new System.NotImplementedException();
        }

        public bool IsSubsetOf(IEnumerable<N> other)
        {
            throw new System.NotImplementedException();
        }

        public bool IsSupersetOf(IEnumerable<N> other)
        {
            throw new System.NotImplementedException();
        }

        public bool IsProperSupersetOf(IEnumerable<N> other)
        {
            throw new System.NotImplementedException();
        }

        public bool IsProperSubsetOf(IEnumerable<N> other)
        {
            throw new System.NotImplementedException();
        }

        public bool Overlaps(IEnumerable<N> other)
        {
            if (other == null)
            {
                throw new ArgumentNullException();
            }

            if (Count == 0)
            {
                return false;
            }

            if (other == this)
            {
                return true;
            }

            foreach (N item in other)
            {
                if (Contains(item))
                {
                    return true;
                }
            }

            return false;
        }

        public bool SetEquals(IEnumerable<N> other)
        {
            if (other == null)
            {
                throw new ArgumentNullException();
            }

            if (other == this)
            {
                return true;

            }

            if (Count == 0)
            {
                ICollection<N> collection = other as ICollection<N>;
                if (collection != null && collection.Count > 0)
                {
                    return false;
                }
            }

            var otherSet = new java.util.HashSet();
            foreach (N item in other)
            {
                otherSet.add(item.JavaObject);
            }

            return JavaObject.size() == otherSet.size() && JavaObject.containsAll(otherSet);
        }
    }
}

