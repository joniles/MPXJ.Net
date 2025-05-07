using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class TableContainer : ProxyList<org.mpxj.Table, Table>
    {
        public new org.mpxj.TableContainer JavaObject => (org.mpxj.TableContainer)base.JavaObject;

        internal TableContainer(ProxyManager proxyManager, org.mpxj.TableContainer javaObject) : base(proxyManager.ProxyObject, value => value.JavaObject, javaObject) { }

        public Table GetTaskTableByName(string name) => _fromJava(JavaObject.getTaskTableByName(name));

        public Table GetResourceTableByName(string name) => _fromJava(JavaObject.getResourceTableByName(name));
    }
}
