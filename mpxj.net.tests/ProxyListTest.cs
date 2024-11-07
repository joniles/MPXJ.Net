using System;
using System.Collections;
using NUnit.Framework;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class ProxyListTest
    {
        [Test]
        public void MethodsTest()
        {
            var list = new ProxyList<java.lang.Double, double>(m => m.doubleValue(), java.lang.Double.valueOf, new java.util.ArrayList());
            Assert.That(list.IsReadOnly, Is.False);

            list.Add(1.0);
            list.Add(2.0);
            list.Add(3.0);
            Assert.That(list, Has.Count.EqualTo(3));

            list.Insert(1, 4.0);
            Assert.That(list, Has.Count.EqualTo(4));
            Assert.That(list[0], Is.EqualTo(1.0));
            Assert.That(list[1], Is.EqualTo(4.0));
            Assert.That(list[2], Is.EqualTo(2.0));
            Assert.That(list[3], Is.EqualTo(3.0));

            list.RemoveAt(1);
            Assert.That(list, Has.Count.EqualTo(3));
            Assert.That(list[0], Is.EqualTo(1.0));
            Assert.That(list[1], Is.EqualTo(2.0));
            Assert.That(list[2], Is.EqualTo(3.0));

            list.Remove(3.0);
            Assert.That(list, Has.Count.EqualTo(2));
            Assert.That(list[0], Is.EqualTo(1.0));
            Assert.That(list[1], Is.EqualTo(2.0));

            var array = new double[2];
            list.CopyTo(array, 0);
            Assert.That(array[0], Is.EqualTo(1.0));
            Assert.That(array[1], Is.EqualTo(2.0));


            using var enumerator = list.GetEnumerator();
            Assert.That(enumerator.MoveNext(), Is.True);
            Assert.That(enumerator.Current, Is.EqualTo(1.0));

            enumerator.Reset();
            Assert.That(enumerator.MoveNext(), Is.True);
            Assert.That(enumerator.Current, Is.EqualTo(1.0));

            var oldEnumerator = (list as IEnumerable).GetEnumerator();
            using var oldEnumeratorDisposal = oldEnumerator as IDisposable;
            Assert.That(oldEnumerator.MoveNext(), Is.True);
            Assert.That(oldEnumerator.Current, Is.EqualTo(1.0));

            list.Clear();
            Assert.That(list, Is.Empty);
        }
    }
}
