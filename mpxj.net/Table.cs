using System.Collections.Generic;
using org.mpxj.proxy;

namespace org.mpxj
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

        public int ID
        {
            get => JavaObject.getID();
            set => JavaObject.setID(value);
        }

        public string Name
        {
            get => JavaObject.getName();
            set => JavaObject.setName(value);
        }

        public bool ResourceFlag
        {
            get => JavaObject.getResourceFlag();
            set => JavaObject.setResourceFlag(value);
        }

        public void AddColumn(Column column)
        {
            JavaObject.addColumn(column.JavaObject);
        }

        public IList<Column> Columns
        {
            get => _proxyManager.ProxyList<net.sf.mpxj.Column, Column>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getColumns());
        }

        public override string ToString()
        {
            return JavaObject.toString();
        }
    }
}

