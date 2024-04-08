using System;
using System.Collections.Generic;

namespace org.mpxj.proxy
{
	public class ProxySet<M, N> : ProxyCollection<M, N>, ISet<N>, IJavaObjectProxy<java.util.Set>
    {
        public new java.util.Set JavaObject { get => (java.util.Set)base.JavaObject; }

        internal ProxySet(Func<M, N> fromJava, Func<N, M> toJava, java.util.Set javaObject) : base(fromJava, toJava, javaObject) { }

        private delegate void UpdateSet(ISet<N> set);

        // TODO: replace methods using this with native implementations?
        private void Apply(UpdateSet update)
        {
            var set = new HashSet<N>(this);
            update(set);
            JavaObject.clear();
            foreach (N item in set)
            {
                JavaObject.add(_toJava(item));
            }
        }

        bool ISet<N>.Add(N item) => JavaObject.add(_toJava(item));

        public void UnionWith(IEnumerable<N> other) => Apply((set) => set.UnionWith(other));

        public void IntersectWith(IEnumerable<N> other) => Apply((set) => set.IntersectWith(other));

        public void ExceptWith(IEnumerable<N> other) => Apply((set) => set.ExceptWith(other));

        public void SymmetricExceptWith(IEnumerable<N> other) => Apply((set) => set.ExceptWith(other));

        public bool IsSubsetOf(IEnumerable<N> other) => new HashSet<N>(this).IsSubsetOf(other);

        public bool IsSupersetOf(IEnumerable<N> other) => new HashSet<N>(this).IsSupersetOf(other);

        public bool IsProperSupersetOf(IEnumerable<N> other) => new HashSet<N>(this).IsProperSupersetOf(other);

        public bool IsProperSubsetOf(IEnumerable<N> other) => new HashSet<N>(this).IsProperSubsetOf(other);

        public bool Overlaps(IEnumerable<N> other) => new HashSet<N>(this).Overlaps(other);

        public bool SetEquals(IEnumerable<N> other) => new HashSet<N>(this).SetEquals(other);
    }
}

