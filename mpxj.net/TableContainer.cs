using org.mpxj.proxy;

namespace org.mpxj
{
    public class TableContainer : ProxyList<net.sf.mpxj.Table, Table>
    {
        public new net.sf.mpxj.TableContainer JavaObject => (net.sf.mpxj.TableContainer)base.JavaObject;

        internal TableContainer(ProxyManager proxyManager, net.sf.mpxj.TableContainer javaObject) : base(proxyManager.ProxyObject, value => value.JavaObject, javaObject) { }

        public Table GetTaskTableByName(string name) => _fromJava(JavaObject.getTaskTableByName(name));

        public Table GetResourceTableByName(string name) => _fromJava(JavaObject.getResourceTableByName(name));
    }
}
