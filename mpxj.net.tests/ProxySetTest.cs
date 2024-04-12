using System.Collections.Generic;
using NUnit.Framework;
using org.mpxj.proxy;

namespace org.mpxj
{
    public class ProxySetTest
    {
        [Test]
        public void MethodsTest()
        {
            var set = new ProxySet<java.lang.Integer, int>((m) => m.intValue(), (n) => java.lang.Integer.valueOf(n), new java.util.HashSet());
            Assert.That(set.IsReadOnly, Is.False);

            set.Add(1);
            set.Add(2);
            set.Add(3);
            Assert.That(set, Has.Count.EqualTo(3));
           
            set.UnionWith(new int[] { 3, 4 });
            Assert.That(set.SetEquals(new int[] { 1, 2, 3, 4 }), Is.True);

            set.Clear();
            set.Add(1);
            set.Add(2);
            set.Add(3);
            Assert.That(set, Has.Count.EqualTo(3));

            set.IntersectWith(new int[] { 3, 4 });
            Assert.That(set.SetEquals(new int[] { 3 }), Is.True);


            set.Clear();
            set.Add(1);
            set.Add(2);
            set.Add(3);
            set.ExceptWith(new int[] { 3, 4 });
            Assert.That(set.SetEquals(new int[] { 1, 2 }), Is.True);

            set.Clear();
            set.Add(1);
            set.Add(2);
            set.Add(3);
            set.SymmetricExceptWith(new int[] { 3, 4 });
            Assert.That(set.SetEquals(new int[] { 1, 2, 4 }), Is.True);

            set.Clear();
            set.Add(1);
            set.Add(2);
            set.Add(3);
            Assert.That(set.IsSubsetOf(new int[] { 1, 2, 3, 4 }), Is.True);
            Assert.That(set.IsSubsetOf(new int[] { 2, 3, 4 }), Is.False);
            Assert.That(set.IsSupersetOf(new int[] { 2, 3 }), Is.True);
            Assert.That(set.IsSupersetOf(new int[] { 2, 3, 4 }), Is.False);
            Assert.That(set.IsProperSubsetOf(new int[] { 1, 2, 3, 4 }), Is.True);
            Assert.That(set.IsProperSubsetOf(new int[] { 2, 3, 4 }), Is.False);
            Assert.That(set.IsProperSupersetOf(new int[] { 2, 3 }), Is.True);
            Assert.That(set.IsProperSupersetOf(new int[] { 2, 3, 4 }), Is.False);
            Assert.That(set.Overlaps(new int[] { 2, 3, 4 }), Is.True);

            set.Clear();

            var iset = set as ISet<int>;
            iset.Add(1);
            Assert.That(set, Has.Count.EqualTo(1));
        }
    }
}
