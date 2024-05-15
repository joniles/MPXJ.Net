using System.Collections.Generic;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
	public class Table : IJavaObjectProxy<net.sf.mpxj.Table>
    {
        internal readonly ProxyManager _proxyManager;
        public net.sf.mpxj.Table JavaObject { get; }

        internal Table(ProxyManager proxyManager, net.sf.mpxj.Table javaObject)
        {
            _proxyManager = proxyManager;
            JavaObject = javaObject;
        }

        public int ID => JavaObject.getID();

        public string Name => JavaObject.getName();

        public bool ResourceFlag => JavaObject.getResourceFlag();

        public IList<Column> Columns => _proxyManager.ProxyList<net.sf.mpxj.Column, Column>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getColumns());

        public override string ToString() => JavaObject.toString();
    }
}
