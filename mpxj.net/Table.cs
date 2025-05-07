using System.Collections.Generic;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
	public class Table : IJavaObjectProxy<org.mpxj.Table>
    {
        private readonly ProxyManager _proxyManager;
        public org.mpxj.Table JavaObject { get; }

        internal Table(ProxyManager proxyManager, org.mpxj.Table javaObject)
        {
            _proxyManager = proxyManager;
            JavaObject = javaObject;
        }

        public int ID => JavaObject.getID();

        public string Name => JavaObject.getName();

        public bool ResourceFlag => JavaObject.getResourceFlag();

        public IList<Column> Columns => _proxyManager.ProxyList<org.mpxj.Column, Column>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getColumns());

        public override string ToString() => JavaObject.toString();
    }
}
