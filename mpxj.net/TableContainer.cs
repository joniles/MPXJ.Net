using org.mpxj.proxy;

namespace org.mpxj
{
    public class TableContainer : ProxyList<net.sf.mpxj.Table, Table>
    {
        public new net.sf.mpxj.TableContainer JavaObject { get => (net.sf.mpxj.TableContainer)base.JavaObject; }

        internal TableContainer(ProxyManager proxyManager, net.sf.mpxj.TableContainer javaObject) : base(proxyManager, javaObject) { }

        public net.sf.mpxj.Table GetTaskTableByName(string name)
        {
            return JavaObject.getTaskTableByName(name);
        }

        public net.sf.mpxj.Table GetResourceTableByName(string name)
        {
            return JavaObject.getResourceTableByName(name);
        }
    }
}
